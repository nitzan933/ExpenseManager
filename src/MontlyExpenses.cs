using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ExpenseManager.src;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace ExpenseManager
{

    public partial class MontlyExpenses : Form
    {
        private Home homeForm;
        private string folderPath { get; set; }
        private Boolean tablesave_flag = true;
        private Dictionary<String, List<Expense>> lmonths = new Dictionary<String, List<Expense>>();
        private BindingList<String> BLmonths = new BindingList<String>();
        public MontlyExpenses(Home homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            folderPath = homeForm.formState.settingsForm.folderPath;
        }

        private void MontlyExpenses_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tablesave_flag == false)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save your changes?", "ALERT", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
            Environment.Exit(1);
        }

        private void home_Click(object sender, EventArgs e)
        {
            homeForm.formState.monthlyExpenseForm = this;
            this.Hide();
            homeForm.Show();
        }

        private void MontlyExpenses_Load(object sender, EventArgs e)
        {
            //loading months to combobox
            DirectoryInfo d = new DirectoryInfo(folderPath);
            FileInfo[] Files = d.GetFiles("*.csv"); //Getting csv files
            foreach (FileInfo file in Files)
            {
                String month = file.Name.Split('.')[0];
                lmonths.Add(month, new List<Expense>());
                BLmonths.Insert(0, month);
                String fileName = folderPath + "\\" + month + ".csv";
                String data;
                try
                {
                    data = File.ReadAllText(fileName);
                }
                catch
                {
                    return;
                }
                String[] rows = data.Split('\n');

                for (int i = 0; i < rows.Length - 1; i++)
                {
                    String row = rows[i];
                    String[] cells = row.Split(',');
                    Expense expense = new Expense();
                    expense.income = Convert.ToBoolean(cells[0]);
                    expense.description = Convert.ToString(cells[1]);
                    expense.category = Convert.ToString(cells[2]);
                    expense.amount = Convert.ToDouble(cells[3]);
                    expense.date = Convert.ToString(cells[4]);
                    expense.payments = Array.ConvertAll(cells[5].Split(' '), s => Convert.ToInt32(s));
                    expense.continual = Convert.ToBoolean(cells[6]);
                    expense.comments = Convert.ToString(cells[7]);
                    lmonths[month].Add(expense);
                }

            }

            this.months.DataSource = BLmonths;
            if (this.months.Items.Count > 0)
            {
                this.months.SelectedIndex = 0;

            }

            //loading the categoris
            DataGridViewComboBoxColumn category = this.category;
            String[] categories = { "food", "clothes", "bills", "leasure" };
            foreach (String val in categories)
            {
                category.Items.Add(val);
            }

        }

        private void ExpensesByMonth_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells["income"].Value = false;
            e.Row.Cells["description"].Value = "";
            e.Row.Cells["category"].Value = "";
            e.Row.Cells["amount"].Value = 0;
            e.Row.Cells["date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
            e.Row.Cells["payments"].Value = "1 1";
            e.Row.Cells["continual"].Value = false;
            e.Row.Cells["comments"].Value = "";
        }

        

        private void months_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(this.months.Text.Equals("") == false && this.months.Items.Contains(this.months.Text) == false)
            {
                try
                {
                    lmonths.Add(this.months.Text.ToString(), new List<Expense>());
                    BLmonths.Insert(0, this.months.Text.ToString());
                } catch { return; }
                this.months.SelectedIndex = 0;
                this.ExpensesByMonth.Rows.Clear();

                //add continual expenses from prev month
                if (BLmonths.Count > 1) {
                    string month = BLmonths[1];
                    for (int i = 0; i < lmonths[month].Count; i++)
                    {
                        Expense expense = lmonths[month][i];
                        if (expense.continual)
                        {
                            this.ExpensesByMonth.Rows.Add(expense.income, expense.description, expense.category, expense.amount, expense.date, expense.payments[0] + " " + expense.payments[1], true, expense.comments);
                        }
                        if (expense.payments[1] < expense.payments[0])
                        {
                            string payments = expense.payments[0] + " " + (expense.payments[1]+1);
                            this.ExpensesByMonth.Rows.Add(expense.income, expense.description, expense.category, expense.amount, expense.date, payments, false, expense.comments);
                        }
                    }
                }
            }
        }

            private void months_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablesave_flag == false)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save your changes?", "ALERT", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    return;
                }
            }
            
            String month = this.months.Text;
            String fileName = folderPath + "\\" + month + ".csv";
            String data;
            try
            {
                data = File.ReadAllText(fileName);
            }catch
            {
                return;
            }
            DataGridView table = this.ExpensesByMonth;
            String[] rows = data.Split('\n');
            table.Rows.Clear();

            for (int i=0; i< rows.Length-1; i++)
            {
                String row = rows[i];
                String[] cells = row.Split(',');

                try
                {
                    DataGridViewRow rowcur = table.Rows[table.Rows.Add(cells)];
                } catch
                {
                    MessageBox.Show("There was an error while importing your data. Please try again.");
                    return;
                }

            }
            table.Refresh();
            tablesave_flag = true;

            sumAmount();

        }

        

        private void ExpensesByMonth_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tablesave_flag = false;
            if (this.ExpensesByMonth.Columns[e.ColumnIndex].Name == "amount" || this.ExpensesByMonth.Columns[e.ColumnIndex].Name == "income") 
            {
                sumAmount();
            }
            if (this.ExpensesByMonth.Columns[e.ColumnIndex].Name == "payments" )
            {
                this.ExpensesByMonth.Rows[e.RowIndex].Cells[e.ColumnIndex].Value += " 1";
            }
        }

        private void sumAmount()
        {            
            double total = 0;
            foreach (DataGridViewRow row in this.ExpensesByMonth.Rows)
                try
                {
                    int payments = 1;
                    if (row.Cells["payments"].Value != null)
                        payments = Convert.ToInt32(row.Cells["payments"].Value.ToString().Split(' ')[0]);
                    if (Convert.ToBoolean(row.Cells["income"].Value))
                    {
                        total += Convert.ToDouble(row.Cells["amount"].Value)/payments;
                    }
                    else
                    {
                        total -= Convert.ToDouble(row.Cells["amount"].Value)/payments;
                    }
                } catch { }
                
            if (total < 0)
            {
                this.total.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.total.ForeColor = System.Drawing.Color.Green;
            }
            this.total.Text = total.ToString();
        }
        private void save_Click(object sender, EventArgs e)
        {
            String month = this.months.Text;
            String fileName = folderPath + "\\" + month + ".csv";
            DataGridView table = this.ExpensesByMonth;
            string[] outputCsv = new string[table.Rows.Count - 1];
            try
            {
                for (int i = 0; i < table.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        var val = table.Rows[i].Cells[j].Value;
                        outputCsv[i] += val.ToString() + ",";
                    }
                }
                File.WriteAllLines(fileName, outputCsv, Encoding.UTF8);
                System.Windows.Forms.MessageBox.Show("Your data is saved.");
                tablesave_flag = true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("There was an error while saving your data. Please try again.");
                return;
            }
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                Expense expense = new Expense();
                expense.income = Convert.ToBoolean(table.Rows[i].Cells["income"].Value);
                expense.description = table.Rows[i].Cells["description"].Value.ToString();
                expense.category = table.Rows[i].Cells["category"].Value.ToString();
                expense.amount = Convert.ToDouble(table.Rows[i].Cells["amount"].Value);
                expense.date = table.Rows[i].Cells["date"].Value.ToString();
                expense.payments = Array.ConvertAll(table.Rows[i].Cells["payments"].Value.ToString().Split(' '), s => Convert.ToInt32(s));
                expense.continual = Convert.ToBoolean(table.Rows[i].Cells["continual"].Value);
                expense.comments = table.Rows[i].Cells["comments"].Value.ToString();
                lmonths[month].Add(expense);
            }

        }


    }
}
