using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SigmaFinalProject
{
    public partial class FormAdministrator : Form
    {
        public FormShop formShop;

        public FormAdministrator(FormShop formShop)
        {
            InitializeComponent();

            this.formShop = formShop;

            FillInDataGrid(formShop.shop.Storage);
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

                if (storage[i].GetType() == typeof(Product) || storage[i].GetType() == typeof(DairyProducts))
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
            int currIndex = dataGridView_Products.CurrentCell.RowIndex;

            formShop.shop.Storage.Remove(formShop.shop.Storage[currIndex]);

            FileWorker fileWorker =  new FileWorker(@"C:\Users\User\source\repos\SigmaFinalProject\SigmaFinalProject\Storage.txt");

            fileWorker.WriteProductsToFile(formShop.shop.Storage);

            dataGridView_Products.Rows.RemoveAt(currIndex);
        }

        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewProduct formNewProduct = new FormNewProduct(formShop, this);
            formNewProduct.Show();
        }
    }
}
