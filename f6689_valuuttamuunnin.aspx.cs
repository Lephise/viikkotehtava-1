using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class f6689_valuuttamuunnin : System.Web.UI.Page
{
    private const float BitCoinValue = 94.71F;

    protected void Page_Load(object sender, EventArgs e)
    {



    }


    protected void btnConvert_Click(object sender, EventArgs e)
    {
        //muunnetaan annetut bitcoinit euroiks
        lblCurr.Text = string.Format("{0} euroa", float.Parse(txtCoin.Text) * BitCoinValue);
        
    }
}