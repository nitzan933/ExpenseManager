namespace ExpenseManager
{
    partial class Home
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
            this.monthlyExpenses = new System.Windows.Forms.Button();
            this.graphs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthlyExpenses
            // 
            this.monthlyExpenses.Location = new System.Drawing.Point(62, 140);
            this.monthlyExpenses.Name = "monthlyExpenses";
            this.monthlyExpenses.Size = new System.Drawing.Size(195, 203);
            this.monthlyExpenses.TabIndex = 0;
            this.monthlyExpenses.Text = "monthly expenses";
            this.monthlyExpenses.UseVisualStyleBackColor = true;
            this.monthlyExpenses.Click += new System.EventHandler(this.monthlyExpenses_Click);
            // 
            // graphs
            // 
            this.graphs.Location = new System.Drawing.Point(372, 140);
            this.graphs.Name = "graphs";
            this.graphs.Size = new System.Drawing.Size(213, 208);
            this.graphs.TabIndex = 1;
            this.graphs.Text = "graphs";
            this.graphs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expense Manager";
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(685, 140);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(213, 208);
            this.settings.TabIndex = 3;
            this.settings.Text = "settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 550);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graphs);
            this.Controls.Add(this.monthlyExpenses);
            this.Name = "home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monthlyExpenses;
        private System.Windows.Forms.Button graphs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button settings;
    }
}

