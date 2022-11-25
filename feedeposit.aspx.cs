using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class feedeposit : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select * from studentfees", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
        ds = new DataSet();
        da.Fill(ds);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataRow dr = ds.Tables[0].NewRow();
        dr[0] =TextBox1.Text;
        dr[1] = TextBox2.Text;
        dr[2] = TextBox3.Text;
        dr[3] = TextBox4.Text;
        dr[4] = TextBox5.Text;
        dr[5] =  int.Parse(TextBox6.Text);//no floating poin value
        dr[6] = TextBox7.Text;
        dr[7] = TextBox8.Text;
        dr[8] = DateTime.Now.ToString();
        ds.Tables[0].Rows.Add(dr);
        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
        da.Update(ds.Tables[0]);
        Response.Write("<script>alert('Submitted successfully')</script>");
    }
}