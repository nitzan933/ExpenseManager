﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            Form form = FormState.monthlyExpenseStack.Pop();
            FormState.monthlyExpenseStack.Push(this);
            this.Hide();
            form.Show();
        }

        private void ExpensesByMonth_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells["date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
            e.Row.Cells["continual"].Value = false;
            e.Row.Cells["amount"].Value = 0;
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

            //table.SelectAll();
            //try
            //{
            //    File.WriteAllText(fileName, table.GetClipboardContent().GetText(TextDataFormat.CommaSeparatedValue));
            //    System.Windows.Forms.MessageBox.Show("Your data is saved.");
            //} catch
            //{
            //    System.Windows.Forms.MessageBox.Show("There was an error while saving your data. Please try again.");
            //}
            //table.ClearSelection();
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
                System.Windows.Forms.MessageBox.Show("There was an error while importing your data. Please try again.");
                return;
            }
            DataGridView table = this.ExpensesByMonth;
            String[] rows = data.Split('\n');
            table.Rows.Clear();
            for (int i=0; i< rows.Length - 2; i++)
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
                    System.Windows.Forms.MessageBox.Show("There was an error while importing your data. Please try again.");
                    return;
                }
            }
            table.Refresh();
            tablesave_flag = true;


            double total = 0;
            foreach (DataGridViewRow row in table.Rows)
                try { total += Convert.ToDouble(row.Cells["amount"].Value); } catch { }
            this.total.Text = total.ToString();
        }

        private void MontlyExpenses_Load(object sender, EventArgs e)
        {
            ComboBox months = this.months;
            String path = "C:\\Users\\nitzansh\\Downloads\\";
            DirectoryInfo d = new DirectoryInfo(path); 
            FileInfo[] Files = d.GetFiles("*.csv"); //Getting csv files

            string vals = "";

            foreach (FileInfo file in Files)
            {
                vals +=  file.Name.Split('.')[0] + ", ";
            }
            vals = vals.Remove(vals.Length - 2, 1);
            foreach (String val in vals.Split(','))
            {
                months.Items.Add(val);
            }
            months.SelectedIndex = 0;


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

            DataGridView table = this.ExpensesByMonth;
            if (table.Columns[e.ColumnIndex].Name == "amount") //update total amount in every cell's update
            {
                double total = 0;
                foreach (DataGridViewRow row in table.Rows)
                    try { total += Convert.ToDouble(row.Cells["amount"].Value); } catch { }
                this.total.Text = total.ToString();
            }

        }

    }
}