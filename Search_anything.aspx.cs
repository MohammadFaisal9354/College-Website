using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Search_anything : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        //da = new SqlDataAdapter("select * from Register", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
        //ds = new DataSet();
        //da.Fill(ds);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select * from emptytable", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
        ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();

       
        GridView2.DataSource = ds.Tables[0];
        GridView2.DataBind();

        GridView3.DataSource = ds.Tables[0];
        GridView3.DataBind();
        GridView4.DataSource = ds.Tables[0];
        GridView4.DataBind();



        da = new SqlDataAdapter("select * from Register", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
        ds = new DataSet();
        da.Fill(ds);
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            if (dr[0].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from Register where Roll_no= ' " + TextBox1.Text + " '", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else if (dr[1].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from Register where Name= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else if (dr[2].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from Register where Father_Name= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else if (dr[3].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from Register where contact= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else if (dr[4].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from Register where dob= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else if (dr[5].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from Register where course= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else if (dr[6].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from Register where username= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else if (dr[7].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from Register where pass= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else if (dr[8].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from Register where email= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('No Record Found In Student Registeration Table')</script>");
            }
            break;
        }
        da = new SqlDataAdapter("select * from staffdetails", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
        ds = new DataSet();
        da.Fill(ds);
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            if (dr[0].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where name= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
            else if (dr[1].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where fathername= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
            else if (dr[2].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where contact= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
            else if (dr[3].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where email= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
            else if (dr[4].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where dateofjoining= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
            else if (dr[5].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where dateofbirth= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
            else if (dr[6].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where address= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
            else if (dr[7].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where adhaar= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
            else if (dr[8].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where username= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
            else if (dr[9].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where pass= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
            else if (dr[10].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where designation= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
            else if (dr[11].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from staffdetails where employeeid= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
            }
           else
            {
                Response.Write("<script>alert('No Record Found In Staff Details')</script>");
            }
            break;
        }
        da = new SqlDataAdapter("select * from studentfees", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
        ds = new DataSet();
        da.Fill(ds);
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            if (dr[0].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from studentfees where rollno= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView3.DataSource = ds.Tables[0];
                GridView3.DataBind();
            }
            else if (dr[1].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from studentfees where name= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView3.DataSource = ds.Tables[0];
                GridView3.DataBind();
            }
            else if (dr[2].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from studentfees where fathername= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView3.DataSource = ds.Tables[0];
                GridView3.DataBind();
            }
            else if (dr[3].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from studentfees where course= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView3.DataSource = ds.Tables[0];
                GridView3.DataBind();
            }
            else if (dr[4].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from studentfees where month= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView3.DataSource = ds.Tables[0];
                GridView3.DataBind();
            }
            else if (dr[5].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from studentfees where amountinnumber= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView3.DataSource = ds.Tables[0];
                GridView3.DataBind();
            }
            else if (dr[6].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from studentfees where amountinwords= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView3.DataSource = ds.Tables[0];
                GridView3.DataBind();
            }
            else if (dr[7].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from studentfees where mobileno= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView3.DataSource = ds.Tables[0];
                GridView3.DataBind();
            }
            else if (dr[8].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from studentfees where datetime= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView3.DataSource = ds.Tables[0];
                GridView3.DataBind();
            }
            else
            {
                Response.Write("<script>alert('No Record Found In Student Fees Table')</script>");
            }
            break;
        }
        da = new SqlDataAdapter("select * from empsalary", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
        ds = new DataSet();
        da.Fill(ds);
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            if (dr[0].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from empsalary where employeeid= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView4.DataSource = ds.Tables[0];
                GridView4.DataBind();
            }
            else if (dr[1].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from empsalary where name= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView4.DataSource = ds.Tables[0];
                GridView4.DataBind();
            }
            else if (dr[2].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from empsalary where designation= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView4.DataSource = ds.Tables[0];
                GridView4.DataBind();
            }
            else if (dr[3].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from empsalary where salaryinnumber= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView4.DataSource = ds.Tables[0];
                GridView4.DataBind();
            }
            else if (dr[4].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from empsalary where salaryinwords= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView4.DataSource = ds.Tables[0];
                GridView4.DataBind();
            }
            else if (dr[5].ToString() == TextBox1.Text)
            {
                da = new SqlDataAdapter("select * from empsalary where month= '" + TextBox1.Text + "'", "initial catalog=tkcmt; data source=DESKTOP-G2KN9RI\\SQLEXPRESS;integrated security=true;");
                ds = new DataSet();
                da.Fill(ds);
                GridView4.DataSource = ds.Tables[0];
                GridView4.DataBind();
            }
            else
            {
                Response.Write("<script>alert('No Record Found In - Emmployee Salary Table')</script>");
            }
            break;
        }
       
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}