using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Registerationemploye : System.Web.UI.Page
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
        DataRow dr = ds.Tables[0].NewRow();
        dr[0] = TextBox1.Text;
        dr[1] = TextBox2.Text;
        dr[2] = TextBox3.Text;
        dr[3] = TextBox4.Text;
        dr[4] = TextBox5.Text;
        dr[5] = TextBox6.Text;
        dr[6] = TextBox7.Text;
        dr[7] = TextBox8.Text;
        dr[8] = TextBox9.Text;
        dr[9] = TextBox10.Text;
        dr[10] = TextBox11.Text;
        dr[11] = TextBox12.Text;
        ds.Tables[0].Rows.Add(dr);
        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
        da.Update(ds.Tables[0]);
        Response.Write("<script>alert('Record Inserted successfully')</script>");
    }
}