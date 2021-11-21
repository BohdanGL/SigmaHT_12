
namespace SigmaFinalProject
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_SelfPickUp = new System.Windows.Forms.RadioButton();
            this.radioButton_AddressSerive = new System.Windows.Forms.RadioButton();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_TotalPrice = new System.Windows.Forms.TextBox();
            this.textBox_Totalweight = new System.Windows.Forms.TextBox();
            this.button_ConfirmOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(31, 48);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.ReadOnly = true;
            this.textBox_UserName.Size = new System.Drawing.Size(181, 27);
            this.textBox_UserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose type of delivery";
            // 
            // radioButton_SelfPickUp
            // 
            this.radioButton_SelfPickUp.AutoSize = true;
            this.radioButton_SelfPickUp.Location = new System.Drawing.Point(42, 130);
            this.radioButton_SelfPickUp.Name = "radioButton_SelfPickUp";
            this.radioButton_SelfPickUp.Size = new System.Drawing.Size(105, 24);
            this.radioButton_SelfPickUp.TabIndex = 3;
            this.radioButton_SelfPickUp.TabStop = true;
            this.radioButton_SelfPickUp.Text = "Self-pickup";
            this.radioButton_SelfPickUp.UseVisualStyleBackColor = true;
            this.radioButton_SelfPickUp.Click += new System.EventHandler(this.radioButton_SelfPickUp_Click);
            // 
            // radioButton_AddressSerive
            // 
            this.radioButton_AddressSerive.AutoSize = true;
            this.radioButton_AddressSerive.Location = new System.Drawing.Point(42, 160);
            this.radioButton_AddressSerive.Name = "radioButton_AddressSerive";
            this.radioButton_AddressSerive.Size = new System.Drawing.Size(125, 24);
            this.radioButton_AddressSerive.TabIndex = 4;
            this.radioButton_AddressSerive.TabStop = true;
            this.radioButton_AddressSerive.Text = "Address servie";
            this.radioButton_AddressSerive.UseVisualStyleBackColor = true;
            this.radioButton_AddressSerive.Click += new System.EventHandler(this.radioButton_AddressSerive_Click);
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(31, 216);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.ReadOnly = true;
            this.textBox_Address.Size = new System.Drawing.Size(170, 27);
            this.textBox_Address.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total weight:";
            // 
            // textBox_TotalPrice
            // 
            this.textBox_TotalPrice.Location = new System.Drawing.Point(119, 258);
            this.textBox_TotalPrice.Name = "textBox_TotalPrice";
            this.textBox_TotalPrice.ReadOnly = true;
            this.textBox_TotalPrice.Size = new System.Drawing.Size(82, 27);
            this.textBox_TotalPrice.TabIndex = 9;
            // 
            // textBox_Totalweight
            // 
            this.textBox_Totalweight.Location = new System.Drawing.Point(131, 292);
            this.textBox_Totalweight.Name = "textBox_Totalweight";
            this.textBox_Totalweight.ReadOnly = true;
            this.textBox_Totalweight.Size = new System.Drawing.Size(70, 27);
            this.textBox_Totalweight.TabIndex = 10;
            // 
            // button_ConfirmOrder
            // 
            this.button_ConfirmOrder.Location = new System.Drawing.Point(31, 348);
            this.button_ConfirmOrder.Name = "button_ConfirmOrder";
            this.button_ConfirmOrder.Size = new System.Drawing.Size(181, 29);
            this.button_ConfirmOrder.TabIndex = 11;
            this.button_ConfirmOrder.Text = "Cornfirm order";
            this.button_ConfirmOrder.UseVisualStyleBackColor = true;
            this.button_ConfirmOrder.Click += new System.EventHandler(this.button_ConfirmOrder_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 417);
            this.Controls.Add(this.button_ConfirmOrder);
            this.Controls.Add(this.textBox_Totalweight);
            this.Controls.Add(this.textBox_TotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.radioButton_AddressSerive);
            this.Controls.Add(this.radioButton_SelfPickUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label1);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_SelfPickUp;
        private System.Windows.Forms.RadioButton radioButton_AddressSerive;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_TotalPrice;
        private System.Windows.Forms.TextBox textBox_Totalweight;
        private System.Windows.Forms.Button button_ConfirmOrder;
    }
}