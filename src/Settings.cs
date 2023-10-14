using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager.src
{
    public partial class Settings : Form
    {
        public String folderPath { get; set; }
        public Home homeForm { get; set; }
        public String txtFilePath { get; set; } = Environment.CurrentDirectory + "\\FolderPath.txt";
        public Settings(Home homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            try
            {
                this.folderPath = File.ReadAllText(txtFilePath);
            }
            catch
            {
                this.folderPath = "C:\\Users\\" + Environment.UserName;
            }
            this.path.Text = folderPath;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void home_Click(object sender, EventArgs e)
        {
            homeForm.formState.settingsForm = this;
            this.Hide();
            homeForm.Show();
        }

        private void openDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = this.folderBrowserDialog1;
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                String folderName = folderBrowserDialog1.SelectedPath;
                this.path.Text = folderName;
                this.folderPath = folderName;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
           // homeForm.formState.monthlyExpenseForm.Close();
            homeForm.formState.monthlyExpenseForm = new MontlyExpenses(homeForm);
            try
            {
                File.WriteAllText(txtFilePath, this.folderPath);
                System.Windows.Forms.MessageBox.Show("Your data is saved.");
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("There was an error while saving your data.");
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
