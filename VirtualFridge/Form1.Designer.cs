namespace VirtualFridge
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowFridgeContent = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.pnlMainWindow = new System.Windows.Forms.Panel();
            this.addProductUserControl1 = new VirtualFridge.UserControls.AddProductUserControl();
            this.showProductsUserControl1 = new VirtualFridge.UserControls.ShowProductsUserControl();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.pnlMainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnExit);
            this.leftPanel.Controls.Add(this.btnShowFridgeContent);
            this.leftPanel.Controls.Add(this.btnAddProduct);
            this.leftPanel.Controls.Add(this.picBoxLogo);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(250, 450);
            this.leftPanel.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Location = new System.Drawing.Point(0, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 83);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowFridgeContent
            // 
            this.btnShowFridgeContent.BackColor = System.Drawing.Color.White;
            this.btnShowFridgeContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowFridgeContent.Location = new System.Drawing.Point(0, 283);
            this.btnShowFridgeContent.Name = "btnShowFridgeContent";
            this.btnShowFridgeContent.Size = new System.Drawing.Size(250, 83);
            this.btnShowFridgeContent.TabIndex = 2;
            this.btnShowFridgeContent.Text = "Show Products";
            this.btnShowFridgeContent.UseVisualStyleBackColor = false;
            this.btnShowFridgeContent.Click += new System.EventHandler(this.btnShowFridgeContent_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 200);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(250, 83);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.Color.White;
            this.picBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(250, 200);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            this.picBoxLogo.UseWaitCursor = true;
            this.picBoxLogo.Click += new System.EventHandler(this.picBoxLogo_Click);
            // 
            // pnlMainWindow
            // 
            this.pnlMainWindow.BackColor = System.Drawing.Color.White;
            this.pnlMainWindow.Controls.Add(this.addProductUserControl1);
            this.pnlMainWindow.Controls.Add(this.showProductsUserControl1);
            this.pnlMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainWindow.Location = new System.Drawing.Point(250, 0);
            this.pnlMainWindow.Name = "pnlMainWindow";
            this.pnlMainWindow.Size = new System.Drawing.Size(550, 450);
            this.pnlMainWindow.TabIndex = 1;
            // 
            // addProductUserControl1
            // 
            this.addProductUserControl1.AutoSize = true;
            this.addProductUserControl1.BackColor = System.Drawing.Color.White;
            this.addProductUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProductUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addProductUserControl1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.addProductUserControl1.Name = "addProductUserControl1";
            this.addProductUserControl1.Size = new System.Drawing.Size(550, 450);
            this.addProductUserControl1.TabIndex = 0;
            this.addProductUserControl1.Load += new System.EventHandler(this.addProductUserControl1_Load);
            // 
            // showProductsUserControl1
            // 
            this.showProductsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showProductsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.showProductsUserControl1.Name = "showProductsUserControl1";
            this.showProductsUserControl1.Size = new System.Drawing.Size(550, 450);
            this.showProductsUserControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMainWindow);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.pnlMainWindow.ResumeLayout(false);
            this.pnlMainWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel leftPanel;
        private Button btnAddProduct;
        private Button btnExit;
        private Button btnShowFridgeContent;
        private Panel pnlMainWindow;
        private PictureBox picBoxLogo;
        private UserControls.AddProductUserControl addProductUserControl1;
        private UserControls.ShowProductsUserControl showProductsUserControl1;
    }
}