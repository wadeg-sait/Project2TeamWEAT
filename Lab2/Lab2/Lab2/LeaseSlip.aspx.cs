﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MarinaEntities1 db = new MarinaEntities1();
            if (!(bool)Session["Authenticated"])
            {
                Response.Redirect("Registration.aspx");
            }
            dgvLease.DataSource = from slip in db.Slips
                                  join doc in db.Docks on slip.DockID == doc. 
        }
    }
}