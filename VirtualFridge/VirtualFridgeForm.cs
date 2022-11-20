using VirtualFridge.UserControls;

namespace VirtualFridge
{
    public partial class VirtualFridgeForm : Form
    {

        public VirtualFridgeForm()
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

        private void VirtualFridge_Load(object sender, EventArgs e) => AddControls();

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            pnlMainWindow.Controls["AddProductUserControl"].Refresh();
            pnlMainWindow.Controls["AddProductUserControl"].BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
    }
}