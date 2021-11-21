using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SigmaFinalProject
{
    public partial class FormNewProduct : Form
    {
        public FormShop formShop;
        public FormAdministrator formAdministrator;

        public FormNewProduct(FormShop formShop, FormAdministrator formAdministrator)
        {
            InitializeComponent();

            this.formShop = formShop;
            this.formAdministrator = formAdministrator;
        }


        private void radioButton_Ordinary_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_Category.Enabled = false;
            groupBox_Kind.Enabled = false;
        }

        private void radioButton_Dairy_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_Category.Enabled = false;
            groupBox_Kind.Enabled = false;
        }

        private void radioButton_Meat_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_Category.Enabled = true;
            groupBox_Kind.Enabled = true;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            FileWorker fileWorker = new FileWorker(@"C:\Users\User\source\repos\SigmaFinalProject\SigmaFinalProject\Storage.txt");

            string name = textBox_Name.Text;

            double price = (double)numericUpDown_Price.Value;

            double weight = (double)numericUpDown_Weight.Value;

            int expirationDate = (int)numericUpDown_ExpirationDate.Value;

            DateTime productionDate = dateTimePicker_ProductionDate.Value;

            if(radioButton_Ordinary.Checked)
            {
                formShop.shop.Storage.Add(new Product(name, price, weight, 
                    expirationDate, productionDate));
                formAdministrator.FillInDataGrid(formShop.shop.Storage);
                fileWorker.WriteProductsToFile(formShop.shop.Storage);
                return;
            }

            if(radioButton_Dairy.Checked)
            {
                formShop.shop.Storage.Add(new DairyProducts(name, price, weight, 
                    expirationDate, productionDate));
                formAdministrator.FillInDataGrid(formShop.shop.Storage);
                fileWorker.WriteProductsToFile(formShop.shop.Storage);
                return;
            }

            if(radioButton_Meat.Checked)
            {
                MeatCategory meatCategory;
                KindOfMeat kindOfMeat;

                if (radioButton_ExtraClass.Checked)
                    meatCategory = MeatCategory.ExtraClass;
                else if (radioButton_FisrtClass.Checked)
                    meatCategory = MeatCategory.FisrtClass;
                else
                    meatCategory = MeatCategory.SecondClass;

                if (radioButton_Mutton.Checked)
                    kindOfMeat = KindOfMeat.Mutton;
                else if (radioButton_Veal.Checked)
                    kindOfMeat = KindOfMeat.Veal;
                else if (radioButton_Pork.Checked)
                    kindOfMeat = KindOfMeat.Pork;
                else
                    kindOfMeat = KindOfMeat.Chicken;

                
                formShop.shop.Storage.Add(new Meat(name, price, weight, expirationDate, productionDate,
                    meatCategory, kindOfMeat));
                formAdministrator.FillInDataGrid(formShop.shop.Storage);
                fileWorker.WriteProductsToFile(formShop.shop.Storage);
                return;
            }
        }
    }
}
