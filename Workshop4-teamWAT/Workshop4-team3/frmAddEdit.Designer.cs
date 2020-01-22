﻿namespace Workshop4_team3
{
    partial class frmAddEdit
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
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            this.packageIdTextBox = new System.Windows.Forms.TextBox();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(13, 9);
            packageIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(119, 25);
            packageIdLabel.TabIndex = 1;
            packageIdLabel.Text = "Package ID:";
            // 
            // packageIdTextBox
            // 
            this.packageIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.packageIdTextBox.Enabled = false;
            this.packageIdTextBox.Location = new System.Drawing.Point(336, 4);
            this.packageIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.Size = new System.Drawing.Size(466, 30);
            this.packageIdTextBox.TabIndex = 2;
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(13, 231);
            pkgAgencyCommissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(198, 25);
            pkgAgencyCommissionLabel.TabIndex = 3;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(336, 225);
            this.pkgAgencyCommissionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(466, 30);
            this.pkgAgencyCommissionTextBox.TabIndex = 4;
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(13, 194);
            pkgBasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(112, 25);
            pkgBasePriceLabel.TabIndex = 5;
            pkgBasePriceLabel.Text = "Base Price:";
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(336, 188);
            this.pkgBasePriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(466, 30);
            this.pkgBasePriceTextBox.TabIndex = 6;
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(13, 81);
            pkgDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(115, 25);
            pkgDescLabel.TabIndex = 7;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Location = new System.Drawing.Point(336, 75);
            this.pkgDescTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.Size = new System.Drawing.Size(466, 30);
            this.pkgDescTextBox.TabIndex = 8;
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(13, 157);
            pkgEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(99, 25);
            pkgEndDateLabel.TabIndex = 9;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(336, 150);
            this.pkgEndDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(466, 30);
            this.pkgEndDateDateTimePicker.TabIndex = 10;
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(13, 46);
            pkgNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(152, 25);
            pkgNameLabel.TabIndex = 11;
            pkgNameLabel.Text = "Package Name:";
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameTextBox.Location = new System.Drawing.Point(336, 40);
            this.pkgNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(466, 30);
            this.pkgNameTextBox.TabIndex = 12;
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(13, 119);
            pkgStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(105, 25);
            pkgStartDateLabel.TabIndex = 13;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(336, 112);
            this.pkgStartDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(466, 30);
            this.pkgStartDateDateTimePicker.TabIndex = 14;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(Workshop4_team3.Package);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(336, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 43);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(697, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 43);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 345);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(packageIdLabel);
            this.Controls.Add(this.packageIdTextBox);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.pkgDescTextBox);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameTextBox);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddEdit";
            this.Text = "frmAddEdit";
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox packageIdTextBox;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}