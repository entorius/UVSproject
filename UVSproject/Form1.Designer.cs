namespace UVSproject
{
    partial class Form1
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
            this.Button_ServerRequests = new System.Windows.Forms.Button();
            this.Button_BuyItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_ServerRequests
            // 
            this.Button_ServerRequests.Location = new System.Drawing.Point(174, 187);
            this.Button_ServerRequests.Name = "Button_ServerRequests";
            this.Button_ServerRequests.Size = new System.Drawing.Size(163, 63);
            this.Button_ServerRequests.TabIndex = 0;
            this.Button_ServerRequests.Text = "Server requests";
            this.Button_ServerRequests.UseVisualStyleBackColor = true;
            this.Button_ServerRequests.Click += new System.EventHandler(this.Button_ServerRequests_Click);
            // 
            // Button_BuyItems
            // 
            this.Button_BuyItems.Location = new System.Drawing.Point(486, 187);
            this.Button_BuyItems.Name = "Button_BuyItems";
            this.Button_BuyItems.Size = new System.Drawing.Size(163, 63);
            this.Button_BuyItems.TabIndex = 1;
            this.Button_BuyItems.Text = "Buy Items";
            this.Button_BuyItems.UseVisualStyleBackColor = true;
            this.Button_BuyItems.Click += new System.EventHandler(this.Button_BuyItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_BuyItems);
            this.Controls.Add(this.Button_ServerRequests);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_ServerRequests;
        private System.Windows.Forms.Button Button_BuyItems;
    }
}

