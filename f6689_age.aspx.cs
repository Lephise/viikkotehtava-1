using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class f6689_age : System.Web.UI.Page
{

    void SelectionChanged(Object sender, EventArgs e)
    {
        foreach (DateTime day in Calendar1.SelectedDates)
        {
            
            myLabel.Text = day.Date.ToShortDateString() + "<br />";
            TimeSpan time = DateTime.Today.Subtract(day.Date);
            myLabel.Text = time.Days.ToString() + "päivää";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        mahLabel.Text =  DateTime.Today.ToString();

        Calendar1.SelectionChanged += new EventHandler(this.SelectionChanged);
        
        
    }


    protected void nextYear_Click(object sender, EventArgs e)
    {

    }

    protected void lastYear_Click(object sender, EventArgs e)
    {

    }
}