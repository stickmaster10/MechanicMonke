using System.Windows.Forms;

namespace MechanicMonke
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Mods", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Libraries", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("MonkeModManager", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Unknown", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Mods", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Libraries", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("MonkeModManager", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Uncategorized", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.installDir = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filedllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGorillaTagexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeThisMyDefaultGorillaTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moddingGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moddingDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pageControllers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Installed_UpdModBtn = new System.Windows.Forms.Button();
            this.Installed_ModList = new System.Windows.Forms.ListView();
            this.columnHeaderFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Filter_MMM = new System.Windows.Forms.CheckBox();
            this.Filter_Libraries = new System.Windows.Forms.CheckBox();
            this.Filter_Mods = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Catalog_ModList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pageControllers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(32, 2, 32, 2);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installDir,
            this.statusText});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 445);
            this.statusStrip.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(789, 20);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // installDir
            // 
            this.installDir.Name = "installDir";
            this.installDir.Size = new System.Drawing.Size(95, 15);
            this.installDir.Text = "No game loaded";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(97, 15);
            this.statusText.Text = "Status: Loading...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filedllToolStripMenuItem});
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.installToolStripMenuItem.Text = "Install";
            // 
            // filedllToolStripMenuItem
            // 
            this.filedllToolStripMenuItem.Name = "filedllToolStripMenuItem";
            this.filedllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.filedllToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.filedllToolStripMenuItem.Text = "File (*.dll, *.zip)";
            this.filedllToolStripMenuItem.Click += new System.EventHandler(this.filedllToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGorillaTagexeToolStripMenuItem,
            this.goToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.runToolStripMenuItem.Text = "Gorilla Tag";
            // 
            // startGorillaTagexeToolStripMenuItem
            // 
            this.startGorillaTagexeToolStripMenuItem.Name = "startGorillaTagexeToolStripMenuItem";
            this.startGorillaTagexeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.startGorillaTagexeToolStripMenuItem.Text = "Start Gorilla Tag.exe";
            this.startGorillaTagexeToolStripMenuItem.Click += new System.EventHandler(this.startGorillaTagexeToolStripMenuItem_Click);
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installDirectoryToolStripMenuItem,
            this.pluginsDirectoryToolStripMenuItem});
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.goToolStripMenuItem.Text = "Go";
            // 
            // installDirectoryToolStripMenuItem
            // 
            this.installDirectoryToolStripMenuItem.Name = "installDirectoryToolStripMenuItem";
            this.installDirectoryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.installDirectoryToolStripMenuItem.Text = "Install Directory";
            this.installDirectoryToolStripMenuItem.Click += new System.EventHandler(this.installDirectoryToolStripMenuItem_Click_1);
            // 
            // pluginsDirectoryToolStripMenuItem
            // 
            this.pluginsDirectoryToolStripMenuItem.Name = "pluginsDirectoryToolStripMenuItem";
            this.pluginsDirectoryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pluginsDirectoryToolStripMenuItem.Text = "Plugins Directory";
            this.pluginsDirectoryToolStripMenuItem.Click += new System.EventHandler(this.pluginsDirectoryToolStripMenuItem_Click_1);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeThisMyDefaultGorillaTagToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // makeThisMyDefaultGorillaTagToolStripMenuItem
            // 
            this.makeThisMyDefaultGorillaTagToolStripMenuItem.Name = "makeThisMyDefaultGorillaTagToolStripMenuItem";
            this.makeThisMyDefaultGorillaTagToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.makeThisMyDefaultGorillaTagToolStripMenuItem.Text = "Make this my default Gorilla Tag";
            this.makeThisMyDefaultGorillaTagToolStripMenuItem.Click += new System.EventHandler(this.makeThisMyDefaultGorillaTagToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moddingGuideToolStripMenuItem,
            this.moddingDiscordToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // moddingGuideToolStripMenuItem
            // 
            this.moddingGuideToolStripMenuItem.Name = "moddingGuideToolStripMenuItem";
            this.moddingGuideToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.moddingGuideToolStripMenuItem.Text = "Modding Guide";
            this.moddingGuideToolStripMenuItem.Click += new System.EventHandler(this.moddingGuideToolStripMenuItem_Click);
            // 
            // moddingDiscordToolStripMenuItem
            // 
            this.moddingDiscordToolStripMenuItem.Name = "moddingDiscordToolStripMenuItem";
            this.moddingDiscordToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.moddingDiscordToolStripMenuItem.Text = "Modding Discord";
            this.moddingDiscordToolStripMenuItem.Click += new System.EventHandler(this.moddingDiscordToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pageControllers
            // 
            this.pageControllers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageControllers.Controls.Add(this.tabPage1);
            this.pageControllers.Controls.Add(this.tabPage2);
            this.pageControllers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageControllers.Location = new System.Drawing.Point(0, 22);
            this.pageControllers.Name = "pageControllers";
            this.pageControllers.SelectedIndex = 0;
            this.pageControllers.Size = new System.Drawing.Size(789, 419);
            this.pageControllers.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Installed_UpdModBtn);
            this.tabPage1.Controls.Add(this.Installed_ModList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Installed";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Installed_UpdModBtn
            // 
            this.Installed_UpdModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Installed_UpdModBtn.Location = new System.Drawing.Point(8, 364);
            this.Installed_UpdModBtn.Name = "Installed_UpdModBtn";
            this.Installed_UpdModBtn.Size = new System.Drawing.Size(88, 23);
            this.Installed_UpdModBtn.TabIndex = 3;
            this.Installed_UpdModBtn.Text = "Update";
            this.Installed_UpdModBtn.UseVisualStyleBackColor = true;
            this.Installed_UpdModBtn.Click += new System.EventHandler(this.Installed_UpdModBtn_Click);
            // 
            // Installed_ModList
            // 
            this.Installed_ModList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Installed_ModList.CheckBoxes = true;
            this.Installed_ModList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFilename,
            this.columnHeaderMName,
            this.columnHeaderAuthor});
            this.Installed_ModList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Installed_ModList.FullRowSelect = true;
            listViewGroup1.Header = "Mods";
            listViewGroup1.Name = "mods";
            listViewGroup2.Header = "Libraries";
            listViewGroup2.Name = "libraries";
            listViewGroup3.Header = "MonkeModManager";
            listViewGroup3.Name = "mmm";
            listViewGroup4.Header = "Unknown";
            listViewGroup4.Name = "unknown";
            this.Installed_ModList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.Installed_ModList.HideSelection = false;
            this.Installed_ModList.Location = new System.Drawing.Point(8, 6);
            this.Installed_ModList.Name = "Installed_ModList";
            this.Installed_ModList.Size = new System.Drawing.Size(765, 352);
            this.Installed_ModList.TabIndex = 1;
            this.Installed_ModList.UseCompatibleStateImageBehavior = false;
            this.Installed_ModList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFilename
            // 
            this.columnHeaderFilename.Text = "File";
            this.columnHeaderFilename.Width = 193;
            // 
            // columnHeaderMName
            // 
            this.columnHeaderMName.Text = "Mod";
            this.columnHeaderMName.Width = 160;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            this.columnHeaderAuthor.Width = 204;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Filter_MMM);
            this.tabPage2.Controls.Add(this.Filter_Libraries);
            this.tabPage2.Controls.Add(this.Filter_Mods);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Catalog_ModList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(781, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Catalog";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filters";
            // 
            // Filter_MMM
            // 
            this.Filter_MMM.AutoSize = true;
            this.Filter_MMM.Location = new System.Drawing.Point(585, 106);
            this.Filter_MMM.Name = "Filter_MMM";
            this.Filter_MMM.Size = new System.Drawing.Size(169, 17);
            this.Filter_MMM.TabIndex = 7;
            this.Filter_MMM.Text = "MonkeModManager Library";
            this.Filter_MMM.UseVisualStyleBackColor = true;
            this.Filter_MMM.CheckedChanged += new System.EventHandler(this.Filter_MMM_CheckedChanged);
            // 
            // Filter_Libraries
            // 
            this.Filter_Libraries.AutoSize = true;
            this.Filter_Libraries.Location = new System.Drawing.Point(585, 67);
            this.Filter_Libraries.Name = "Filter_Libraries";
            this.Filter_Libraries.Size = new System.Drawing.Size(69, 17);
            this.Filter_Libraries.TabIndex = 6;
            this.Filter_Libraries.Text = "Libraries";
            this.Filter_Libraries.UseVisualStyleBackColor = true;
            this.Filter_Libraries.CheckedChanged += new System.EventHandler(this.Filter_Libraries_CheckedChanged);
            // 
            // Filter_Mods
            // 
            this.Filter_Mods.AutoSize = true;
            this.Filter_Mods.Location = new System.Drawing.Point(585, 44);
            this.Filter_Mods.Name = "Filter_Mods";
            this.Filter_Mods.Size = new System.Drawing.Size(55, 17);
            this.Filter_Mods.TabIndex = 5;
            this.Filter_Mods.Text = "Mods";
            this.Filter_Mods.UseVisualStyleBackColor = true;
            this.Filter_Mods.CheckedChanged += new System.EventHandler(this.Filter_Mods_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(9, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Catalog_ModList
            // 
            this.Catalog_ModList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Catalog_ModList.CheckBoxes = true;
            this.Catalog_ModList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.Catalog_ModList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catalog_ModList.FullRowSelect = true;
            listViewGroup5.Header = "Mods";
            listViewGroup5.Name = "mods";
            listViewGroup6.Header = "Libraries";
            listViewGroup6.Name = "libraries";
            listViewGroup7.Header = "MonkeModManager";
            listViewGroup7.Name = "mmm";
            listViewGroup8.Header = "Uncategorized";
            listViewGroup8.Name = "uncategorized";
            this.Catalog_ModList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8});
            this.Catalog_ModList.HideSelection = false;
            this.Catalog_ModList.Location = new System.Drawing.Point(9, 6);
            this.Catalog_ModList.Name = "Catalog_ModList";
            this.Catalog_ModList.Size = new System.Drawing.Size(560, 352);
            this.Catalog_ModList.TabIndex = 3;
            this.Catalog_ModList.UseCompatibleStateImageBehavior = false;
            this.Catalog_ModList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mod";
            this.columnHeader2.Width = 280;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Author";
            this.columnHeader3.Width = 257;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRepositoryToolStripMenuItem,
            this.installToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 48);
            // 
            // viewRepositoryToolStripMenuItem
            // 
            this.viewRepositoryToolStripMenuItem.Name = "viewRepositoryToolStripMenuItem";
            this.viewRepositoryToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.viewRepositoryToolStripMenuItem.Text = "View Repository";
            // 
            // installToolStripMenuItem1
            // 
            this.installToolStripMenuItem1.Name = "installToolStripMenuItem1";
            this.installToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.installToolStripMenuItem1.Text = "Install";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 465);
            this.Controls.Add(this.pageControllers);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "MechanicMonke v0.0.0.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pageControllers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filedllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moddingGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moddingDiscordToolStripMenuItem;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem startGorillaTagexeToolStripMenuItem;
        private ToolStripMenuItem goToolStripMenuItem;
        private ToolStripMenuItem installDirectoryToolStripMenuItem;
        private ToolStripMenuItem pluginsDirectoryToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripStatusLabel installDir;
        private TabControl pageControllers;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button Installed_UpdModBtn;
        private ListView Installed_ModList;
        private ColumnHeader columnHeaderFilename;
        private ColumnHeader columnHeaderAuthor;
        private ColumnHeader columnHeaderMName;
        private Button button1;
        private ListView Catalog_ModList;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripMenuItem makeThisMyDefaultGorillaTagToolStripMenuItem;
        private Label label1;
        private CheckBox Filter_MMM;
        private CheckBox Filter_Libraries;
        private CheckBox Filter_Mods;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem viewRepositoryToolStripMenuItem;
        private ToolStripMenuItem installToolStripMenuItem1;
    }
}

