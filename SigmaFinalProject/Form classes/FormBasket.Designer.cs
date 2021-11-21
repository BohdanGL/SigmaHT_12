
namespace SigmaFinalProject
{
    partial class FormBasket
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
            this.formShop.formBasket = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Basket = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox_TotalPrice = new System.Windows.Forms.TextBox();
            this.button_CreateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Basket)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Basket
            // 
            this.dataGridView_Basket.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_Basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Basket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView_Basket.Location = new System.Drawing.Point(4, 3);
            this.dataGridView_Basket.Name = "dataGridView_Basket";
            this.dataGridView_Basket.ReadOnly = true;
            this.dataGridView_Basket.RowHeadersVisible = false;
            this.dataGridView_Basket.RowHeadersWidth = 51;
            this.dataGridView_Basket.RowTemplate.Height = 29;
            this.dataGridView_Basket.Size = new System.Drawing.Size(1004, 369);
            this.dataGridView_Basket.TabIndex = 1;
            this.dataGridView_Basket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Basket_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Weight";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Expiration date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Production date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Category";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Kind";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Edit";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Text = "Remove";
            this.Column8.UseColumnTextForButtonValue = true;
            this.Column8.Width = 125;
            // 
            // textBox_TotalPrice
            // 
            this.textBox_TotalPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_TotalPrice.Location = new System.Drawing.Point(672, 407);
            this.textBox_TotalPrice.Multiline = true;
            this.textBox_TotalPrice.Name = "textBox_TotalPrice";
            this.textBox_TotalPrice.ReadOnly = true;
            this.textBox_TotalPrice.Size = new System.Drawing.Size(171, 56);
            this.textBox_TotalPrice.TabIndex = 2;
            this.textBox_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_CreateOrder
            // 
            this.button_CreateOrder.Location = new System.Drawing.Point(876, 407);
            this.button_CreateOrder.Name = "button_CreateOrder";
            this.button_CreateOrder.Size = new System.Drawing.Size(126, 56);
            this.button_CreateOrder.TabIndex = 3;
            this.button_CreateOrder.Text = "Create order";
            this.button_CreateOrder.UseVisualStyleBackColor = true;
            this.button_CreateOrder.Click += new System.EventHandler(this.button_CreateOrder_Click);
            // 
            // FormBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 498);
            this.Controls.Add(this.button_CreateOrder);
            this.Controls.Add(this.textBox_TotalPrice);
            this.Controls.Add(this.dataGridView_Basket);
            this.Name = "FormBasket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.TextBox textBox_TotalPrice;
        private System.Windows.Forms.Button button_CreateOrder;
    }
}