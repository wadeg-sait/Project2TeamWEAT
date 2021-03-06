﻿namespace WEAT_Solutions_Main_Project
{
    partial class frmAddEditProducts
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbProductDetails = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProdName = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.lblProdID = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.productBindingSource2;
            this.dgvProducts.Location = new System.Drawing.Point(17, 16);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProducts.Size = new System.Drawing.Size(634, 273);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_CellMouseDoubleClick);
            // 
            // gbProductDetails
            // 
            this.gbProductDetails.Controls.Add(this.btnReset);
            this.gbProductDetails.Controls.Add(this.txtProdName);
            this.gbProductDetails.Controls.Add(this.btnSave);
            this.gbProductDetails.Controls.Add(this.lblProdName);
            this.gbProductDetails.Controls.Add(this.txtProdID);
            this.gbProductDetails.Controls.Add(this.lblProdID);
            this.gbProductDetails.Location = new System.Drawing.Point(17, 310);
            this.gbProductDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbProductDetails.Name = "gbProductDetails";
            this.gbProductDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gbProductDetails.Size = new System.Drawing.Size(457, 166);
            this.gbProductDetails.TabIndex = 1;
            this.gbProductDetails.TabStop = false;
            this.gbProductDetails.Text = "Update Product Details";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(173, 116);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(129, 68);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(287, 22);
            this.txtProdName.TabIndex = 3;
            this.txtProdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdName_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(317, 116);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(21, 71);
            this.lblProdName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(98, 17);
            this.lblProdName.TabIndex = 2;
            this.lblProdName.Text = "Product Name";
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(129, 27);
            this.txtProdID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.ReadOnly = true;
            this.txtProdID.Size = new System.Drawing.Size(181, 22);
            this.txtProdID.TabIndex = 1;
            this.txtProdID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdID_KeyPress);
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.Location = new System.Drawing.Point(21, 31);
            this.lblProdID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(74, 17);
            this.lblProdID.TabIndex = 0;
            this.lblProdID.Text = "Product ID";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(524, 310);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 28);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(524, 448);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(524, 356);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "E&dit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(524, 402);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataSource = typeof(WEAT_Solutions_Main_Project.Product);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(WEAT_Solutions_Main_Project.Product);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WEAT_Solutions_Main_Project.Product);
            // 
            // frmAddEditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 489);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gbProductDetails);
            this.Controls.Add(this.dgvProducts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddEditProducts";
            this.Text = "Add or Edit Products Available";
            this.Load += new System.EventHandler(this.frmAddEditProducts_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbProductDetails.ResumeLayout(false);
            this.gbProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.GroupBox gbProductDetails;
        private System.Windows.Forms.Label lblProdID;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
    }
}