using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Collections;

/*
 
1) listata kaikki pelaajat aakkosjärjestyksessä
2) listata comboxista valitsemansa joukkueen pelaajat aakkosjärjestyksessä
3) listata kaikki valitun joukkueen pelaajat aakkosjärjestyksessä tai tehopisteitten mukaan järjestettynä
4) listata kaikki tietyn pelipaikan pelaajat aakkosjärjestyksessä tai tehopisteitten mukaan järjestettynä
5) listata comboxista valitsemansa pelipaikan (maalivahti, puolustaja,hyökkääjä) pelaajat tehopisteidn mukaisessa ärjestyksessä
 
 */

public partial class F6689_vktehtava6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + MapPath("~/App_Data/SMLiiga.accdb") + ";Persist Security Info=False;");
            OleDbCommand cmd = new OleDbCommand("SELECT DISTINCT(seura) FROM Pisteet");

            cmd.Connection = cn;
            cn.Open();





            drop.DataSource = cmd.ExecuteReader();
            drop.DataTextField = "seura";
            drop.DataBind();

            Validate();
        }

        

    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + MapPath("~/App_Data/SMLiiga.accdb") + ";Persist Security Info=False;");
        OleDbCommand cmd = new OleDbCommand("SELECT * FROM Pisteet ORDER BY sukunimi");

        cmd.Connection = cn;
        cn.Open();



        grid.DataSource = cmd.ExecuteReader();
        grid.DataBind();
    }

    
    protected void btn2_Click(object sender, EventArgs e)
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + MapPath("~/App_Data/SMLiiga.accdb") + ";Persist Security Info=False;");

        string order = "";
        
        if (radio1.Checked == true)
        {
            order = "sukunimi";
        }
        else if (radio2.Checked == true)
        {
            order = "pisteet";
        }

        OleDbCommand cmd = new OleDbCommand("SELECT * FROM Pisteet WHERE seura='" + drop.SelectedItem.Text + "' ORDER BY " + order);

        cmd.Connection = cn;
        cn.Open();

        grid.DataSource = cmd.ExecuteReader();
        grid.DataBind();
    }
    protected void radio1_CheckedChanged(object sender, EventArgs e)
    {
        radio2.Checked = false;
    }

    protected void radio2_CheckedChanged(object sender, EventArgs e)
    {
        radio1.Checked = false;
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + MapPath("~/App_Data/SMLiiga.accdb") + ";Persist Security Info=False;");

        string order = "";

        if (radio3.Checked == true)
        {
            order = "sukunimi";
        }
        else if (radio4.Checked == true)
        {
            order = "pisteet";
        }

        OleDbCommand cmd = new OleDbCommand("SELECT * FROM Pisteet WHERE pelipaikka='" + drop2.SelectedValue + "' ORDER BY " + order);

        cmd.Connection = cn;
        cn.Open();

        grid.DataSource = cmd.ExecuteReader();
        grid.DataBind();
    }
   
    protected void radio3_CheckedChanged(object sender, EventArgs e)
    {
        radio4.Checked = false;
    }
 
    protected void radio4_CheckedChanged1(object sender, EventArgs e)
    {
        radio3.Checked = false;
    }
}