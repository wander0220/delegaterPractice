using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegaterPractice
{
    class Product
    {
        private string name;
        private int price;
        private string namePrice;


        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string NamePrice { get => this.name + "(" + this.price + ")"; }


    }
}
