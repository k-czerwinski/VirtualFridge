using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualFridge.Model;

namespace VirtualFridge.UserControls
{
    public partial class ShowProductsUserControl : UserControl
    {
        public ShowProductsUserControl()
        {
            InitializeComponent();
        }

        private void listBoxProductList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowProductsUserControl_Load(object sender, EventArgs e)
        {
            UpdateProductListView();
        }

        public override void Refresh() => UpdateProductListView();

        public void UpdateProductListView()
        {
            listViewProducts.Items.Clear();
            foreach (Product product in Fridge.Products )
            {
                string[] row = new string[] {product.ProductName,
                    product.ExpirationDate.ToShortDateString(),product.ProteinPer100Grams.ToString()};
                ListViewItem lvi = new ListViewItem(row);
                listViewProducts.Items.Add(lvi);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            var numberOfSelectedItems = listViewProducts.SelectedItems.Count;
            if ( numberOfSelectedItems < 1 )
            {
                MessageBox.Show("No item selected","Removing product");
            }
            else if( numberOfSelectedItems > 1 )
            {
                MessageBox.Show("You can remove only one item", "Removing product");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you going to remove product: "
                    + Fridge.Products[numberOfSelectedItems].ProductName,"Removing item", MessageBoxButtons.YesNo);
                if( dialogResult == DialogResult.Yes )
                {
                    Fridge.RemoveProduct(Fridge.Products[numberOfSelectedItems]);
                    UpdateProductListView();
                }
            }

        }
    }
}
