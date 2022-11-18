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
    public partial class AddProductUserControl : UserControl
    {
        public AddProductUserControl()
        {
            InitializeComponent();
            //scalendarExpiryDate.MinDate = DateTime.Now;
            calendarExpiryDate.MaxSelectionCount = 1;
        }

        private void txtBoxProductName_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnAddProduct_Click(object sender, EventArgs e) => AddProduct();


        private void AddProductUserControl_Load(object sender, EventArgs e)
        {

        }
        private void AddProduct()
        {
            if ( !ProductParametersValidator.ValidateProductName(txtBoxProductName.Text))
            {
                MessageBox.Show("Product name cannot be empty", "Adding product");
                ResetTextBoxes();
                return;
            }

            if ( !ProductParametersValidator.ValidateProteinPer100Gram(txtBoxProteinPer100Gram.Text))
            {
                MessageBox.Show("Select protein in range 0-100", "Adding product");
                ResetTextBoxes();
                return;
            }

            if (!ProductParametersValidator.ValidateExpiryDate(calendarExpiryDate.SelectionRange.Start))
            {
                MessageBox.Show("You cannot add product which is out of expiry date", "Adding product");
                ResetTextBoxes();
                return;
            }
            int proteinPer100Gram = Int32.Parse(txtBoxProteinPer100Gram.Text);
            var product = new Product(calendarExpiryDate.SelectionRange.Start.Date,
                txtBoxProductName.Text, proteinPer100Gram);
            Fridge.AddProduct(product);
            ResetTextBoxes();
        }
        private void ResetTextBoxes()
        {
            txtBoxProductName.Text = "";
            txtBoxProteinPer100Gram.Text = "";
            calendarExpiryDate.SetDate(DateTime.Now);
        }
    }
}
