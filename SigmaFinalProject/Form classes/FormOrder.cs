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
    public partial class FormOrder : Form
    {
        FormShop formShop;
        FormBasket formBasket;
        Order order;

        public static string ordersFile = @"C:\Users\User\source\repos\SigmaFinalProject\SigmaFinalProject\Orders.txt";

        public FormOrder(FormShop formShop, FormBasket formBasket)
        {
            InitializeComponent();
            this.formShop = formShop;
            this.formBasket = formBasket;

            string username = formShop.currClient.Login;
            double totalPrice = formShop.currClient.Basket.TotalPrice;
            double totalWeight = formShop.currClient.Basket.TotalWeight;

            textBox_UserName.Text = username;

            textBox_TotalPrice.Text = totalPrice.ToString() + " grn";

            textBox_Totalweight.Text = totalWeight.ToString() + " grm";

        }

        private void button_ConfirmOrder_Click(object sender, EventArgs e)
        {
            order = new Order(formShop.currClient.Login, textBox_Address.Text,
                formShop.currClient.Basket.TotalPrice, 
                formShop.currClient.Basket.TotalWeight, DateTime.Now);

            WriteOrderToFile(order);

            for (int i = 0; i < formShop.currClient.Basket.Products.Count; i++)
            {
                formShop.currClient.Basket.RemoveItem(formShop.currClient.Basket.Products[i]);
                i--;
            }

            formBasket.FillInDataGrid(formBasket.basket);

            this.Hide();
        }

        private void radioButton_AddressSerive_Click(object sender, EventArgs e)
        {
            textBox_Address.ReadOnly = false;
        }

        private void radioButton_SelfPickUp_Click(object sender, EventArgs e)
        {
            textBox_Address.ReadOnly = true;
        }

        private void WriteOrderToFile(Order order)
        {
            StreamWriter streamWriter = new StreamWriter(ordersFile, true);

            streamWriter.Write($"{order.Username} {order.TotalPrice} {order.TotalWeight}");
            streamWriter.Write($" {order.Address} {order.OrderCreationTime.ToShortDateString()}\n");

            streamWriter.Close();
        }

        public static List<Order> ReadOrdersFromFile()
        {
            StreamReader streamReader = new StreamReader(ordersFile);

            string[] orders = streamReader.ReadToEnd().Replace("\r\n", "\n").Split('\n',
                StringSplitOptions.RemoveEmptyEntries);

            List<Order> ordersList = new List<Order>();

            for (int i = 0; i < orders.Length; i++)
            {
                string[] orderValues = orders[i].Split(' ');

                string username = orderValues[0];

                double totalPrice = double.Parse(orderValues[1]);

                double totalWeight = double.Parse(orderValues[2]);

                string address = orderValues[3];

                string[] dateTime = orderValues[4].Split('.');

                int day = int.Parse(dateTime[0]);

                int month = int.Parse(dateTime[1]);

                int year = int.Parse(dateTime[2]);

                ordersList.Add(new Order(username, address, totalPrice,
                    totalWeight, new DateTime(year, month, day)));
            }

            streamReader.Close();

            return ordersList;
        }
    }
}
