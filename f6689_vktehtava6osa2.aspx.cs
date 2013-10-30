using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class f6689_vktehtava6osa2 : System.Web.UI.Page
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

    protected void btn_Click(object sender, EventArgs e)
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + MapPath("~/App_Data/SMLiiga.accdb") + ";Persist Security Info=False;");
        OleDbCommand cmd = new OleDbCommand("SELECT MAX(id) FROM Pisteet");
        
        cmd.Connection = cn;
        cn.Open();

        OleDbDataReader reader = cmd.ExecuteReader();
        reader.Read();
        int i = reader.GetInt16(0) + 1;
        

        OleDbConnection cna = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + MapPath("~/App_Data/SMLiiga.accdb") + ";Persist Security Info=False;");
        OleDbCommand cmds = new OleDbCommand("INSERT INTO Pisteet (sukunimi, etunimi, seura, pelipaikka, id) VALUES('"+txt2.Text+"','"+txt1.Text+"','"+drop.SelectedValue+"','"+drop2.SelectedValue+"','"+i+"')");

        cmds.Connection = cna;
        cna.Open();

        cmds.ExecuteNonQuery();
    }
}