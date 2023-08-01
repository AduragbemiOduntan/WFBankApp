using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using WFbankApp.Models.Models;
using WFBankApp.Core.Implementation;
using WFBankApp.Repository.Data;

namespace WFBankApp
{
    public partial class Form1 : Form
    {
        private BankDbContext _dbContext;
        public Form1(BankDbContext dbContext)
        {
            InitializeComponent();
            this._dbContext = dbContext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Example 1: Execute a SELECT query
                /*            var customers = dbContext.Customers.ToList();
                            foreach (var customer in customers)
                            {
                                listBox1.Items.Add($"{customer.ID}: {customer.Name}");
                            }

                            // Example 2: Execute an INSERT query
                            var newCustomer = new Customer { Name = "New Record" };
                            dbContext.Customers.Add(newCustomer);
                            dbContext.SaveChanges();
                            listBox1.Items.Add($"{newCustomer.ID}: {newCustomer.Name}");

                            // Example 3: Execute an UPDATE query
                            var customerToUpdate = dbContext.Customers.FirstOrDefault(c => c.ID == 1);
                            if (customerToUpdate != null)
                            {
                                customerToUpdate.Name = "Updated Name";
                                dbContext.SaveChanges();
                            }

                            // Example 4: Execute a DELETE query
                            var customerToDelete = dbContext.Customers.FirstOrDefault(c => c.ID == 2);
                            if (customerToDelete != null)
                            {
                                dbContext.Customers.Remove(customerToDelete);
                                dbContext.SaveChanges();
                            }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error performing database operations: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                        string text1 = textBox1.Text;
                        string text2 = textBox2.Text;
                        string text3 = textBox3.Text;
                        string text4 = textBox4.Text;
                        string text5 = textBox5.Text;*/
            int lowerRange = 1234567890;
            int upperRange = 2145678910;
            var randomNum = new Random();
            int getAccount = randomNum.Next(lowerRange, upperRange);
            string acctNum = getAccount.ToString();
            MessageBox.Show($"Account Creation Successful.\nYour account number is: {acctNum}");
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            loginPage1.Hide();
            registrationPage1.Show();
            registrationPage1.BringToFront();
            EmailRegLabel.BringToFront();
            EmailRegLabel.Show();
            RegEmailBox.BringToFront();
            RegEmailBox.Show();
            PasswordRegLabel.BringToFront();
            PasswordRegLabel.Show();
            RegPasswordBox.BringToFront();
            RegPasswordBox.Show();
            BtnSubmitReg.BringToFront();
            BtnSubmitReg.Show();
            Registration.BringToFront();
            Registration.Show();
        }

        private void BtnSubmitReg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(RegEmailBox.Text) && !string.IsNullOrWhiteSpace(RegPasswordBox.Text))
            {
                User user = new User();
                user.Email = RegEmailBox.Text;
                user.Password = RegPasswordBox.Text;

                AuthenticationService auth = new();
                auth.Register(user);
            }
            else
                MessageBox.Show("Fill empty field");

        }

        private void RegPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}