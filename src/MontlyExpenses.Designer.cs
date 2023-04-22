using System.Windows.Forms;

namespace ExpenseManager
{
    partial class MontlyExpenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.months = new System.Windows.Forms.ComboBox();
            this.ExpensesByMonth = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continual = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesByMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit your expenses";
            // 
            // months
            // 
            this.months.AllowDrop = true;
            this.months.Cursor = System.Windows.Forms.Cursors.Hand;
            this.months.ForeColor = System.Drawing.SystemColors.WindowText;
            this.months.FormattingEnabled = true;
            this.months.ImeMode = System.Windows.Forms.ImeMode.On;
            this.months.Location = new System.Drawing.Point(16, 11);
            this.months.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.months.Name = "months";
            this.months.Size = new System.Drawing.Size(233, 24);
            this.months.TabIndex = 1;
            this.months.SelectedIndexChanged += new System.EventHandler(this.months_SelectedIndexChanged);
            this.months.SelectionChangeCommitted += new System.EventHandler(this.months_SelectionChangeCommitted);
            // 
            // ExpensesByMonth
            // 
            this.ExpensesByMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpensesByMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.category,
            this.amount,
            this.date,
            this.payments,
            this.continual,
            this.comments});
            this.ExpensesByMonth.Location = new System.Drawing.Point(16, 108);
            this.ExpensesByMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExpensesByMonth.Name = "ExpensesByMonth";
            this.ExpensesByMonth.RowHeadersWidth = 51;
            this.ExpensesByMonth.Size = new System.Drawing.Size(1219, 495);
            this.ExpensesByMonth.TabIndex = 2;
            this.ExpensesByMonth.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpensesByMonth_CellEndEdit);
            this.ExpensesByMonth.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ExpensesByMonth_CellMouseClick);
            this.ExpensesByMonth.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ExpensesByMonth_DefaultValuesNeeded);
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // category
            // 
            this.category.HeaderText = "category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.category.Width = 125;
            // 
            // amount
            // 
            this.amount.HeaderText = "amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // payments
            // 
            this.payments.HeaderText = "payments";
            this.payments.MinimumWidth = 6;
            this.payments.Name = "payments";
            this.payments.Width = 125;
            // 
            // continual
            // 
            this.continual.FalseValue = "";
            this.continual.HeaderText = "continual";
            this.continual.MinimumWidth = 6;
            this.continual.Name = "continual";
            this.continual.Width = 125;
            // 
            // comments
            // 
            this.comments.HeaderText = "comments";
            this.comments.MinimumWidth = 6;
            this.comments.Name = "comments";
            this.comments.Width = 125;
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(1136, 11);
            this.home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(68, 58);
            this.home.TabIndex = 3;
            this.home.Text = "home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(1116, 626);
            this.save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 36);
            this.save.TabIndex = 4;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 642);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(148, 642);
            this.total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 16);
            this.total.TabIndex = 7;
            // 
            // MontlyExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 677);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.home);
            this.Controls.Add(this.ExpensesByMonth);
            this.Controls.Add(this.months);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MontlyExpenses";
            this.Text = "MontlyExpenses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MontlyExpenses_FormClosing);
            this.Load += new System.EventHandler(this.MontlyExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesByMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ExpensesByMonth;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button save;
        private DataGridViewTextBoxColumn description;
        private DataGridViewComboBoxColumn category;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn payments;
        private DataGridViewCheckBoxColumn continual;
        private DataGridViewTextBoxColumn comments;
        private Label label2;
        private Label label3;
        private Label total;
        private ComboBox months;
    }
}