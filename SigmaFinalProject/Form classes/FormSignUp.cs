using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SigmaFinalProject
{
    public partial class FormSignUp : Form
    {
        public FormShop formShop;
        private string dataFile = @"C:\Users\User\source\repos\SigmaFinalProject\SigmaFinalProject\Clients.txt";

        public FormSignUp(FormShop formShop)
        {
            InitializeComponent();

            this.formShop = formShop;
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            string username = textBox_UserName.Text;

            string password = textBox_Password.Text;

            string confirmedPassword = textBox_ConfirmedPassword.Text;

            if(confirmedPassword != password)
            {
                MessageBox.Show("Passwords aren't equal", "Input Data", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client client = new Client(username, password);

            formShop.currClient = client;

            formShop.shop.AddClient(client);

            WriteClientToFile(client);
            this.Hide();
        }

        private void WriteClientToFile(Client client)
        {
            StreamWriter streamWriter = new StreamWriter(dataFile, true);

            streamWriter.WriteLine(client.Login + " " + client.Password);

            streamWriter.Close();
        }
    }
}
