using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Tehtava9vastausform : System.Web.UI.Page
{
    private int[] vastattu = { 0, 0, 0, 0, 0 };
    private int maara;

    protected void Page_Load(object sender, EventArgs e)
    {


        XmlDocument xmldoc = new XmlDocument();
        xmldoc.Load(Server.MapPath("~/App_Data/kysymykset.xml"));
        maara = Convert.ToInt32(xmldoc.SelectSingleNode("/kysymykset/kysymys/maara").InnerText);
        label.Text = xmldoc.SelectSingleNode("/kysymykset/kysymys/text").InnerText;

        if (maara > 2)
        {

            /*  RadioButton radio = new RadioButton();
              radio.Text = xmldoc.SelectSingleNode("/kysymykset/kysymys/vaihtotehdot/vaihtoehto").InnerText;
              vaihtoehdot.Controls.Add(radio);*/

            XmlNodeList vaihtoehtoja = xmldoc.SelectNodes("/kysymykset/kysymys/vaihtoehdot");

            for (int i = 1; i < maara + 1; i++)
            {


                RadioButton rad = new RadioButton();
                rad.ID = "rad" + i.ToString();
                rad.Text = xmldoc.SelectSingleNode("/kysymykset/kysymys/vaihtotehto[" + i + "]").InnerText;
                vaihtoehdot.Controls.Add(rad);




            }




        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {

    }

}