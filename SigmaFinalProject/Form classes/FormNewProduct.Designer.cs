
namespace SigmaFinalProject
{
    partial class FormNewProduct
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
            this.radioButton_Meat = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Ordinary = new System.Windows.Forms.RadioButton();
            this.radioButton_Dairy = new System.Windows.Forms.RadioButton();
            this.groupBox_Category = new System.Windows.Forms.GroupBox();
            this.radioButton_SecondClass = new System.Windows.Forms.RadioButton();
            this.radioButton_FisrtClass = new System.Windows.Forms.RadioButton();
            this.radioButton_ExtraClass = new System.Windows.Forms.RadioButton();
            this.groupBox_Kind = new System.Windows.Forms.GroupBox();
            this.radioButton_Chicken = new System.Windows.Forms.RadioButton();
            this.radioButton_Pork = new System.Windows.Forms.RadioButton();
            this.radioButton_Veal = new System.Windows.Forms.RadioButton();
            this.radioButton_Mutton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Price = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Weight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_ExpirationDate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_ProductionDate = new System.Windows.Forms.DateTimePicker();
            this.button_Add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_Category.SuspendLayout();
            this.groupBox_Kind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ExpirationDate)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_Meat
            // 
            this.radioButton_Meat.AutoSize = true;
            this.radioButton_Meat.Location = new System.Drawing.Point(15, 38);
            this.radioButton_Meat.Name = "radioButton_Meat";
            this.radioButton_Meat.Size = new System.Drawing.Size(64, 24);
            this.radioButton_Meat.TabIndex = 0;
            this.radioButton_Meat.TabStop = true;
            this.radioButton_Meat.Text = "Meat";
            this.radioButton_Meat.UseVisualStyleBackColor = true;
            this.radioButton_Meat.CheckedChanged += new System.EventHandler(this.radioButton_Meat_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Ordinary);
            this.groupBox1.Controls.Add(this.radioButton_Dairy);
            this.groupBox1.Controls.Add(this.radioButton_Meat);
            this.groupBox1.Location = new System.Drawing.Point(177, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_Ordinary
            // 
            this.radioButton_Ordinary.AutoSize = true;
            this.radioButton_Ordinary.Location = new System.Drawing.Point(268, 38);
            this.radioButton_Ordinary.Name = "radioButton_Ordinary";
            this.radioButton_Ordinary.Size = new System.Drawing.Size(87, 24);
            this.radioButton_Ordinary.TabIndex = 2;
            this.radioButton_Ordinary.TabStop = true;
            this.radioButton_Ordinary.Text = "Ordinary";
            this.radioButton_Ordinary.UseVisualStyleBackColor = true;
            this.radioButton_Ordinary.CheckedChanged += new System.EventHandler(this.radioButton_Ordinary_CheckedChanged);
            // 
            // radioButton_Dairy
            // 
            this.radioButton_Dairy.AutoSize = true;
            this.radioButton_Dairy.Location = new System.Drawing.Point(141, 38);
            this.radioButton_Dairy.Name = "radioButton_Dairy";
            this.radioButton_Dairy.Size = new System.Drawing.Size(65, 24);
            this.radioButton_Dairy.TabIndex = 1;
            this.radioButton_Dairy.TabStop = true;
            this.radioButton_Dairy.Text = "Dairy";
            this.radioButton_Dairy.UseVisualStyleBackColor = true;
            this.radioButton_Dairy.CheckedChanged += new System.EventHandler(this.radioButton_Dairy_CheckedChanged);
            // 
            // groupBox_Category
            // 
            this.groupBox_Category.Controls.Add(this.radioButton_SecondClass);
            this.groupBox_Category.Controls.Add(this.radioButton_FisrtClass);
            this.groupBox_Category.Controls.Add(this.radioButton_ExtraClass);
            this.groupBox_Category.Enabled = false;
            this.groupBox_Category.Location = new System.Drawing.Point(33, 121);
            this.groupBox_Category.Name = "groupBox_Category";
            this.groupBox_Category.Size = new System.Drawing.Size(154, 152);
            this.groupBox_Category.TabIndex = 2;
            this.groupBox_Category.TabStop = false;
            this.groupBox_Category.Text = "Category";
            // 
            // radioButton_SecondClass
            // 
            this.radioButton_SecondClass.AutoSize = true;
            this.radioButton_SecondClass.Location = new System.Drawing.Point(15, 113);
            this.radioButton_SecondClass.Name = "radioButton_SecondClass";
            this.radioButton_SecondClass.Size = new System.Drawing.Size(116, 24);
            this.radioButton_SecondClass.TabIndex = 2;
            this.radioButton_SecondClass.TabStop = true;
            this.radioButton_SecondClass.Text = "Second Class";
            this.radioButton_SecondClass.UseVisualStyleBackColor = true;
            // 
            // radioButton_FisrtClass
            // 
            this.radioButton_FisrtClass.AutoSize = true;
            this.radioButton_FisrtClass.Location = new System.Drawing.Point(15, 70);
            this.radioButton_FisrtClass.Name = "radioButton_FisrtClass";
            this.radioButton_FisrtClass.Size = new System.Drawing.Size(94, 24);
            this.radioButton_FisrtClass.TabIndex = 1;
            this.radioButton_FisrtClass.TabStop = true;
            this.radioButton_FisrtClass.Text = "Fisrt Class";
            this.radioButton_FisrtClass.UseVisualStyleBackColor = true;
            // 
            // radioButton_ExtraClass
            // 
            this.radioButton_ExtraClass.AutoSize = true;
            this.radioButton_ExtraClass.Location = new System.Drawing.Point(15, 26);
            this.radioButton_ExtraClass.Name = "radioButton_ExtraClass";
            this.radioButton_ExtraClass.Size = new System.Drawing.Size(100, 24);
            this.radioButton_ExtraClass.TabIndex = 0;
            this.radioButton_ExtraClass.TabStop = true;
            this.radioButton_ExtraClass.Text = "Extra Class";
            this.radioButton_ExtraClass.UseVisualStyleBackColor = true;
            // 
            // groupBox_Kind
            // 
            this.groupBox_Kind.Controls.Add(this.radioButton_Chicken);
            this.groupBox_Kind.Controls.Add(this.radioButton_Pork);
            this.groupBox_Kind.Controls.Add(this.radioButton_Veal);
            this.groupBox_Kind.Controls.Add(this.radioButton_Mutton);
            this.groupBox_Kind.Enabled = false;
            this.groupBox_Kind.Location = new System.Drawing.Point(219, 121);
            this.groupBox_Kind.Name = "groupBox_Kind";
            this.groupBox_Kind.Size = new System.Drawing.Size(154, 152);
            this.groupBox_Kind.TabIndex = 3;
            this.groupBox_Kind.TabStop = false;
            this.groupBox_Kind.Text = "Kind";
            // 
            // radioButton_Chicken
            // 
            this.radioButton_Chicken.AutoSize = true;
            this.radioButton_Chicken.Location = new System.Drawing.Point(17, 113);
            this.radioButton_Chicken.Name = "radioButton_Chicken";
            this.radioButton_Chicken.Size = new System.Drawing.Size(81, 24);
            this.radioButton_Chicken.TabIndex = 4;
            this.radioButton_Chicken.TabStop = true;
            this.radioButton_Chicken.Text = "Chicken";
            this.radioButton_Chicken.UseVisualStyleBackColor = true;
            // 
            // radioButton_Pork
            // 
            this.radioButton_Pork.AutoSize = true;
            this.radioButton_Pork.Location = new System.Drawing.Point(17, 83);
            this.radioButton_Pork.Name = "radioButton_Pork";
            this.radioButton_Pork.Size = new System.Drawing.Size(58, 24);
            this.radioButton_Pork.TabIndex = 2;
            this.radioButton_Pork.TabStop = true;
            this.radioButton_Pork.Text = "Pork";
            this.radioButton_Pork.UseVisualStyleBackColor = true;
            // 
            // radioButton_Veal
            // 
            this.radioButton_Veal.AutoSize = true;
            this.radioButton_Veal.Location = new System.Drawing.Point(17, 53);
            this.radioButton_Veal.Name = "radioButton_Veal";
            this.radioButton_Veal.Size = new System.Drawing.Size(58, 24);
            this.radioButton_Veal.TabIndex = 1;
            this.radioButton_Veal.TabStop = true;
            this.radioButton_Veal.Text = "Veal";
            this.radioButton_Veal.UseVisualStyleBackColor = true;
            // 
            // radioButton_Mutton
            // 
            this.radioButton_Mutton.AutoSize = true;
            this.radioButton_Mutton.Location = new System.Drawing.Point(17, 23);
            this.radioButton_Mutton.Name = "radioButton_Mutton";
            this.radioButton_Mutton.Size = new System.Drawing.Size(78, 24);
            this.radioButton_Mutton.TabIndex = 0;
            this.radioButton_Mutton.TabStop = true;
            this.radioButton_Mutton.Text = "Mutton";
            this.radioButton_Mutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(390, 144);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(125, 27);
            this.textBox_Name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // numericUpDown_Price
            // 
            this.numericUpDown_Price.Location = new System.Drawing.Point(390, 208);
            this.numericUpDown_Price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Price.Name = "numericUpDown_Price";
            this.numericUpDown_Price.Size = new System.Drawing.Size(81, 27);
            this.numericUpDown_Price.TabIndex = 7;
            this.numericUpDown_Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_Weight
            // 
            this.numericUpDown_Weight.Location = new System.Drawing.Point(493, 208);
            this.numericUpDown_Weight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Weight.Name = "numericUpDown_Weight";
            this.numericUpDown_Weight.Size = new System.Drawing.Size(81, 27);
            this.numericUpDown_Weight.TabIndex = 9;
            this.numericUpDown_Weight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Weight";
            // 
            // numericUpDown_ExpirationDate
            // 
            this.numericUpDown_ExpirationDate.Location = new System.Drawing.Point(609, 208);
            this.numericUpDown_ExpirationDate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_ExpirationDate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ExpirationDate.Name = "numericUpDown_ExpirationDate";
            this.numericUpDown_ExpirationDate.Size = new System.Drawing.Size(81, 27);
            this.numericUpDown_ExpirationDate.TabIndex = 11;
            this.numericUpDown_ExpirationDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Expiration date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Production date";
            // 
            // dateTimePicker_ProductionDate
            // 
            this.dateTimePicker_ProductionDate.Location = new System.Drawing.Point(555, 142);
            this.dateTimePicker_ProductionDate.Name = "dateTimePicker_ProductionDate";
            this.dateTimePicker_ProductionDate.Size = new System.Drawing.Size(209, 27);
            this.dateTimePicker_ProductionDate.TabIndex = 14;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(617, 26);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(132, 48);
            this.button_Add.TabIndex = 15;
            this.button_Add.Text = "Add product";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // FormNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 295);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dateTimePicker_ProductionDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_ExpirationDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_Weight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_Kind);
            this.Controls.Add(this.groupBox_Category);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Category.ResumeLayout(false);
            this.groupBox_Category.PerformLayout();
            this.groupBox_Kind.ResumeLayout(false);
            this.groupBox_Kind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ExpirationDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Meat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Ordinary;
        private System.Windows.Forms.RadioButton radioButton_Dairy;
        private System.Windows.Forms.GroupBox groupBox_Category;
        private System.Windows.Forms.RadioButton radioButton_SecondClass;
        private System.Windows.Forms.RadioButton radioButton_FisrtClass;
        private System.Windows.Forms.RadioButton radioButton_ExtraClass;
        private System.Windows.Forms.GroupBox groupBox_Kind;
        private System.Windows.Forms.RadioButton radioButton_Veal;
        private System.Windows.Forms.RadioButton radioButton_Mutton;
        private System.Windows.Forms.RadioButton radioButton_Chicken;
        private System.Windows.Forms.RadioButton radioButton_Pork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Price;
        private System.Windows.Forms.NumericUpDown numericUpDown_Weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_ExpirationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ProductionDate;
        private System.Windows.Forms.Button button_Add;
    }
}