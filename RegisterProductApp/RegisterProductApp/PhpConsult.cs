using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RegisterProductApp
{
    internal class PhpConsult
    {

        public string Product {  get; set; }

        public decimal Tension { get; set; }

        public decimal Current { get; set; }

        public PhpConsult(string product, decimal tension, decimal current)
        {
            Product = product;
            Tension = tension;
            Current = current;
        }
    }
}
