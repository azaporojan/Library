using Library.database;
using Library.helpers;
using Library.LibDataSourceTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class SummaryForm : Form
    {
        ElementsCreator<Form> creator;
        public SummaryForm()
        {
            InitializeComponent();
            creator = new ElementsCreator<Form>(this);
        }

        private void displayTop3MostSaledBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            creator.createPanels(DatabaseManager.readTop3MostSaledBooks("DESC"));
            creator.displayBooks();
            label1.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void todayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            creator.removeBooks();
            label1.Visible = true;
            label1.Text = "Income Today: ";
            DateTime today = DateTime.Now;
            DateTime tomorrow = new DateTime(today.Year, today.Month, today.Day + 1);
            label1.Text += DatabaseManager.getIncomeForTime(today, tomorrow);

            creator.removeBooks();
        }

        private void displayTop3LessIssuedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creator.createPanels(DatabaseManager.readTop3MostSaledBooks("ASC"));
            creator.displayBooks();
            label1.Visible = false;
        }

        private void averageIncomePerMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thisMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            reportViewer1.Visible = false;
            creator.removeBooks();
            label1.Text = "Income this month: ";
            DateTime today = DateTime.Now;
            DateTime tomorrow = new DateTime(today.Year, today.Month, today.Day + 1);
            DateTime monthAgo = new DateTime(today.Year, today.Month - 1, today.Day);
            label1.Text += DatabaseManager.getIncomeForTime(monthAgo, tomorrow);
            creator.removeBooks();
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            reportViewer1.Visible = false;
            creator.removeBooks();
            label1.Text = "Income this year: ";
            DateTime today = DateTime.Now;
            DateTime tomorrow = new DateTime(today.Year, today.Month, today.Day + 1);
            DateTime yearAgo = new DateTime(today.Year - 1, today.Month, today.Day);
            label1.Text += DatabaseManager.getIncomeForTime(yearAgo, tomorrow);
            creator.removeBooks();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libDataSource.Subcription' table. You can move, or remove it, as needed.
            this.subcriptionTableAdapter.Fill(this.libDataSource.Subcription);
            // TODO: This line of code loads data into the 'libDataSource.ReturnJoinBook' table. You can move, or remove it, as needed.
            this.returnJoinBookTableAdapter.Fill(this.libDataSource.ReturnJoinBook);
            // TODO: This line of code loads data into the 'libDataSource.IssueJoinBook' table. You can move, or remove it, as needed.
            this.issueJoinBookTableAdapter.Fill(this.libDataSource.IssueJoinBook);


            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allIssuedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            reportViewer2.Visible = false;
            reportViewer3.Visible = false;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void allReturnedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewer2.Visible = true;
            reportViewer1.Visible = false;
            reportViewer3.Visible = false;
        }

        private void allSubcriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewer2.Visible = false;
            reportViewer1.Visible = false;
            reportViewer3.Visible = true;
        }
    }
}
