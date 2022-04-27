using Library.database;
using Library.dto;
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
    public partial class MainForm : Form
    {
        private ElementsCreator<Panel> creator;
        public MainForm()
        {
            InitializeComponent();
            creator = new ElementsCreator<Panel>(mainPannel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DatabaseManager.testConnection();
            List<Book> books = DatabaseManager.readAllfromBook();
            // MessageBox.Show("First result", books[0].toString());
            creator.createPanels(books);
            creator.displayBooks();
            orderByDateComboBox.SelectedIndex = 0;
            orderByPriceComboBox.SelectedIndex = 0;
           // bookSearchBox.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Text = button.Text == "✓" ? " " : "✓";
        }

        private void bookSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void howToSearchLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on the search box if you want to search by any field." +
                " \nBy default searching is done by the title.\n" +
                "If you chosed more than 1 field - please paste ';' symbol after each field",
                "How to search?");
        }

        private void searchByNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchByAuthorCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchByDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void orderByPriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
           // TextBox bookSearchBox = sender as TextBox;
            int orderByPriceValue = orderByPriceComboBox.SelectedIndex;
            int orderByDateValue = orderByDateComboBox.SelectedIndex;
            List<Book> books;
            String orderBySQL = " Order by ";
            bool flag = false;

            switch (orderByPriceValue)
            {
                case 1:
                    orderBySQL += " price ASC";
                    flag = true;
                    break;

                case 2:
                    orderBySQL += " price DESC";
                    flag = true;
                    break;
            }

            switch (orderByDateValue)
            {
                case 1:
                    orderBySQL += flag ? "," : "";
                    orderBySQL += " year_pub ASC";
                    break;
                case 2:
                    orderBySQL += flag ? "," : "";
                    orderBySQL += " year_pub DESC";
                    break;
            }

            if (orderByDateValue == 0 && orderByPriceValue == 0)
            {
                books = DatabaseManager.readByTitleFromBook(bookSearchBox.Text);
            }
            else
                books = DatabaseManager.readByTitleWithOrderFromBook(bookSearchBox.Text, orderBySQL);

            creator.createPanels(books);
            creator.displayBooks();
        }
    }
}
