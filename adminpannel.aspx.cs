using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpannel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click2(object sender, EventArgs e)
    {
        Response.Redirect("userregisteration.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("employeregisteration.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("searchstudent.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("searchemployee.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("employesalary.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("feedeposit.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("feedetails.aspx");
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("salaydetails.aspx");
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("Search_anything.aspx");
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        Response.Redirect("showpoorapage.aspx");
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("showalltable.aspx");
    }
}