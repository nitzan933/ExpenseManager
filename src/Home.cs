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
    public class FormState
    {
        public MontlyExpenses monthlyExpenseForm {  get; set; }
        public Settings settingsForm {  get; set; }
    }

    public partial class Home : Form
    {
        public FormState formState;
        public Home()
        {
            InitializeComponent();
            formState = new FormState();
            formState.settingsForm = new Settings(this);
            formState.monthlyExpenseForm = new MontlyExpenses(this); 
        }

        private void monthlyExpenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            formState.monthlyExpenseForm.Show();
        }
        private void settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            formState.settingsForm.Show();
        }
    }
}
