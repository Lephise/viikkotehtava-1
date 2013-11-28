using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Tehtava9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void maara_SelectedIndexChanged(object sender, EventArgs e)
    {
        int maar = Convert.ToInt32(maara.SelectedValue);

        vaiht1.Visible = false;
        vaiht2.Visible = false;
        vaiht3.Visible = false;
        vaiht4.Visible = false;
        vaiht5.Visible = false;

        if (maar > 2)
        {
            

            for (int i = 0; i < maar; i++)
            {
                if (i == 0)
                {
                    vaiht1.Visible = true;
                }
                else if (i == 1)
                {
                    vaiht2.Visible = true;
                }

                else if (i == 2)
                {
                    vaiht3.Visible = true;
                }

                else if (i == 3)
                {
                    vaiht4.Visible = true;
                }

                else if (i == 4)
                {
                    vaiht5.Visible = true;
                }
            }
        }
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        string filename = Server.MapPath("~/App_Data/kysymykset.xml");

        //create new instance of XmlDocument
        XmlDocument doc = new XmlDocument();

        //load from file
        doc.Load(filename);

        //create node and add value
        XmlNode node = doc.CreateNode(XmlNodeType.Element, "kysymys", null);
        //node.InnerText = "this is new node";

        //create title node
        XmlNode nodeTxt = doc.CreateElement("text");
        //add value for it
        nodeTxt.InnerText = kysymys.Text;

        node.AppendChild(nodeTxt);


        XmlNode nodeMaar = doc.CreateElement("maara");
        nodeMaar.InnerText = maara.SelectedValue;
        node.AppendChild(nodeMaar);

        int maar = Convert.ToInt32(maara.SelectedValue);

        if (maar == 2)
        {
            XmlNode nodeKylla = doc.CreateElement("vaihtotehto");
            nodeKylla.InnerText = "Kyllä";

            XmlNode nodeEi = doc.CreateElement("vaihtotehto");
            nodeEi.InnerText = "Ei";

            node.AppendChild(nodeKylla);
            node.AppendChild(nodeEi);
        }

        else
        {
            for (int i = 1; i-1 < maar; i++)
            {
                XmlNode nodee = doc.CreateElement("vaihtotehto");

                if (i == 1)
                    nodee.InnerText = vaiht1.Text;
                else if (i == 2)
                    nodee.InnerText = vaiht2.Text;
                else if (i == 3)
                    nodee.InnerText = vaiht3.Text;
                else if (i == 4)
                    nodee.InnerText = vaiht4.Text;
                else if (i == 5)
                    nodee.InnerText = vaiht5.Text;

                node.AppendChild(nodee);
            }
        }
        
        //add to elements collection
        doc.DocumentElement.AppendChild(node);

        //save back
        doc.Save(filename);
    }
}