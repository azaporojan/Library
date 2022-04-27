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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginTextBox.Text.Equals("admin") && passwordTextBox.Text.Equals("password_1234"))
            {
                this.Dispose();
                this.Close();
                SummaryForm summaryForm = new SummaryForm();
                summaryForm.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Incorrect password or login");
                loginButton.BackColor = Color.Red;
            }
        }
    }
}
