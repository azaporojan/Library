using Library.database;
using Library.helpers;
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
            creator.createPanels(DatabaseManager.readTop3MostSaledBooks("DESC"));
            creator.displayBooks();
            label1.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void todayToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
