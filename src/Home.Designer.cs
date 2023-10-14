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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Button();
            this.graphs = new System.Windows.Forms.Button();
            this.monthlyExpenses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(117, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expense Manager";
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.MidnightBlue;
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.ForeColor = System.Drawing.Color.AliceBlue;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings.Location = new System.Drawing.Point(123, 298);
            this.settings.Margin = new System.Windows.Forms.Padding(0);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settings.Size = new System.Drawing.Size(211, 91);
            this.settings.TabIndex = 3;
            this.settings.Text = "settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // graphs
            // 
            this.graphs.BackColor = System.Drawing.Color.MidnightBlue;
            this.graphs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.graphs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.graphs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphs.ForeColor = System.Drawing.Color.AliceBlue;
            this.graphs.Image = ((System.Drawing.Image)(resources.GetObject("graphs.Image")));
            this.graphs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphs.Location = new System.Drawing.Point(123, 204);
            this.graphs.Name = "graphs";
            this.graphs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.graphs.Size = new System.Drawing.Size(211, 95);
            this.graphs.TabIndex = 1;
            this.graphs.Text = "graphs";
            this.graphs.UseVisualStyleBackColor = false;
            // 
            // monthlyExpenses
            // 
            this.monthlyExpenses.BackColor = System.Drawing.Color.MidnightBlue;
            this.monthlyExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.monthlyExpenses.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.monthlyExpenses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyExpenses.ForeColor = System.Drawing.Color.AliceBlue;
            this.monthlyExpenses.Image = ((System.Drawing.Image)(resources.GetObject("monthlyExpenses.Image")));
            this.monthlyExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monthlyExpenses.Location = new System.Drawing.Point(125, 110);
            this.monthlyExpenses.Name = "monthlyExpenses";
            this.monthlyExpenses.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.monthlyExpenses.Size = new System.Drawing.Size(209, 95);
            this.monthlyExpenses.TabIndex = 4;
            this.monthlyExpenses.Text = "Monthly Expenses";
            this.monthlyExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.monthlyExpenses.UseVisualStyleBackColor = false;
            this.monthlyExpenses.Click += new System.EventHandler(this.monthlyExpenses_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(447, 441);
            this.Controls.Add(this.monthlyExpenses);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graphs);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button graphs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button monthlyExpenses;
    }
}

