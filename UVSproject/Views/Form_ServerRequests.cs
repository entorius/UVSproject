using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UVSproject.Services;

namespace UVSproject.Views
{
    public partial class Form_ServerRequests : Form
    {
        Form form;
        CardServices cardServices = new CardServices();
        DiscountServices discountServices = new DiscountServices();
        ProductServices productServices = new ProductServices();

        List<Product> allProducts = new List<Product>();
        public Form_ServerRequests(Form form)
        {
            allProducts = productServices.GetAllProducts();
            this.form = form;
            InitializeComponent();
            foreach(Product product in allProducts)
            {
                ComboBox_Products.Items.Add(product.ProductName);
            }
        }

        private void Button_AddCard_Click(object sender, EventArgs e)
        {
            string cardId = TextBox_CardNumber.Text;
            
            cardServices.AddCard(cardId);
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Dispose();
        }

        private void Button_AddProduct_Click(object sender, EventArgs e)
        {
            string productName = TextBox_ProductName.Text;
            int productAmount = Int32.Parse(TextBox_ProductAmount.Text);
            double productCost = Double.Parse(TextBox_ProductCost.Text);
            Product addedProduct = productServices.AddProduct(productName, productAmount, productCost);
            allProducts.Add(addedProduct);
            ComboBox_Products.Items.Add(addedProduct.ProductName);
        }

        private void Button_AddDiscount_Click(object sender, EventArgs e)
        {
            int discountsAmount = Int32.Parse(TextBox_DiscountsNumber.Text);
            int productId = ComboBox_Products.SelectedIndex;
            discountServices.GenerateDiscountNumbers(discountsAmount, productId);
        }
    }
}
