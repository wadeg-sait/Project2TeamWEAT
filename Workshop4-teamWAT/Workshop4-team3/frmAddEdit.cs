﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop4_team3
{
    public partial class frmAddEdit2 : Form
    {
        public frmAddEdit2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // add validation and Save entity code
        }

        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            TravelExpertsDataContext teSuppliers = new TravelExpertsDataContext();
            List<Supplier> suppliers = new List<Supplier>();
            Supplier tempSup = new Supplier();

            foreach(Supplier sup in teSuppliers.Suppliers)
            {
                tempSup.SupName = sup.SupName;
                tempSup.SupplierId = sup.SupplierId;
               
                suppliers.Add(tempSup);
            }


            
            
        }
    }
}
