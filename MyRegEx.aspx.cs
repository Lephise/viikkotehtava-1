using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyRegEx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        String regex = "^[a-zA-Z]*$";
        String st = txt1.Text;

        if(Regex.IsMatch(st, regex)){
            lbl1.Text = "Kelpaa";
        }
        else{
            lbl1.Text = "Ei kelpaa";
        }

    }
    protected void btn2_Click(object sender, EventArgs e)
    {
        String regex = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
           // "^[a-zA-Z]*$";
        String st = txt2.Text;

        if (Regex.IsMatch(st, regex))
        {
            lbl1.Text = "Kelpaa";
        }
        else
        {
            lbl1.Text = "Ei kelpaa";
        }
    }
}