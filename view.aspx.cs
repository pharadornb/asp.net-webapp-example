﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtfirstName.Text = Request.QueryString["Firstname"];
            txtlastName.Text = Request.QueryString["Lastname"];
        }
    }
}