using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UVSproject.Views;

namespace UVSproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_ServerRequests_Click(object sender, EventArgs e)
        {
            Form_ServerRequests req = new Form_ServerRequests(this);
            req.Show();
            this.Hide();
        }

        private void Button_BuyItems_Click(object sender, EventArgs e)
        {
            Form_BuyItems buyItems = new Form_BuyItems(this);
            buyItems.Show();
            this.Hide();
        }
    }
}
