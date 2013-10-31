using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class f6689_haeilmot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            /*
            VAIHTOEHTOINEN TAPA
             
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Data Source=eight.labranet.jamk.fi;Initial Catalog=DemoxOy;Persist Security Info=True;User ID=koodari;Password=koodari13";

            SqlCommand cm = new SqlCommand("SELECT DISTINCT(course) FROM lasnaolot");

            cm.Connection = cn;
            cn.Open();
            
            drop.DataSource = cm.ExecuteReader();
             */

            srcIlm.SelectCommand = "SELECT DISTINCT(course) FROM lasnaolot";
            
            drop.DataSource = srcIlm;
            drop.DataTextField = "course";
            drop.DataBind();
        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        if (txt.Text != null)
        {
            srcIlm.SelectCommand = "SELECT asioid, lastname, firstname, date FROM lasnaolot WHERE course like '"+drop.SelectedItem.Text+"%' AND lastname like '" + txt.Text + "%' ORDER BY asioid";
            grid.DataSource = srcIlm;
            grid.DataBind();
        }

    }
}