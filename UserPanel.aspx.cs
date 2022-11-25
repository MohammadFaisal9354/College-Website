using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class UserPanel : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select * from Register", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
        ds = new DataSet();
        da.Fill(ds);
        string a;
        a = Session["khan"].ToString();
        //da = new SqlDataAdapter("Select * from Register where username='" + a.ToString() + "'", "initial catalog=tkcmt;data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true");
        //ds = new DataSet();
        //da.Fill(ds);
        //GridView1.DataSource = ds.Tables[0];
        //GridView1.DataBind();
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            if (dr[6].ToString() == a.ToString())
            {
                Label1.Text = dr[0].ToString();
                Label2.Text = dr[1].ToString();
                Label3.Text = dr[2].ToString();
                Label4.Text = dr[3].ToString();
                Label5.Text = dr[4].ToString();
                Label6.Text = dr[5].ToString();
                Label7.Text = dr[6].ToString();
                Label8.Text = dr[7].ToString();
                Label9.Text = dr[8].ToString();
                break;
                //da = new SqlDataAdapter("select * from Register where username='"+a.ToString()+" ' ", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                //ds = new DataSet();
                //da.Fill(ds);
                //GridView1.DataSource = ds.Tables[0];
                //GridView1.DataBind();
            }
        }
        fee();
    }

    public void fee()
    {
        da = new SqlDataAdapter("select * from studentfees where rollno=" + Label1.Text + "", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
        ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
}