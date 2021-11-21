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
    public partial class FormSignIn : Form
    {
        public FormShop formShop;

        private string dataFileClients = @"C:\Users\User\source\repos\SigmaFinalProject\SigmaFinalProject\Clients.txt";
        private string dataFileAdmins = @"C:\Users\User\source\repos\SigmaFinalProject\SigmaFinalProject\Administrators.txt";
        private string dataFileModers = @"C:\Users\User\source\repos\SigmaFinalProject\SigmaFinalProject\Moderators.txt";

        public FormSignIn(FormShop formShop)
        {
            InitializeComponent();

            this.formShop = formShop;
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            string username = textBox_UserName.Text;

            string password = textBox_Password.Text;

            Client client;
            Administrator administrator;
            Moderator moderator;

            bool isClientFound, isAdminFound, isModerFound;

            try
            {
                client = FindClient(username, password, out isClientFound);
                administrator = FindAdmin(username, password, out isAdminFound);
                moderator = FindModer(username, password, out isModerFound);

                if (!isClientFound && !isAdminFound && !isModerFound)
                    throw new ArgumentException("No such user in shop");
            }
            catch (ArgumentException argumentException)
            {
                
                MessageBox.Show(argumentException.Message, "Input Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
            if(isAdminFound)
            {
                this.Hide();
                formShop.currAdministrator = administrator;
                formShop.Hide();

                FormAdministrator formAdministrator = new FormAdministrator(formShop);
                formAdministrator.Show();
                return;
            }

            if (isModerFound)
            {
                this.Hide();
                formShop.currModerator = moderator;
                formShop.Hide();

                FormModerator formModerator = new FormModerator(formShop);
                formModerator.Show();
                return;
            }

            formShop.currClient = client;
            this.Hide();
        }

        private Client FindClient(string username, string password, out bool isFound)
        {
            StreamReader streamReader = new StreamReader(dataFileClients);

            string[] clients = streamReader.ReadToEnd().Replace("\r", String.Empty).Split('\n',
                StringSplitOptions.RemoveEmptyEntries);

            List<string> usernames = new List<string>();

            for (int i = 0; i < clients.Length; i++)
            {
                usernames.Add(clients[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
            }

            List<string> passwords = new List<string>();

            for (int i = 0; i < clients.Length; i++)
            {
                passwords.Add(clients[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
            }

            int index = usernames.IndexOf(username);

            if (index == -1)
            {
                isFound = false;
                return null;
            }

            if(passwords[index] != password)
            {
                throw new ArgumentException("Uncorrect password!");
            }

            isFound = true;
            return new Client(username, password);
        }

        private Administrator FindAdmin(string username, string password, out bool isFound)
        {
            StreamReader streamReader = new StreamReader(dataFileAdmins);

            string[] admins = streamReader.ReadToEnd().Replace("\r", String.Empty).Split('\n',
                StringSplitOptions.RemoveEmptyEntries);

            List<string> usernames = new List<string>();

            for (int i = 0; i < admins.Length; i++)
            {
                usernames.Add(admins[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
            }

            List<string> passwords = new List<string>();

            for (int i = 0; i < admins.Length; i++)
            {
                passwords.Add(admins[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
            }

            int index = usernames.IndexOf(username);

            if (index == -1)
            {
                isFound = false;
                return null;
            }

            if (passwords[index] != password)
            {
                throw new ArgumentException("Uncorrect password!");
            }

            isFound = true;
            return new Administrator(username, password);
        }

        private Moderator FindModer(string username, string password, out bool isFound)
        {
            StreamReader streamReader = new StreamReader(dataFileModers);

            string[] moders = streamReader.ReadToEnd().Replace("\r", String.Empty).Split('\n',
                StringSplitOptions.RemoveEmptyEntries);

            List<string> usernames = new List<string>();

            for (int i = 0; i < moders.Length; i++)
            {
                usernames.Add(moders[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
            }

            List<string> passwords = new List<string>();

            for (int i = 0; i < moders.Length; i++)
            {
                passwords.Add(moders[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
            }

            int index = usernames.IndexOf(username);

            if (index == -1)
            {
                isFound = false;
                return null;
            }

            if (passwords[index] != password)
            {
                throw new ArgumentException("Uncorrect password!");
            }

            isFound = true;
            return new Moderator(username, password);
        }
    }
}
