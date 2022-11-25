using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class searchemployee : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select * from staffdetails", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
        ds = new DataSet();
        da.Fill(ds);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("Select * from staffdetails where employeeid='" + TextBox1.Text + "'", "initial catalog=tkcmt;data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true");
        ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("Select * from staffdetails", "initial catalog=tkcmt;data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true");
        ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
}