using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicMonke
{
    public partial class StringPromptBox : Form
    {
        public string Output = "";
        public StringPromptBox(string message)
        {
            InitializeComponent();
            this.label.Text = message;

            okButton.Click += (sender, e) =>
            {
                Output = text.Text;
                this.Close();
            };

            cancelButton.Click += (sender, e) =>
            {
                Output = null;
                this.Close();
            };
        }
    }
}
