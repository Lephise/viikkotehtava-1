using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class viikkotehtava5b : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String cd = Request.QueryString["cd"];
      
        DirectoryInfo dir = new DirectoryInfo(MapPath("t5"));
        FileInfo[] files = dir.GetFiles();
        /*
        ArrayList listItems = new ArrayList();
        foreach (FileInfo info in files)
        {
            if (info.Extension == ".jpg" || info.Extension == ".jpeg" || info.Extension == ".gif" || info.Extension == ".png")
            {
                listItems.Add(info);
            }
        }
         * */

        //DataList1.DataSource = listItems;
        //DataList1.DataBind();
  

        image.ImageUrl = "~/t5/"+ cd+ ".jpg" ;

        XmlDocument xmldoc = new XmlDocument();
        xmldoc.Load(Server.MapPath("~/App_Data/XMLs.xml"));
        LblISBN.Text =  xmldoc.SelectSingleNode("/cds/cd[Name='"+ cd + "']/isbn").InnerText;

        XmlNodeList biisit = xmldoc.SelectNodes("/cds/cd[Name='" + cd + "']/biisit");
        

        foreach (XmlNode i in biisit)
        {
            Label lb = new Label();
            lb.Text = i.InnerText + "\n";
            biisiaa.Controls.Add(lb);
            
            
        }
       

        /*
        DataSet dataSet = new DataSet();
        dataSet.ReadXml(MapPath("~/App_Data/XMLs.xml"));
        DataList1.DataSource = dataSet;
        DataList1.DataBind();
        */
       



    }
}