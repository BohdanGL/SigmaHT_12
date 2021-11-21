using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SigmaFinalProject
{
    public partial class FormBasket : Form
    {
        public Basket basket;
        FormShop formShop;
        FormOrder formOrder;

        public FormBasket(Basket basket, FormShop formShop)
        {
            InitializeComponent();

            this.basket = basket;
            this.formShop = formShop;

            FillInDataGrid(basket);
        }

        public  void FillInDataGrid(Basket basket)
        {
            dataGridView_Basket.Rows.Clear();

            dataGridView_Basket.AllowUserToAddRows = true;

            for (int i = 0; i < basket.Products.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView_Basket.Rows[0].Clone();
                dataGridView_Basket.Rows.Add(row);

                dataGridView_Basket.Rows[i].Cells[0].Value = basket[i].Name;
                dataGridView_Basket.Rows[i].Cells[1].Value = basket[i].Price;
                dataGridView_Basket.Rows[i].Cells[2].Value = basket[i].Weight;
                dataGridView_Basket.Rows[i].Cells[3].Value = basket[i].ExpirationDate;
                dataGridView_Basket.Rows[i].Cells[4].Value = basket[i].ProductionDate.ToShortDateString();

                if (basket[i].GetType() == typeof(Product) || basket[i].GetType() == typeof(DairyProducts))
                {
                    dataGridView_Basket.Rows[i].Cells[5].Value = " - ";
                    dataGridView_Basket.Rows[i].Cells[6].Value = " - ";
                    continue;
                }

                Meat meat = basket[i] as Meat;

                dataGridView_Basket.Rows[i].Cells[5].Value = meat.MeatCategory;
                dataGridView_Basket.Rows[i].Cells[6].Value = meat.KindOfMeat;
            }

            dataGridView_Basket.AllowUserToAddRows = false;

            textBox_TotalPrice.Text = basket.TotalPrice.ToString() + " grn";
        }

        private void dataGridView_Basket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currIndex = dataGridView_Basket.CurrentCell.RowIndex;

            formShop.shop.Storage.Add(basket[currIndex]);
            formShop.FillInDataGrid(formShop.shop.Storage);

            basket.RemoveItem(basket[currIndex]);

            dataGridView_Basket.Rows.RemoveAt(currIndex);
            textBox_TotalPrice.Text = basket.TotalPrice.ToString() + " grn";
        }

        private void button_CreateOrder_Click(object sender, EventArgs e)
        {
            formOrder = new FormOrder(formShop, this);

            formOrder.Show();
        }
    }
}
