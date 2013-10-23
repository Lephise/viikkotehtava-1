using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Viikkotehtava4_WanhatAutot : System.Web.UI.Page
{

    /*
    Kun käyttäjä surffaa sivulle esitetään oletusarvoisesti käyttäjälle neljän sattuman varaisesti valitun auton tiedot: merkki, malli, vuosimalli ja hinta.
    
    Käyttäjälle on myös toiminallisuus jolla hän voi:
    a) valita näytettäväksi listattuna kaikki myynnissä olevat autot joko hinnan mukaan nousevassa/laskevassa järjestyksessä
    b) valitun automerkin autot, automerkin käyttäjä valitsee listasta tai comboxista, eli hän EI kirjoita sitä
    c) haku, jolloin käyttäjä kirjoittaa hakukenttään haluamansa hakusanan, jonka jälkeen haetaan vastaavia merkkijonoa merkki- ja mallisarakkeista
     */

    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        DataTable dt;

        int r;
  
        ds.ReadXml(MapPath("~/App_Data/WanhatAutot.xml"));
        dt = ds.Tables[0];

        merkit.DataSource = ds.Tables[0];
        merkit.DataTextField = "merkki";
        merkit.DataValueField = "merkki";
        merkit.DataBind();

        //En löytänyt kuinka päästä käsiksi yksittäisiin xml elementteihin joten sen sijaan että lisättäisi listaan 4 random autoa sieltä poistetaan niitä 8.
        for (int i = 0; i < 8; i++)
        {
            r = new Random().Next(0, 12 - i);
            dt.Rows.RemoveAt(r);
        }

        grid.DataSource = dt;
        grid.DataBind();

        

    }
    
    protected void button_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        DataTable dt;
        

       


        ds.ReadXml(MapPath("~/App_Data/WanhatAutot.xml"));
        dt = ds.Tables[0];
        grid.DataSource = dt;
        grid.DataBind();

        if (asc.Checked == true)
        {
            DataView sorted = dt.DefaultView;
            sorted.Sort = "myyntiHinta"+ " " + "asc";
            grid.DataSource = sorted;
            grid.DataBind();
        }

        if(merkit.SelectedValue.ToString() != null){

            //string merkki = merkit.SelectedItem.ToString();
            label1.Text = merkit.SelectedItem.ToString();
            label2.Text = merkit.SelectedItem.ToString();
           /* DataTable dt2 = (DataTable)grid.DataSource;

            for (int i = 0; i < 10; i++)
            {
                if (grid.Rows[10 - i].Cells[2].Text != merkit.SelectedItem.ToString())
                {

                    dt2.Rows[10 - i].Delete();

                }
            }

            grid.DataSource = dt2;
            grid.DataBind();*/
        }

        
        


        
    }




    protected void merkit_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}