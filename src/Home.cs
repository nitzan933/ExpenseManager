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
        public static Stack<Form> monthlyExpenseStack = new Stack<Form>();
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
            if (FormState.monthlyExpenseStack.Count() == 0)
            {
                form = new MontlyExpenses();
            }
            else
            {
                form = (MontlyExpenses)FormState.monthlyExpenseStack.Pop();
            }
            this.Hide();
            FormState.monthlyExpenseStack.Push(this);
            form.Show();
        }
    }
}
