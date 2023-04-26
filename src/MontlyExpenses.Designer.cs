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
            this.home = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.income = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continual = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesByMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 9);
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
            this.months.Margin = new System.Windows.Forms.Padding(4);
            this.months.Name = "months";
            this.months.Size = new System.Drawing.Size(233, 24);
            this.months.TabIndex = 1;
            this.months.SelectedIndexChanged += new System.EventHandler(this.months_SelectedIndexChanged);
            this.months.SelectionChangeCommitted += new System.EventHandler(this.months_SelectionChangeCommitted);
            // 
            // ExpensesByMonth
            // 
            this.ExpensesByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpensesByMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpensesByMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.income,
            this.description,
            this.category,
            this.amount,
            this.date,
            this.payments,
            this.continual,
            this.comments});
            this.ExpensesByMonth.Location = new System.Drawing.Point(13, 77);
            this.ExpensesByMonth.Margin = new System.Windows.Forms.Padding(4);
            this.ExpensesByMonth.Name = "ExpensesByMonth";
            this.ExpensesByMonth.RowHeadersWidth = 51;
            this.ExpensesByMonth.Size = new System.Drawing.Size(1191, 510);
            this.ExpensesByMonth.TabIndex = 2;
            this.ExpensesByMonth.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpensesByMonth_CellEndEdit);
            this.ExpensesByMonth.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ExpensesByMonth_CellMouseClick);
            this.ExpensesByMonth.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ExpensesByMonth_DefaultValuesNeeded);
            // 
            // home
            // 
            this.home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.home.Location = new System.Drawing.Point(1164, 11);
            this.home.Margin = new System.Windows.Forms.Padding(4);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(68, 58);
            this.home.TabIndex = 3;
            this.home.Text = "home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(1165, 595);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(67, 34);
            this.save.TabIndex = 4;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 613);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // total
            // 
            this.total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(110, 613);
            this.total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 16);
            this.total.TabIndex = 7;
            // 
            // income
            // 
            this.income.HeaderText = "income";
            this.income.Name = "income";
            this.income.Width = 70;
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 150;
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
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 90;
            // 
            // payments
            // 
            this.payments.HeaderText = "payments";
            this.payments.MinimumWidth = 6;
            this.payments.Name = "payments";
            this.payments.Width = 80;
            // 
            // continual
            // 
            this.continual.HeaderText = "continual";
            this.continual.Name = "continual";
            // 
            // comments
            // 
            this.comments.HeaderText = "comments";
            this.comments.MinimumWidth = 6;
            this.comments.Name = "comments";
            this.comments.Width = 150;
            // 
            // MontlyExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 642);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save);
            this.Controls.Add(this.home);
            this.Controls.Add(this.ExpensesByMonth);
            this.Controls.Add(this.months);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private Label label3;
        private Label total;
        private ComboBox months;
        private DataGridViewCheckBoxColumn income;
        private DataGridViewTextBoxColumn description;
        private DataGridViewComboBoxColumn category;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn payments;
        private DataGridViewCheckBoxColumn continual;
        private DataGridViewTextBoxColumn comments;
    }
}