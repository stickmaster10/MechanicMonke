using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechanicMonke.SimpleJSON;
using Microsoft.Win32;
using MonkeModManager.Internals;
using static System.Windows.Forms.ListViewItem;

namespace MechanicMonke
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public string[] installLocationDefinitions =
        {
            // Have a common install directory that you play Gorilla Tag on? Send us a PR with this added here.

            // Steam
            @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag", // default
            @"C:\Program Files\\Steam\steamapps\common\Gorilla Tag",
            @"D:\Steam\\steamapps\common\Gorilla Tag",

            // Oculus
            @"C:\Program Files\Oculus\Software\Software\another-axiom-gorilla-tag", // default
            @"C:\Program Files (x86)\Oculus\Software\Software\another-axiom-gorilla-tag",
            @"D:\Oculus\Software\Software\another-axiom-gorilla-tag",
        };

        public void SetStatusText(string text)
        {
            statusText.Text = "Status: " + text;
        }

        string installLocation = null;
        string registryInstallLocation = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\MechanicMonke", "installLocation", null);

        public void FindInstallDirectory()
        {
            foreach (string definition in installLocationDefinitions)
            {
                if (System.IO.Directory.Exists(definition))
                {
                    // make sure it contains Gorilla Tag

                    if (System.IO.File.Exists(definition + @"\Gorilla Tag.exe"))
                    {
                        installLocation = definition;

                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\MechanicMonke", "installLocation", installLocation);
                        break;
                    }
                }
            }
        }

        public string ReturnGameInstallationPlatform(string path)
        {
            if (path.Contains("Gorilla Tag"))
            {
                return "Steam";
            }
            else if (path.Contains("another-axiom-gorilla-tag"))
            {
                return "Oculus";
            }
            else
            {
                return "Unknown";
            }
        }

        private CookieContainer PermCookie;

        private string DownloadSite(string URL)
        {
            try
            {
                if (PermCookie == null) { PermCookie = new CookieContainer(); }
                HttpWebRequest RQuest = (HttpWebRequest)HttpWebRequest.Create(URL);
                RQuest.Method = "GET";
                RQuest.KeepAlive = true;
                RQuest.CookieContainer = PermCookie;
                RQuest.ContentType = "application/x-www-form-urlencoded";
                RQuest.Referer = "";
                RQuest.UserAgent = "MechanicMonke";
                RQuest.Proxy = null;

                HttpWebResponse Response = (HttpWebResponse)RQuest.GetResponse();
                StreamReader Sr = new StreamReader(Response.GetResponseStream());
                string Code = Sr.ReadToEnd();
                Sr.Close();
                return Code;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("403"))
                {
                    MessageBox.Show("Failed to update version info, GitHub has rate limited you, please check back in 15 - 30 minutes", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error Unknown: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Process.GetCurrentProcess().Kill();
                return null;
            }
        }

        List<Mod> Mods = new List<Mod>();

        public void SearchDirForMods(string dir)
        {
            string[] files = Directory.GetFiles(dir);

            foreach (string file in files)
            {
                string fname = Path.GetFileName(file);
                fname = fname.Replace(" ", ""); // strip spaces
                ListViewItem fileListItem = Installed_ModList.Items.Add(fname);

                Mod AssociatedMod = null;

                foreach (Mod modInfo in Mods)
                {
                    foreach (string filename in modInfo.filenames)
                    {
                        if (fname == filename)
                        {
                            AssociatedMod = modInfo;
                            fileListItem.Checked = true;
                        }
                    }
                }

                if (AssociatedMod == null)
                {
                    for (int i = 0; i < Mods.Count; i++)
                    {
                        Mod modInfo = Mods[i];
                        foreach (string filename in modInfo.filenames)
                        {
                            if (fname.Contains(filename))
                            {
                                AssociatedMod = modInfo;
                                fileListItem.Checked = true;

                                return;
                            }
                        }
                    }
                }

                if (AssociatedMod != null)
                {
                    fileListItem.SubItems.Add(AssociatedMod.name);
                    fileListItem.SubItems.Add(AssociatedMod.author);
                    fileListItem.SubItems.Add(AssociatedMod.type);

                    if (AssociatedMod.type == "Mod")
                    {
                        fileListItem.Group = Installed_ModList.Groups[0];
                    }
                    else if (AssociatedMod.type == "Library")
                    {
                        fileListItem.Group = Installed_ModList.Groups[1];
                    }
                }
                else
                {
                    fileListItem.SubItems.Add("Unknown");
                    fileListItem.SubItems.Add("Unknown");
                    fileListItem.SubItems.Add("Unknown");
                    fileListItem.Group = Installed_ModList.Groups[3];
                }
            }
        }

        public void LoadMMMMods()
        {
            var decodedMods = JSON.Parse(DownloadSite("https://raw.githubusercontent.com/DeadlyKitten/MonkeModInfo/master/modinfo.json"));
            var decodedGroups = JSON.Parse(DownloadSite("https://raw.githubusercontent.com/DeadlyKitten/MonkeModInfo/master/groupinfo.json"));

            var allMods = decodedMods.AsArray;
            var allGroups = decodedGroups.AsArray;

            for (int i = 0; i < allMods.Count; i++)
            {
                JSONNode current = allMods[i];
                Mod release = new Mod(current["name"], current["author"], null, current["name"], "MMM_Mod", current["git_path"], current["download_url"]);
                //UpdateReleaseInfo(ref release);
                Mods.Add(release);
            }
        }

        public void RenderMods(bool ModsEnabled, bool LibrariesEnabled, bool MMMEnabled)
        {
            Catalog_ModList.Items.Clear();

            foreach (Mod jMod in Mods)
            {
                // ignore privatized mods (which are only listed on mods.json so they can be recognized successfully)
                if (jMod.repo == "EXC_PRIVATE") { continue; }

                ListViewItem kMod = Catalog_ModList.Items.Add(jMod.name);
                kMod.SubItems.Add(jMod.author);

                if (jMod.type == "Mod")
                {
                    if (ModsEnabled)
                    {
                        kMod.Group = Catalog_ModList.Groups[0];
                    } else
                    {
                        kMod.Remove();
                    }
                } else if (jMod.type == "Library")
                {
                    if (LibrariesEnabled)
                    {
                        kMod.Group = Catalog_ModList.Groups[1];
                    }
                    else
                    {
                        kMod.Remove();
                    }
                } else if (jMod.type == "MMM_Mod")
                {
                    if (MMMEnabled)
                    {
                        kMod.Group = Catalog_ModList.Groups[2];
                    }
                    else
                    {
                        kMod.Remove();
                    }
                } else
                {
                    kMod.Group = Catalog_ModList.Groups[3];
                }
            }
        }
            
        public void LoadGorillaTagInstall(string path)
        {
            pageControllers.Enabled = false;

            Mods = new List<Mod>(); // clear mod cache

            if (File.Exists(path + @"\Gorilla Tag.exe"))
            {
                installLocation = path;
                SetStatusText("Gorilla Tag directory found!");
                installDir.Text = "Platform: " + ReturnGameInstallationPlatform(installLocation);

                // get mod dictionary
                string ModContent = DownloadSite("https://raw.githubusercontent.com/binguszingus/MMDictionary/master/mods.json");

                JSONNode ModsJSON = null;
                if (ModContent != null && ModContent != "")
                {
                    ModsJSON = JSON.Parse(DownloadSite("https://raw.githubusercontent.com/binguszingus/MMDictionary/master/mods.json"));
                } else
                {
                    Application.Exit();
                }

                var ModsList = ModsJSON.AsArray;

                for (int i = 0; i < ModsList.Count; i++)
                {
                    JSONNode current = ModsList[i];
                    Mod release = new Mod(current["name"], current["author"], current["filenames"], current["keyword"], current["type"], current["repo"], current["download"]);
                    SetStatusText("Updating definition for mod : " + release.name);

                    Mods.Add(release);
                }

                // load mods
                Installed_ModList.Items.Clear();
                SetStatusText("Done!");

                if (Directory.Exists(installLocation + @"\BepInEx\plugins")) { SearchDirForMods(installLocation + @"\BepInEx\plugins"); }
                
                foreach (string dir in Directory.GetDirectories(installLocation + @"\BepInEx\plugins\"))
                {
                    SearchDirForMods(dir);
                }
            }

            LoadMMMMods();

            foreach (Mod jMod in Mods)
            {
                // ignore privatized mods (which are only listed on mods.json so they can be recognized successfully)
                if (jMod.repo == "EXC_PRIVATE") { continue; }

                ListViewItem kMod = Catalog_ModList.Items.Add(jMod.name);
                // kMod.SubItems.Add(jMod.name);
                kMod.SubItems.Add(jMod.author);
                // kMod.SubItems.Add(jMod.type);

                if (jMod.type == "Mod")
                {
                    kMod.Group = Catalog_ModList.Groups[0];
                } else if (jMod.type == "Library")
                {
                    kMod.Group = Catalog_ModList.Groups[1];
                } else if (jMod.type == "MMM_Mod")
                {
                    kMod.Group = Catalog_ModList.Groups[2];
                } else
                {
                    kMod.Group = Catalog_ModList.Groups[3];
                }
            }

            Filter_Mods.Checked = true;
            Filter_Libraries.Checked = true;
            Filter_MMM.Checked = true;

            pageControllers.SelectedTab = tabPage1;
            pageControllers.Enabled = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "MechanicMonke v" + version;

            SetStatusText("Looking for install directory...");

            if (registryInstallLocation != null)
            {
                SetStatusText("Found pre-existing found directory at " + registryInstallLocation);
                // revalidate install directory
                if (System.IO.Directory.Exists(registryInstallLocation))
                {
                    if (System.IO.File.Exists(registryInstallLocation + @"\Gorilla Tag.exe"))
                    {
                        installLocation = registryInstallLocation;
                    } else
                    {
                        FindInstallDirectory();
                    }
                } else
                {
                    FindInstallDirectory();
                }
            }
            else
            {
                FindInstallDirectory();
            }

            if (installLocation == null)
            {
                SetStatusText("Could not find Gorilla Tag install directory. Please select it manually (CTRL + O).");
                return;
            } else
            {
                LoadGorillaTagInstall(installLocation);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Gorilla Tag.exe";
            openFileDialog1.Multiselect = false;
            openFileDialog1.CheckFileExists = true;
            
            openFileDialog1.ShowDialog();

            LoadGorillaTagInstall(new FileInfo(openFileDialog1.FileName).Directory.FullName);
        }

        private void startGorillaTagexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (installLocation != null)
            {
                System.Diagnostics.Process.Start(installLocation + @"\Gorilla Tag.exe");
            }
            else
            {
                SetStatusText("Could not find Gorilla Tag install directory. Please select it manually.");
            }
        }

        private void installDirectoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (installLocation != null)
            {
                System.Diagnostics.Process.Start(installLocation);
            }
            else
            {
                SetStatusText("Could not find Gorilla Tag install directory. Please select it manually.");
            }
        }

        private void pluginsDirectoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (installLocation != null)
            {
                System.Diagnostics.Process.Start(installLocation + @"\BepInEx\plugins");
            }
            else
            {
                SetStatusText("Could not find Gorilla Tag install directory. Please select it manually.");
            }
        }

        public Mod GetModFromName(string ModName)
        {
            foreach (Mod mod in Mods)
            {
                if (mod.name == ModName || mod.keyword == ModName)
                {
                    return mod;
                }
            }

            return null;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // misclick
        }
        private void UnzipFile(byte[] data, string directory)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (var unzip = new Unzip(ms))
                {
                    unzip.ExtractToDirectory(directory);
                }
            }
        }
        private byte[] DownloadFile(string url)
        {
            WebClient client = new WebClient();
            client.Proxy = null;
            return client.DownloadData(url);
        }

        public void Install(Mod release)
        {
            SetStatusText(string.Format("Downloading... {0}", release.name));
            byte[] file = DownloadFile(release.download);
            Console.WriteLine("downloaded..");
            SetStatusText(string.Format("Installing...{0}", release.name));
            Console.WriteLine("installing..");
            string fileName = Path.GetFileName(release.keyword + ".dll");

            if (Path.GetExtension(fileName).Equals(".dll"))
            {
                string dir;

                dir = Path.Combine(installLocation, @"BepInEx\plugins", Regex.Replace(release.name, @"\s+", string.Empty));
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                File.WriteAllBytes(Path.Combine(dir, fileName), file);

                var dllFile = Path.Combine(installLocation, @"BepInEx\plugins", fileName);
                if (File.Exists(dllFile))
                {
                    File.Delete(dllFile);
                }
            }
            else
            {
                UnzipFile(file, installLocation);
            }

            SetStatusText(string.Format("Installed {0}!", release.name));
        }

        public void InstallLocal(string filename)
        {
            byte[] file = File.ReadAllBytes(filename);
            string fileName = Path.GetFileName(filename + ".dll");
            SetStatusText(string.Format("Installing...{0}", fileName));

            if (Path.GetExtension(fileName).Equals(".dll"))
            {
                string dir;

                dir = Path.Combine(installLocation, @"BepInEx\plugins", Regex.Replace(fileName, @"\s+", string.Empty));
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                File.WriteAllBytes(Path.Combine(dir, fileName), file);

                var dllFile = Path.Combine(installLocation, @"BepInEx\plugins", fileName);
                if (File.Exists(dllFile))
                {
                    File.Delete(dllFile);
                }
            }
            else
            {
                UnzipFile(file, installLocation);
            }

            SetStatusText(string.Format("Installed {0}!", fileName));
        }

        private void Installed_UpdModBtn_Click(object sender, EventArgs e)
        {
            List<ListViewItem> CheckedMods = Installed_ModList.CheckedItems.Cast<ListViewItem>().ToList();

            foreach (ListViewItem CheckedMod in CheckedMods)
            {
                Mod SelectedMod = GetModFromName(CheckedMod.SubItems[1].Text);

                if (SelectedMod == null)
                {
                    SystemSounds.Exclamation.Play();
                    SetStatusText("The mod " + CheckedMod.Text + " cannot be modified because it is not recognized as a mod.");
                }

                try
                {
                    Install(SelectedMod);
                }
                catch (Exception _ex)
                {
                    Console.WriteLine(_ex.Message);
                    SystemSounds.Exclamation.Play();
                    SetStatusText("The mod " + CheckedMod.Text + " could not be installed.");
                }
            }
        }

        private void moddingDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://gorillatagmodding.burrito.software/");
        }

        private void moddingGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/monkemod");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About Sophisticated_Cube = new About();
            Sophisticated_Cube.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ListViewItem> CheckedMods = Catalog_ModList.CheckedItems.Cast<ListViewItem>().ToList();

            foreach (ListViewItem CheckedMod in CheckedMods)
            {
                Mod SelectedMod = GetModFromName(CheckedMod.Text);

                if (SelectedMod == null)
                {
                    SystemSounds.Exclamation.Play();
                    SetStatusText("The mod " + CheckedMod.Text + " cannot be modified because it is not recognized as a mod.");
                }

                try
                {
                    Install(SelectedMod);
                }
                catch (Exception _ex)
                {
                    Console.WriteLine(_ex.Message);
                    SystemSounds.Exclamation.Play();
                    SetStatusText("The mod " + CheckedMod.Text + " could not be installed.");
                }
            }
        }

        private void filedllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.Title = "Select .dll or .zip file";
            openFileDialog1.Filter = "DLL Files|*.dll|ZIP Files|*.zip";

            openFileDialog1.ShowDialog();
            InstallLocal(openFileDialog1.FileName);
        }

        private void makeThisMyDefaultGorillaTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (installLocation == null)
            {
                SetStatusText("Could not find Gorilla Tag install directory. Please select it manually.");
                return;
            } else
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\MechanicMonke", "installLocation", installLocation);
                SetStatusText("Set " + installLocation + " as default Gorilla Tag install directory.");
            }
        }

        private void Filter_Mods_CheckedChanged(object sender, EventArgs e)
        {
            RenderMods(Filter_Mods.Checked, Filter_Libraries.Checked, Filter_MMM.Checked);
        }

        private void Filter_Libraries_CheckedChanged(object sender, EventArgs e)
        {
            RenderMods(Filter_Mods.Checked, Filter_Libraries.Checked, Filter_MMM.Checked);
        }

        private void Filter_MMM_CheckedChanged(object sender, EventArgs e)
        {
            RenderMods(Filter_Mods.Checked, Filter_Libraries.Checked, Filter_MMM.Checked);
        }
    }
    public class Mod
    {
        public string name;
        public string author;
        public List<string> filenames;
        public string keyword;
        public string type;
        public string repo;
        public string filepath;
        public bool installed;
        public string download;

        public Mod(string name, string author, JSONNode filenames_ij, string keyword, string type, string repo, string download)
        {
            this.name = name;
            this.author = author;
            this.filenames = new List<string>();
            this.keyword = keyword;
            this.type = type;
            this.repo = repo;
            this.filepath = "";
            this.installed = false;
            this.download = download;

            if (filenames_ij == null)
            {
                return;
            }

            JSONArray filenames_i = filenames_ij.AsArray;

            for (int i = 0; i < filenames_i.Count; i++)
            {
                string filename = filenames_i[i];
                if (filename == null) { filename = ""; }

                this.filenames.Add(filename);
            }
        }
    };
}
