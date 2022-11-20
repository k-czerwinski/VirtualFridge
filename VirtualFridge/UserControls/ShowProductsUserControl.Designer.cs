namespace VirtualFridge.UserControls
{
    partial class ShowProductsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblProductsInFridge = new System.Windows.Forms.Label();
            this.fridgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.columnHeaderProductName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderExpiryDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderProteinPer100g = new System.Windows.Forms.ColumnHeader();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fridgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductsInFridge
            // 
            this.lblProductsInFridge.AutoSize = true;
            this.lblProductsInFridge.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductsInFridge.Location = new System.Drawing.Point(13, 14);
            this.lblProductsInFridge.Name = "lblProductsInFridge";
            this.lblProductsInFridge.Size = new System.Drawing.Size(171, 28);
            this.lblProductsInFridge.TabIndex = 0;
            this.lblProductsInFridge.Text = "Products in fridge:";
            // 
            // fridgeBindingSource
            // 
            this.fridgeBindingSource.DataSource = typeof(global::VirtualFridge.Model.Fridge);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProductName,
            this.columnHeaderExpiryDate,
            this.columnHeaderProteinPer100g});
            this.listViewProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.Location = new System.Drawing.Point(13, 45);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(354, 384);
            this.listViewProducts.TabIndex = 1;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProductName
            // 
            this.columnHeaderProductName.Text = "Product Name";
            this.columnHeaderProductName.Width = 150;
            // 
            // columnHeaderExpiryDate
            // 
            this.columnHeaderExpiryDate.Text = "ExpiryDate";
            this.columnHeaderExpiryDate.Width = 80;
            // 
            // columnHeaderProteinPer100g
            // 
            this.columnHeaderProteinPer100g.Text = "Protein per 100gram";
            this.columnHeaderProteinPer100g.Width = 120;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveProduct.Location = new System.Drawing.Point(373, 199);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(174, 66);
            this.btnRemoveProduct.TabIndex = 2;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // ShowProductsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.lblProductsInFridge);
            this.Name = "ShowProductsUserControl";
            this.Size = new System.Drawing.Size(550, 450);
            this.Load += new System.EventHandler(this.ShowProductsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fridgeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProductsInFridge;
        private BindingSource fridgeBindingSource;
        private ListView listViewProducts;
        private ColumnHeader columnHeaderProductName;
        private ColumnHeader columnHeaderExpiryDate;
        private ColumnHeader columnHeaderProteinPer100g;
        private Button btnRemoveProduct;
    }
}
