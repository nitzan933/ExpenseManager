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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace ExpenseManager
{

    public partial class MontlyExpenses : Form
    {
        public MontlyExpenses()
        {
            InitializeComponent();
        }

        private void MontlyExpenses_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private Boolean tablesave_flag = true;

        private void home_Click(object sender, EventArgs e)
        {
            Form form = new Home();
            FormState.monthlyExpenseForm = this;
            this.Hide();
            form.ShowDialog();
        }

        private void ExpensesByMonth_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells["income"].Value = false;
            e.Row.Cells["date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
            e.Row.Cells["continual"].Value = false;
            e.Row.Cells["amount"].Value = 0;
            e.Row.Cells["payments"].Value = 1;
        }

        private void save_Click(object sender, EventArgs e)
        {
            String path = "C:\\Users\\nitzansh\\Downloads";
            String month = this.months.Text;
            String fileName = path + "\\" + month + ".csv";
            DataGridView table = this.ExpensesByMonth;

            int columnCount = table.Columns.Count;
            string[] outputCsv = new string[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var val = table.Rows[i].Cells[j].Value;
                    if (val != null)
                    {
                        outputCsv[i] += val.ToString() + ",";
                    }
                    else
                    {
                        outputCsv[i] += ",";
                    }
                }
            }
            try
            {
                File.WriteAllLines(fileName, outputCsv, Encoding.UTF8);
                System.Windows.Forms.MessageBox.Show("Your data is saved.");
                tablesave_flag = true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("There was an error while saving your data. Please try again.");
            }
        }

        private void months_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(this.months.Text.Equals("") == false && this.months.Items.Contains(this.months.Text) == false)
            {
                lmonths.Insert(0, this.months.Text.ToString());
                this.months.SelectedIndex = 0;
                this.ExpensesByMonth.Rows.Clear();
            }
        }

            private void months_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablesave_flag == false)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you don't want to save your changes?", "ALERT", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            
            String path = "C:\\Users\\nitzansh\\Downloads";
            String month = this.months.SelectedItem.ToString();
            String fileName = path + "\\" + month + ".csv";
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
                    if (Convert.ToBoolean(rowcur.Cells["continual"].Value) != true)
                    {
                        rowcur.Cells["continual"].Value = false;
                    }
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

        private BindingList<String> lmonths = new BindingList<String>();

        private void MontlyExpenses_Load(object sender, EventArgs e)
        {
            //loading months to combobox
            ComboBox months = this.months;
            String path = "C:\\Users\\nitzansh\\Downloads\\";
            DirectoryInfo d = new DirectoryInfo(path); 
            FileInfo[] Files = d.GetFiles("*.csv"); //Getting csv files

            foreach (FileInfo file in Files)
            {
                lmonths.Add(file.Name.Split('.')[0]);
            }
            months.DataSource = lmonths;
            if(months.Items.Count > 0)
            {
                months.SelectedIndex = 0;

            }


            //loading the categoris
            DataGridViewComboBoxColumn category = this.category;
            String[] categories = { "food", "clothes", "bills" };
            foreach (String val in categories)
            {
                category.Items.Add(val);
            }

        }

        private void ExpensesByMonth_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
      
        }

        private void ExpensesByMonth_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tablesave_flag = false;
            if (this.ExpensesByMonth.Columns[e.ColumnIndex].Name == "amount") 
            {
                sumAmount();
            }
        }

        private void sumAmount()
        {
            DataGridView table = this.ExpensesByMonth;
            
            double total = 0;
            foreach (DataGridViewRow row in table.Rows)
                try
                {
                    if (Convert.ToBoolean(row.Cells["income"].Value))
                    {
                        total += Convert.ToDouble(row.Cells["amount"].Value);
                    }
                    else
                    {
                        total -= Convert.ToDouble(row.Cells["amount"].Value);
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

    }
}
