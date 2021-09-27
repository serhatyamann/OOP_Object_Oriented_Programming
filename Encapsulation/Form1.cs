using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.ProdName = "Keyboard";
            prod.ProdDescription = "Wireless Keyboard";
            prod.ProdPrice = 50;
            prod.ProdStock = 0;
        }
    }
}
