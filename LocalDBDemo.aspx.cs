﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LocalDBDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGetMovies_Click(object sender, EventArgs e)
    {
        //sidotaan oliokokoelma DataList kontrolliin
        var muuvit = Movie.Get3Movies();
        myDataList.DataSource = muuvit;
        myDataList.DataBind();
    }
}