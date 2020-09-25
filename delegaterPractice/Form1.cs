using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegaterPractice
{
    public partial class Form1 : Form
    {
        List<Product> mProductList = new List<Product>();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetProductList();
        }

        private void resetProductList()
        {
            mProductList.Clear();
            mProductList.Add(new Product() { Name = "감자", Price = 500 });
            mProductList.Add(new Product() { Name = "사과", Price = 700 });
            mProductList.Add(new Product() { Name = "고구마", Price = 400 });
            mProductList.Add(new Product() { Name = "배추", Price = 600 });
            mProductList.Add(new Product() { Name = "상추", Price = 300 });


        }
    }
}
