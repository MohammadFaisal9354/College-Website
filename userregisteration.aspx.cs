using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class registeration : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select * from Register", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
        ds = new DataSet();
        da.Fill(ds);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataRow dr = ds.Tables[0].NewRow();
        dr[0] = int.Parse(TextBox1.Text);
        dr[1] = TextBox2.Text;
        dr[2] = TextBox3.Text;
        dr[3] = TextBox4.Text;
        dr[4] = TextBox5.Text;
        dr[5] = TextBox6.Text;
        dr[6] = TextBox7.Text;
        dr[7] = TextBox8.Text;
        dr[8] = TextBox9.Text;
        ds.Tables[0].Rows.Add(dr);
        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
        da.Update(ds.Tables[0]);
        Response.Write("<script>alert('Record Inserted successfully')</script>");
        TextBox1.Text = null;
        TextBox2.Text = null;
        TextBox3.Text = null;
        TextBox4.Text = null;
        TextBox5.Text = null;
        TextBox6.Text = null;
        TextBox7.Text = null;
        TextBox8.Text = null;
        TextBox9.Text = null;
    }
}