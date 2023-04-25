using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager.src
{
    public partial class Settings : Form
    {
        static String folderPath = "";
        public Settings()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form form = new Home();
            FormState.settingsForm = this;
            this.Hide();
            form.ShowDialog();
        }

        private void openDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = this.folderBrowserDialog1;
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                String folderName = folderBrowserDialog1.SelectedPath;
                this.path.Text = folderName;
                folderPath = folderName;
            }
        }
    }
}
