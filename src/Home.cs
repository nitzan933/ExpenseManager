using ExpenseManager.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
{
    public static class FormState
    {
        public static Form monthlyExpenseForm;
        public static Form settingsForm;
    }

    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void monthlyExpenses_Click(object sender, EventArgs e)
        {
            MontlyExpenses form;
            this.Hide();
            if (FormState.monthlyExpenseForm == null)
            {
                form = new MontlyExpenses();
                form.ShowDialog();
            }
            else
            {
                form = (MontlyExpenses)FormState.monthlyExpenseForm;
                form.Show();
            }
            this.Close();
        }
        private void settings_Click(object sender, EventArgs e)
        {
            Settings form;
            this.Hide();
            if (FormState.settingsForm == null)
            {
                form = new Settings();
                form.ShowDialog();
            }
            else
            {
                form = (Settings)FormState.settingsForm;
                form.Show();
            }
            this.Close();
        }
    }
}
