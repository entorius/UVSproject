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
    public partial class Form_BuyItems : Form
    {
        Form form;

        CardServices cardServices = new CardServices();
        DiscountServices discountServices = new DiscountServices();
        ProductServices productServices = new ProductServices();
        CardProductServices cardProductServices = new CardProductServices();
        List<Product> allProducts = new List<Product>();
        public Form_BuyItems(Form form)
        {
            allProducts = productServices.GetAllProducts();
            this.form = form;
            InitializeComponent();
            foreach (Product product in allProducts)
            {
                ComboBox_Products.Items.Add(product.ProductName);
            }
        }

        private void Button_Buy_Click(object sender, EventArgs e)
        {
            Product product = allProducts.FindLast(p => p.Id.Equals(ComboBox_Products.SelectedIndex + 1));
            int amount;
            bool amountParsed = Int32.TryParse(TextBox_Amount.Text, out amount);
            if (amountParsed)
            {
                bool productEnough = productServices.IsProductEnough(product, amount);
                bool cardExists = cardServices.IsCardExists(TextBox_CardNumber.Text);
                bool discountExists = true;
                bool discountUsed = false;
                if (TextBox_DiscountCode.Text.Trim(' ').Length > 0)
                {
                    discountExists = discountServices.IsDiscountExists(TextBox_DiscountCode.Text.Trim(' '));
                    discountUsed = true;
                }
                if (productEnough && discountExists && cardExists)
                {
                    string answer = productServices.BuyProduct(product, amount);
                    discountServices.UseCode(TextBox_DiscountCode.Text.Trim(' '));
                    Card currentCard = cardServices.GetCard(TextBox_CardNumber.Text);
                    cardProductServices.BuyProductWithCard(product, currentCard, amount, discountUsed);
                    Console.WriteLine(answer);
                }
                else if (!productEnough)
                {
                    Console.WriteLine("product Not Enough");
                }
                else if (!discountExists)
                {
                    Console.WriteLine("discount does not exist");
                }
            }
            else
            {
                Console.WriteLine("wrong amount entered");
            }
        }

        private void Button_Check_Click(object sender, EventArgs e)
        {
            (int Action, string[] ProductCodes) = cardProductServices.Check(TextBox_CardId.Text);
            Console.WriteLine(Action);
            if(Action == 200)
            {
                TextBox_ItemsList.AppendText("Product codes: ");
                TextBox_ItemsList.AppendText(Environment.NewLine);
                foreach (string productCode in ProductCodes) {
                    TextBox_ItemsList.AppendText(productCode);
                    TextBox_ItemsList.AppendText(Environment.NewLine);
                   
                }
            }

        }
    }
}
