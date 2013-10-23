using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class viikkotehtava5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

        DirectoryInfo dir = new DirectoryInfo(MapPath("t5"));
        FileInfo[] files = dir.GetFiles();
        ArrayList listItems = new ArrayList();
        foreach (FileInfo info in files)
        {
            if (info.Extension == ".jpg" || info.Extension == ".jpeg" || info.Extension == ".gif" || info.Extension == ".png")
            {
                listItems.Add(info);
            }
        }
      
        //DataList1.DataSource = listItems;
        //DataList1.DataBind();

        DataSet dataSet = new DataSet();
        dataSet.ReadXml(MapPath("~/App_Data/XMLs.xml"));
        DataList1.DataSource = dataSet;
        DataList1.DataBind();


    }



   


}