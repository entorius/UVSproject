using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UVSproject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*var context = new UVS_DatabaseEntities();
            var product = new Product()
            {
                Id = 1,
                ProductName = "Potato",
                Cost = 1.0,
                Amount = 500
            };
            context.Product.Add(product);
            context.SaveChanges();
            Console.WriteLine("has runned");*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
    }
}
