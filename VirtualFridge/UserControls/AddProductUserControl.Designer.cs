namespace VirtualFridge.UserControls
{
    partial class AddProductUserControl
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.lblProteinPer100Gram = new System.Windows.Forms.Label();
            this.txtBoxProteinPer100Gram = new System.Windows.Forms.TextBox();
            this.calendarExpiryDate = new System.Windows.Forms.MonthCalendar();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(12, 12);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(138, 28);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product name:";
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxProductName.Location = new System.Drawing.Point(12, 43);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(188, 34);
            this.txtBoxProductName.TabIndex = 1;
            this.txtBoxProductName.TextChanged += new System.EventHandler(this.txtBoxProductName_TextChanged);
            // 
            // lblProteinPer100Gram
            // 
            this.lblProteinPer100Gram.AutoSize = true;
            this.lblProteinPer100Gram.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProteinPer100Gram.Location = new System.Drawing.Point(12, 80);
            this.lblProteinPer100Gram.Name = "lblProteinPer100Gram";
            this.lblProteinPer100Gram.Size = new System.Drawing.Size(202, 28);
            this.lblProteinPer100Gram.TabIndex = 2;
            this.lblProteinPer100Gram.Text = "Protein per 100 gram:";
            // 
            // txtBoxProteinPer100Gram
            // 
            this.txtBoxProteinPer100Gram.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxProteinPer100Gram.Location = new System.Drawing.Point(12, 111);
            this.txtBoxProteinPer100Gram.Name = "txtBoxProteinPer100Gram";
            this.txtBoxProteinPer100Gram.Size = new System.Drawing.Size(188, 34);
            this.txtBoxProteinPer100Gram.TabIndex = 3;
            // 
            // calendarExpiryDate
            // 
            this.calendarExpiryDate.Location = new System.Drawing.Point(12, 195);
            this.calendarExpiryDate.Name = "calendarExpiryDate";
            this.calendarExpiryDate.TabIndex = 4;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpiryDate.Location = new System.Drawing.Point(12, 158);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(170, 28);
            this.lblExpiryDate.TabIndex = 5;
            this.lblExpiryDate.Text = "Select expiry date:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Location = new System.Drawing.Point(12, 369);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(173, 41);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // AddProductUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.calendarExpiryDate);
            this.Controls.Add(this.txtBoxProteinPer100Gram);
            this.Controls.Add(this.lblProteinPer100Gram);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.lblProductName);
            this.Name = "AddProductUserControl";
            this.Size = new System.Drawing.Size(550, 450);
            this.Load += new System.EventHandler(this.AddProductUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProductName;
        private TextBox txtBoxProductName;
        private Label lblProteinPer100Gram;
        private TextBox txtBoxProteinPer100Gram;
        private MonthCalendar calendarExpiryDate;
        private Label lblExpiryDate;
        private Button btnAddProduct;
    }
}
