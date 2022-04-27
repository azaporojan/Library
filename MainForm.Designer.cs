namespace Library
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolsPannel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.orderByDateLabel = new System.Windows.Forms.Label();
            this.orderByDateComboBox = new System.Windows.Forms.ComboBox();
            this.orderByPriceLabel = new System.Windows.Forms.Label();
            this.orderByPriceComboBox = new System.Windows.Forms.ComboBox();
            this.searchBookLabel = new System.Windows.Forms.Label();
            this.bookSearchBox = new System.Windows.Forms.TextBox();
            this.mainPannel = new System.Windows.Forms.Panel();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSubcriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolsPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultsToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1075, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.resultsToolStripMenuItem.Text = "Results";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 692);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 23);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(675, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 23);
            this.panel2.TabIndex = 0;
            // 
            // toolsPannel
            // 
            this.toolsPannel.AutoScroll = true;
            this.toolsPannel.BackColor = System.Drawing.Color.LightGray;
            this.toolsPannel.Controls.Add(this.searchButton);
            this.toolsPannel.Controls.Add(this.orderByDateLabel);
            this.toolsPannel.Controls.Add(this.orderByDateComboBox);
            this.toolsPannel.Controls.Add(this.orderByPriceLabel);
            this.toolsPannel.Controls.Add(this.orderByPriceComboBox);
            this.toolsPannel.Controls.Add(this.searchBookLabel);
            this.toolsPannel.Controls.Add(this.bookSearchBox);
            this.toolsPannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolsPannel.Location = new System.Drawing.Point(675, 28);
            this.toolsPannel.Margin = new System.Windows.Forms.Padding(4);
            this.toolsPannel.Name = "toolsPannel";
            this.toolsPannel.Size = new System.Drawing.Size(400, 664);
            this.toolsPannel.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Cyan;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(333, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(45, 38);
            this.searchButton.TabIndex = 6;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // orderByDateLabel
            // 
            this.orderByDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderByDateLabel.AutoSize = true;
            this.orderByDateLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByDateLabel.Location = new System.Drawing.Point(15, 211);
            this.orderByDateLabel.Name = "orderByDateLabel";
            this.orderByDateLabel.Size = new System.Drawing.Size(176, 35);
            this.orderByDateLabel.TabIndex = 5;
            this.orderByDateLabel.Text = "Order by date";
            // 
            // orderByDateComboBox
            // 
            this.orderByDateComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.orderByDateComboBox.DisplayMember = "0";
            this.orderByDateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByDateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByDateComboBox.FormattingEnabled = true;
            this.orderByDateComboBox.Items.AddRange(new object[] {
            "Default",
            "Newest first",
            "Older first"});
            this.orderByDateComboBox.Location = new System.Drawing.Point(223, 207);
            this.orderByDateComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderByDateComboBox.Name = "orderByDateComboBox";
            this.orderByDateComboBox.Size = new System.Drawing.Size(155, 39);
            this.orderByDateComboBox.TabIndex = 4;
            this.orderByDateComboBox.ValueMember = "0";
            // 
            // orderByPriceLabel
            // 
            this.orderByPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderByPriceLabel.AutoSize = true;
            this.orderByPriceLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByPriceLabel.Location = new System.Drawing.Point(15, 148);
            this.orderByPriceLabel.Name = "orderByPriceLabel";
            this.orderByPriceLabel.Size = new System.Drawing.Size(181, 35);
            this.orderByPriceLabel.TabIndex = 3;
            this.orderByPriceLabel.Text = "Order by price";
            // 
            // orderByPriceComboBox
            // 
            this.orderByPriceComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.orderByPriceComboBox.DisplayMember = "0";
            this.orderByPriceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByPriceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByPriceComboBox.FormattingEnabled = true;
            this.orderByPriceComboBox.Items.AddRange(new object[] {
            "Default",
            "Ascending",
            "Descending"});
            this.orderByPriceComboBox.Location = new System.Drawing.Point(223, 144);
            this.orderByPriceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderByPriceComboBox.Name = "orderByPriceComboBox";
            this.orderByPriceComboBox.Size = new System.Drawing.Size(155, 39);
            this.orderByPriceComboBox.TabIndex = 2;
            this.orderByPriceComboBox.ValueMember = "0";
            this.orderByPriceComboBox.SelectedIndexChanged += new System.EventHandler(this.orderByPriceComboBox_SelectedIndexChanged);
            // 
            // searchBookLabel
            // 
            this.searchBookLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBookLabel.AutoSize = true;
            this.searchBookLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBookLabel.Location = new System.Drawing.Point(15, 15);
            this.searchBookLabel.Name = "searchBookLabel";
            this.searchBookLabel.Size = new System.Drawing.Size(158, 35);
            this.searchBookLabel.TabIndex = 1;
            this.searchBookLabel.Text = "Search Book";
            // 
            // bookSearchBox
            // 
            this.bookSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSearchBox.Location = new System.Drawing.Point(21, 50);
            this.bookSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookSearchBox.Name = "bookSearchBox";
            this.bookSearchBox.Size = new System.Drawing.Size(357, 38);
            this.bookSearchBox.TabIndex = 0;
            this.bookSearchBox.TextChanged += new System.EventHandler(this.bookSearch_TextChanged);
            // 
            // mainPannel
            // 
            this.mainPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPannel.AutoScroll = true;
            this.mainPannel.Location = new System.Drawing.Point(0, 28);
            this.mainPannel.Name = "mainPannel";
            this.mainPannel.Size = new System.Drawing.Size(670, 664);
            this.mainPannel.TabIndex = 3;
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookToolStripMenuItem,
            this.newSubcriptionToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // newBookToolStripMenuItem
            // 
            this.newBookToolStripMenuItem.Name = "newBookToolStripMenuItem";
            this.newBookToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newBookToolStripMenuItem.Text = "New Book";
            // 
            // newSubcriptionToolStripMenuItem
            // 
            this.newSubcriptionToolStripMenuItem.Name = "newSubcriptionToolStripMenuItem";
            this.newSubcriptionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newSubcriptionToolStripMenuItem.Text = "New Subcription";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1075, 715);
            this.Controls.Add(this.toolsPannel);
            this.Controls.Add(this.mainPannel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolsPannel.ResumeLayout(false);
            this.toolsPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel toolsPannel;
        private System.Windows.Forms.TextBox bookSearchBox;
        private System.Windows.Forms.Label searchBookLabel;
        private System.Windows.Forms.Label orderByPriceLabel;
        private System.Windows.Forms.ComboBox orderByPriceComboBox;
        private System.Windows.Forms.Label orderByDateLabel;
        private System.Windows.Forms.ComboBox orderByDateComboBox;
        private System.Windows.Forms.Panel mainPannel;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSubcriptionToolStripMenuItem;
    }
}

