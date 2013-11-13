using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vktehtava7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        string filename = MapPath("~/App_Data/WanhatAutott.xml");

        grid.DataSource = BLAutot.GetCars(filename);
        grid.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)

    {

        grid.EditIndex = e.NewEditIndex;

        BindGridView();

    }

    protected void BindGridView()

    {

        string filename = MapPath("~/App_Data/WanhatAutott.xml");

        grid.DataSource = BLAutot.GetCars(filename);
        grid.DataBind();

    

    }


    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)

    {

        int index = grid.Rows[e.RowIndex].DataItemIndex;

        string aid = ((TextBox)grid.Rows[e.RowIndex].FindControl("aid")).Text;

        string rekkari = ((TextBox)grid.Rows[e.RowIndex].FindControl("rekkari")).Text;

        string merkki = ((TextBox)grid.Rows[e.RowIndex].FindControl("merkki")).Text;
        string malli = ((TextBox)grid.Rows[e.RowIndex].FindControl("malli")).Text;
        string vm = ((TextBox)grid.Rows[e.RowIndex].FindControl("vm")).Text;
        string myynti = ((TextBox)grid.Rows[e.RowIndex].FindControl("myynti")).Text;
        string osto = ((TextBox)grid.Rows[e.RowIndex].FindControl("osto")).Text;

        grid.EditIndex = -1;

        BindGridView();

        DataSet dsUpdate = (DataSet)grid.DataSource;

        dsUpdate.Tables[0].Rows[index]["aid"] = aid;
        dsUpdate.Tables[0].Rows[index]["rekkari"] = rekkari;
        dsUpdate.Tables[0].Rows[index]["merkki"] = merkki;
        dsUpdate.Tables[0].Rows[index]["malli"] = malli;
        dsUpdate.Tables[0].Rows[index]["vm"] = vm;
        dsUpdate.Tables[0].Rows[index]["myyntiHinta"] = myynti;
        dsUpdate.Tables[0].Rows[index]["sisaanOstoHinta"] = osto;

        dsUpdate.WriteXml(Server.MapPath("~/App_Data/WanhatAutott.xml"));

        BindGridView();

    }

    
}