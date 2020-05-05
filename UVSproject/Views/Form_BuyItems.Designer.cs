namespace UVSproject.Views
{
    partial class Form_BuyItems
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
            this.TextBox_ItemsList = new System.Windows.Forms.TextBox();
            this.ComboBox_Products = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Buy = new System.Windows.Forms.Button();
            this.TextBox_DiscountCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_CardNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Check = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_CardId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_ItemsList
            // 
            this.TextBox_ItemsList.Location = new System.Drawing.Point(509, 123);
            this.TextBox_ItemsList.Multiline = true;
            this.TextBox_ItemsList.Name = "TextBox_ItemsList";
            this.TextBox_ItemsList.ReadOnly = true;
            this.TextBox_ItemsList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_ItemsList.Size = new System.Drawing.Size(279, 224);
            this.TextBox_ItemsList.TabIndex = 1;
            // 
            // ComboBox_Products
            // 
            this.ComboBox_Products.FormattingEnabled = true;
            this.ComboBox_Products.Location = new System.Drawing.Point(15, 59);
            this.ComboBox_Products.Name = "ComboBox_Products";
            this.ComboBox_Products.Size = new System.Drawing.Size(223, 24);
            this.ComboBox_Products.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Item";
            // 
            // Button_Buy
            // 
            this.Button_Buy.Location = new System.Drawing.Point(12, 298);
            this.Button_Buy.Name = "Button_Buy";
            this.Button_Buy.Size = new System.Drawing.Size(214, 61);
            this.Button_Buy.TabIndex = 5;
            this.Button_Buy.Text = "Buy";
            this.Button_Buy.UseVisualStyleBackColor = true;
            this.Button_Buy.Click += new System.EventHandler(this.Button_Buy_Click);
            // 
            // TextBox_DiscountCode
            // 
            this.TextBox_DiscountCode.Location = new System.Drawing.Point(15, 240);
            this.TextBox_DiscountCode.Name = "TextBox_DiscountCode";
            this.TextBox_DiscountCode.Size = new System.Drawing.Size(278, 22);
            this.TextBox_DiscountCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Discount code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Amount";
            // 
            // TextBox_Amount
            // 
            this.TextBox_Amount.Location = new System.Drawing.Point(15, 180);
            this.TextBox_Amount.Name = "TextBox_Amount";
            this.TextBox_Amount.Size = new System.Drawing.Size(278, 22);
            this.TextBox_Amount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Card number";
            // 
            // TextBox_CardNumber
            // 
            this.TextBox_CardNumber.Location = new System.Drawing.Point(15, 123);
            this.TextBox_CardNumber.Name = "TextBox_CardNumber";
            this.TextBox_CardNumber.Size = new System.Drawing.Size(278, 22);
            this.TextBox_CardNumber.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Check";
            // 
            // Button_Check
            // 
            this.Button_Check.Location = new System.Drawing.Point(553, 363);
            this.Button_Check.Name = "Button_Check";
            this.Button_Check.Size = new System.Drawing.Size(214, 61);
            this.Button_Check.TabIndex = 13;
            this.Button_Check.Text = "Print Check";
            this.Button_Check.UseVisualStyleBackColor = true;
            this.Button_Check.Click += new System.EventHandler(this.Button_Check_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Card id";
            // 
            // TextBox_CardId
            // 
            this.TextBox_CardId.Location = new System.Drawing.Point(478, 85);
            this.TextBox_CardId.Name = "TextBox_CardId";
            this.TextBox_CardId.Size = new System.Drawing.Size(278, 22);
            this.TextBox_CardId.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Get Check";
            // 
            // Form_BuyItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBox_CardId);
            this.Controls.Add(this.Button_Check);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_CardNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_DiscountCode);
            this.Controls.Add(this.Button_Buy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBox_Products);
            this.Controls.Add(this.TextBox_ItemsList);
            this.Name = "Form_BuyItems";
            this.Text = "Form_BuyItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_ItemsList;
        private System.Windows.Forms.ComboBox ComboBox_Products;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Buy;
        private System.Windows.Forms.TextBox TextBox_DiscountCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_CardNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_Check;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_CardId;
        private System.Windows.Forms.Label label7;
    }
}