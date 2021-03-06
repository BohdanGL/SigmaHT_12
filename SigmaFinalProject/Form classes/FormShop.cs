using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigmaFinalProject
{
    public partial class FormShop : Form
    {
        public Shop shop;
        public Client currClient;
        public Administrator currAdministrator;
        public Moderator currModerator;

        public FormBasket formBasket;
        public FormSignIn formSignIn;
        public FormSignUp formSignUp;

        public FormShop()
        {
            InitializeComponent();

            shop = Shop.GetInstance();

            FileWorker fileWorker = new FileWorker(@"C:\Users\User\source\repos\SigmaFinalProject\SigmaFinalProject\Storage.txt");

            shop.Storage = fileWorker.GetProducts();

            FillInDataGrid(shop.Storage);
        }

        public void FillInDataGrid(Storage storage)
        {
            dataGridView_Products.Rows.Clear();
            dataGridView_Products.AllowUserToAddRows = true;

            for (int i = 0; i < storage.Products.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView_Products.Rows[0].Clone();
                dataGridView_Products.Rows.Add();

                dataGridView_Products.Rows[i].Cells[0].Value = storage[i].Name;
                dataGridView_Products.Rows[i].Cells[1].Value = storage[i].Price;
                dataGridView_Products.Rows[i].Cells[2].Value = storage[i].Weight;
                dataGridView_Products.Rows[i].Cells[3].Value = storage[i].ExpirationDate;
                dataGridView_Products.Rows[i].Cells[4].Value = storage[i].ProductionDate.ToShortDateString();

                if(storage[i].GetType() == typeof(Product) || storage[i].GetType() == typeof(DairyProducts))
                {
                    dataGridView_Products.Rows[i].Cells[5].Value = " - ";
                    dataGridView_Products.Rows[i].Cells[6].Value = " - ";
                    continue;
                }

                Meat meat = storage[i] as Meat;

                dataGridView_Products.Rows[i].Cells[5].Value = meat.MeatCategory;
                dataGridView_Products.Rows[i].Cells[6].Value = meat.KindOfMeat;
            }

            dataGridView_Products.AllowUserToAddRows = false;
        }

        private void dataGridView_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currClient == null)
            {
                MessageBox.Show("You have to sign in or sing up if you don't have account", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (formBasket == null)
                formBasket = new FormBasket(currClient.Basket, this);

            int currIndex = dataGridView_Products.CurrentCell.RowIndex;

            currClient.Basket.AddItem(shop.Storage[currIndex]);
            formBasket.FillInDataGrid(formBasket.basket);

            shop.Storage.Products.RemoveAt(currIndex);
            
            dataGridView_Products.Rows.RemoveAt(currIndex);
        }

        private void openBasketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(currClient == null)
            {
                MessageBox.Show("You have to sign in or sing up if you don't have account", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (formBasket == null)
                formBasket = new FormBasket(currClient.Basket, this);

            formBasket.Show();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formSignIn == null)
                formSignIn = new FormSignIn(this);

            formSignIn.Show();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formSignUp == null)
                formSignUp = new FormSignUp(this);

            formSignUp.Show();
        }
    }
}
