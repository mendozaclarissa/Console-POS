using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace console_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayMenu();

            Console.ReadKey();
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("    Welcome to the POS System  ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("[1] Add Item");
            Console.WriteLine("[2] Remove Item");
            Console.WriteLine("[3] View Cart");
            Console.WriteLine("[4] Checkout");
            Console.WriteLine("[5] Exit");
            Console.WriteLine("==============================");
            Console.Write("Please select an option: ");
        }
    }

}