using VirtualFridge.UserControls;

namespace VirtualFridge
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void AddControls()
        {
            AddProductUserControl addProductUserControl = new AddProductUserControl();
            addProductUserControl.Dock = DockStyle.Fill;
            pnlMainWindow.Controls.Add(addProductUserControl);

            ShowProductsUserControl showProductsUserControl = new ShowProductsUserControl();
            showProductsUserControl.Dock = DockStyle.Fill;
            pnlMainWindow.Controls.Add(showProductsUserControl);
        }

        private void btnShowFridgeContent_Click(object sender, EventArgs e)
        {
            pnlMainWindow.Controls["ShowProductsUserControl"].Refresh();
            pnlMainWindow.Controls["ShowProductsUserControl"].BringToFront();
        }
        
        private void addProductUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddControls();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            pnlMainWindow.Controls["AddProductUserControl"].Refresh();
            pnlMainWindow.Controls["AddProductUserControl"].BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {

        }
    }
}