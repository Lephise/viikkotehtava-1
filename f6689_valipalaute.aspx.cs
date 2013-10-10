using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class f6689_valipalaute : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void myBtn_Click(object sender, EventArgs e)
    {
      
            //file name
        string filename = Server.MapPath("~/App_Data/palaute.xml");

            //create new instance of XmlDocument
            XmlDocument doc = new XmlDocument();

            //load from file
            doc.Load(filename);

            //create node and add value
            XmlNode node = doc.CreateNode(XmlNodeType.Element, "palaute", null);
            //node.InnerText = "this is new node";

            //create title node
            XmlNode nodePvm = doc.CreateElement("pvm");
            //add value for it
            nodePvm.InnerText = pvm.Text;

            //create Url node
            XmlNode nodeTekija = doc.CreateElement("tekija");
            nodeTekija.InnerText = nimi.Text;

            XmlNode nodeOpittu = doc.CreateElement("opittu");
            nodeOpittu.InnerText = oppinut.Text;

            XmlNode nodeHaluan = doc.CreateElement("haluanoppia");
            nodeHaluan.InnerText = haluan.Text;

            XmlNode nodeHyvaa = doc.CreateElement("hyvaa");
            nodeHyvaa.InnerText = hyvaa.Text;

            XmlNode nodeParan = doc.CreateElement("parannettavaa");
            nodeParan.InnerText = paran.Text;

            XmlNode nodeMuuta = doc.CreateElement("muuta");
            nodeMuuta.InnerText = muuta.Text;

            //add to parent node
            node.AppendChild(nodePvm);
            node.AppendChild(nodeTekija);
            node.AppendChild(nodeOpittu);
            node.AppendChild(nodeHaluan);
            node.AppendChild(nodeHyvaa);
            node.AppendChild(nodeParan);
            node.AppendChild(nodeMuuta);

            //add to elements collection
            doc.DocumentElement.AppendChild(node);

            //save back
            doc.Save(filename);
        }

   
}
