using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SigmaFinalProject
{
    public partial class FormModerator : Form
    {
        public FormShop formShop;
        private List<Order> orders;

        public FormModerator(FormShop formShop)
        {
            InitializeComponent();

            this.formShop = formShop;

            orders = FormOrder.ReadOrdersFromFile();

            FillInDataGrid(orders);
        }

        public void FillInDataGrid(List<Order> orders)
        {
            dataGridView_Orders.Rows.Clear();
            dataGridView_Orders.AllowUserToAddRows = true;

            for (int i = 0; i < orders.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView_Orders.Rows[0].Clone();
                dataGridView_Orders.Rows.Add();

                dataGridView_Orders.Rows[i].Cells[0].Value = orders[i].Username;
                dataGridView_Orders.Rows[i].Cells[1].Value = orders[i].TotalPrice;
                dataGridView_Orders.Rows[i].Cells[2].Value = orders[i].TotalWeight;

                dataGridView_Orders.Rows[i].Cells[3].Value = orders[i].Address;
                if (orders[i].Address == String.Empty)
                    dataGridView_Orders.Rows[i].Cells[3].Value = "Self pickup";

                dataGridView_Orders.Rows[i].Cells[4].Value = orders[i].OrderCreationTime.ToShortDateString();
            }

            dataGridView_Orders.AllowUserToAddRows = false;
        }

        private void dataGridView_Orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currIndex = dataGridView_Orders.CurrentCell.RowIndex;

            orders.RemoveAt(currIndex);

            FileWorker.WriteOrdersToFile(orders, FormOrder.ordersFile);

            dataGridView_Orders.Rows.RemoveAt(currIndex);
        }
    }
}
