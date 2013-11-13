using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLAutot
/// </summary>
public class BLAutot
{
	public BLAutot()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static DataSet GetCars(string path){
        DataSet ds = new DataSet();
        ds.ReadXml(path);
       
        return ds;
    }
}