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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.libDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayTop3MostSaledBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTop3LessIssuedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageIncomePerMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allIssuedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allReturnedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.allSubcriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnJoinBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libDataSource = new Library.LibDataSource();
            this.issueJoinBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issueJoinBookTableAdapter = new Library.LibDataSourceTableAdapters.IssueJoinBookTableAdapter();
            this.returnJoinBookTableAdapter = new Library.LibDataSourceTableAdapters.ReturnJoinBookTableAdapter();
            this.SubcriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subcriptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subcriptionTableAdapter = new Library.LibDataSourceTableAdapters.SubcriptionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnJoinBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueJoinBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubcriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcriptionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayTop3MostSaledBooksToolStripMenuItem,
            this.displayTop3LessIssuedBooksToolStripMenuItem,
            this.averageIncomePerMonthToolStripMenuItem,
            this.reportToolStripMenuItem});
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
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allIssuedBooksToolStripMenuItem,
            this.allReturnedBooksToolStripMenuItem,
            this.allSubcriptionsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // allIssuedBooksToolStripMenuItem
            // 
            this.allIssuedBooksToolStripMenuItem.Name = "allIssuedBooksToolStripMenuItem";
            this.allIssuedBooksToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.allIssuedBooksToolStripMenuItem.Text = "All Issued Books";
            this.allIssuedBooksToolStripMenuItem.Click += new System.EventHandler(this.allIssuedBooksToolStripMenuItem_Click);
            // 
            // allReturnedBooksToolStripMenuItem
            // 
            this.allReturnedBooksToolStripMenuItem.Name = "allReturnedBooksToolStripMenuItem";
            this.allReturnedBooksToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.allReturnedBooksToolStripMenuItem.Text = "All returned Books";
            this.allReturnedBooksToolStripMenuItem.Click += new System.EventHandler(this.allReturnedBooksToolStripMenuItem_Click);
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
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LibDataSet";
            reportDataSource1.Value = this.issueJoinBookBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Library.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(972, 489);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.returnJoinBookBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Library.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 28);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(972, 489);
            this.reportViewer2.TabIndex = 3;
            this.reportViewer2.Visible = false;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.subcriptionBindingSource1;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Library.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 28);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(972, 489);
            this.reportViewer3.TabIndex = 4;
            this.reportViewer3.Visible = false;
            // 
            // allSubcriptionsToolStripMenuItem
            // 
            this.allSubcriptionsToolStripMenuItem.Name = "allSubcriptionsToolStripMenuItem";
            this.allSubcriptionsToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.allSubcriptionsToolStripMenuItem.Text = "All subcriptions";
            this.allSubcriptionsToolStripMenuItem.Click += new System.EventHandler(this.allSubcriptionsToolStripMenuItem_Click);
            // 
            // returnJoinBookBindingSource
            // 
            this.returnJoinBookBindingSource.DataMember = "ReturnJoinBook";
            this.returnJoinBookBindingSource.DataSource = this.libDataSource;
            // 
            // libDataSource
            // 
            this.libDataSource.DataSetName = "LibDataSource";
            this.libDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issueJoinBookBindingSource
            // 
            this.issueJoinBookBindingSource.DataMember = "IssueJoinBook";
            this.issueJoinBookBindingSource.DataSource = this.libDataSource;
            // 
            // issueJoinBookTableAdapter
            // 
            this.issueJoinBookTableAdapter.ClearBeforeFill = true;
            // 
            // returnJoinBookTableAdapter
            // 
            this.returnJoinBookTableAdapter.ClearBeforeFill = true;
            // 
            // SubcriptionBindingSource
            // 
            this.SubcriptionBindingSource.DataMember = "Subcription";
            this.SubcriptionBindingSource.DataSource = this.libDataSource;
            // 
            // subcriptionBindingSource1
            // 
            this.subcriptionBindingSource1.DataMember = "Subcription";
            this.subcriptionBindingSource1.DataSource = this.libDataSource;
            // 
            // subcriptionTableAdapter
            // 
            this.subcriptionTableAdapter.ClearBeforeFill = true;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(972, 517);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SummaryForm";
            this.Text = "Books Summary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnJoinBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueJoinBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubcriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcriptionBindingSource1)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allIssuedBooksToolStripMenuItem;
        private System.Windows.Forms.BindingSource libDataSetBindingSource;
        private LibDataSource libDataSource;
        private System.Windows.Forms.BindingSource issueJoinBookBindingSource;
        private LibDataSourceTableAdapters.IssueJoinBookTableAdapter issueJoinBookTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem allReturnedBooksToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource returnJoinBookBindingSource;
        private LibDataSourceTableAdapters.ReturnJoinBookTableAdapter returnJoinBookTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.ToolStripMenuItem allSubcriptionsToolStripMenuItem;
        private System.Windows.Forms.BindingSource SubcriptionBindingSource;
        private System.Windows.Forms.BindingSource subcriptionBindingSource1;
        private LibDataSourceTableAdapters.SubcriptionTableAdapter subcriptionTableAdapter;
    }
}