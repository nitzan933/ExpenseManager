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
        public Home homeForm;
        public string folderPath { get; set; }
        public MontlyExpenses(Home homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            folderPath = homeForm.formState.settingsForm.folderPath;
        }

        private void MontlyExpenses_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private Boolean tablesave_flag = true;

        private void home_Click(object sender, EventArgs e)
        {
            homeForm.formState.monthlyExpenseForm = this;
            this.Hide();
            homeForm.Show();
        }

        private void ExpensesByMonth_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells["income"].Value = false;
            e.Row.Cells["description"].Value = "";
            e.Row.Cells["category"].Value = "";
            e.Row.Cells["amount"].Value = 0;
            e.Row.Cells["date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
            e.Row.Cells["payments"].Value = 1;
            e.Row.Cells["continual"].Value = false;
            e.Row.Cells["comments"].Value = "";
        }

        private void save_Click(object sender, EventArgs e)
        {
            String month = this.months.Text;
            String fileName = folderPath + "\\" + month + ".csv";
            DataGridView table = this.ExpensesByMonth;
            string[] outputCsv = new string[table.Rows.Count-1];
            try
            {
                for (int i = 0; i < table.Rows.Count-1; i++)
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
            
            String month = this.months.SelectedItem.ToString();
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

        private BindingList<String> lmonths = new BindingList<String>();

        private void MontlyExpenses_Load(object sender, EventArgs e)
        {
            //loading months to combobox
            ComboBox months = this.months;
            DirectoryInfo d = new DirectoryInfo(folderPath); 
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
            String[] categories = { "food", "clothes", "bills" , "leasure"};
            foreach (String val in categories)
            {
                category.Items.Add(val);
            }

        }

        private void ExpensesByMonth_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tablesave_flag = false;
            if (this.ExpensesByMonth.Columns[e.ColumnIndex].Name == "amount" || this.ExpensesByMonth.Columns[e.ColumnIndex].Name == "income") 
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
