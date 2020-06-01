using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();//dgwProducts'in veri kaynagi olarak productDal'daki GetAll() method'unu gosterildi.
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            { 
                Name=tbxName.Text,
                StockAmount = Convert.ToInt32(tbxstockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxunitPrice.Text)
            });
            LoadProducts();
            MessageBox.Show("Product is added.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                StockAmount = Convert.ToInt32(tbxstockAmountUpdate.Text),
                UnitPrice = Convert.ToDecimal(tbxunitPriceUpdate.Text)
            };
            _productDal.Update(product);
            LoadProducts();//Sonuclari ekrana yansit
            MessageBox.Show("Product is updated.");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Sectigin row'un bilgilerini textbox'lara burada aktariyoruz
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxstockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxunitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Deleted.");
        }
    }
}
