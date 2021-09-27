using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Product
    {
        public string ProdName { get; set; }
        public string ProdDescription { get; set; }
        public int ProdPrice { get; set; }
        private int _prodStock;
        public int ProdStock
        {
            get
            {
                return _prodStock;
            }
            set
            {
                if (value > 0)
                {
                    _prodStock = value;
                    System.Windows.Forms.MessageBox.Show("Product successfully added..!");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("You must enter a bigger number than '0' for stock..!");
                }
            }
        }
    }
}
