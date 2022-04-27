namespace Library
{
    partial class SummaryForm
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
            this.components = new System.ComponentModel.Container();
            this.issueJoinBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnJoinBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subcriptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayTop3MostSaledBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTop3LessIssuedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageIncomePerMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.SubcriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.issueJoinBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnJoinBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcriptionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubcriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayTop3MostSaledBooksToolStripMenuItem,
            this.displayTop3LessIssuedBooksToolStripMenuItem,
            this.averageIncomePerMonthToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(972, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // displayTop3MostSaledBooksToolStripMenuItem
            // 
            this.displayTop3MostSaledBooksToolStripMenuItem.Name = "displayTop3MostSaledBooksToolStripMenuItem";
            this.displayTop3MostSaledBooksToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.displayTop3MostSaledBooksToolStripMenuItem.Text = "Display top 3 most issued books";
            this.displayTop3MostSaledBooksToolStripMenuItem.Click += new System.EventHandler(this.displayTop3MostSaledBooksToolStripMenuItem_Click);
            // 
            // displayTop3LessIssuedBooksToolStripMenuItem
            // 
            this.displayTop3LessIssuedBooksToolStripMenuItem.Name = "displayTop3LessIssuedBooksToolStripMenuItem";
            this.displayTop3LessIssuedBooksToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.displayTop3LessIssuedBooksToolStripMenuItem.Text = "Display top 3 less issued books";
            this.displayTop3LessIssuedBooksToolStripMenuItem.Click += new System.EventHandler(this.displayTop3LessIssuedBooksToolStripMenuItem_Click);
            // 
            // averageIncomePerMonthToolStripMenuItem
            // 
            this.averageIncomePerMonthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todayToolStripMenuItem,
            this.thisMonthToolStripMenuItem,
            this.yearToolStripMenuItem});
            this.averageIncomePerMonthToolStripMenuItem.Name = "averageIncomePerMonthToolStripMenuItem";
            this.averageIncomePerMonthToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.averageIncomePerMonthToolStripMenuItem.Text = "Income";
            this.averageIncomePerMonthToolStripMenuItem.Click += new System.EventHandler(this.averageIncomePerMonthToolStripMenuItem_Click);
            // 
            // todayToolStripMenuItem
            // 
            this.todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            this.todayToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.todayToolStripMenuItem.Text = "Today";
            this.todayToolStripMenuItem.Click += new System.EventHandler(this.todayToolStripMenuItem_Click);
            // 
            // thisMonthToolStripMenuItem
            // 
            this.thisMonthToolStripMenuItem.Name = "thisMonthToolStripMenuItem";
            this.thisMonthToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.thisMonthToolStripMenuItem.Text = "This month";
            this.thisMonthToolStripMenuItem.Click += new System.EventHandler(this.thisMonthToolStripMenuItem_Click);
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.yearToolStripMenuItem.Text = "Year";
            this.yearToolStripMenuItem.Click += new System.EventHandler(this.yearToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income";
            this.label1.Visible = false;
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(972, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SummaryForm";
            this.Text = "Books Summary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issueJoinBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnJoinBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcriptionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubcriptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayTop3MostSaledBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTop3LessIssuedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageIncomePerMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource libDataSetBindingSource;
        private System.Windows.Forms.BindingSource issueJoinBookBindingSource;
        private System.Windows.Forms.BindingSource returnJoinBookBindingSource;
        private System.Windows.Forms.BindingSource SubcriptionBindingSource;
        private System.Windows.Forms.BindingSource subcriptionBindingSource1;
    }
}