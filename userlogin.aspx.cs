using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class userlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds;
        da=new SqlDataAdapter("Select * from Register","initial catalog=tkcmt;data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true");
        ds = new DataSet();
        da.Fill(ds);
      
    
        foreach (DataRow dsa in ds.Tables[0].Rows)
        {
            if (dsa[6].ToString() == TextBox1.Text && dsa[7].ToString() == TextBox2.Text)
            {
                Session["khan"] = TextBox1.Text;
                Response.Redirect("UserPanel.aspx");
                break;
            }
            
            else
            {
                continue;
            }
       }
        Response.Write("<script>alert('Incurrect user and password')</script>");

        }
    }
