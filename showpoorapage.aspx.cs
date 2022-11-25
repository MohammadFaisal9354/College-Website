using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class showpoorapage : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("Select * from Register", "initial catalog=tkcmt;data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true");
        ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
        da = new SqlDataAdapter("Select * from staffdetails", "initial catalog=tkcmt;data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true");
        ds = new DataSet();
        da.Fill(ds);
        GridView2.DataSource = ds.Tables[0];
        GridView2.DataBind();
        da = new SqlDataAdapter("Select * from studentfees", "initial catalog=tkcmt;data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true");
        ds = new DataSet();
        da.Fill(ds);
        GridView3.DataSource = ds.Tables[0];
        GridView3.DataBind();
        da = new SqlDataAdapter("Select * from empsalary", "initial catalog=tkcmt;data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true");
        ds = new DataSet();
        da.Fill(ds);
        GridView4.DataSource = ds.Tables[0];
        GridView4.DataBind();
    }
}