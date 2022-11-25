<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminpannel.aspx.cs" Inherits="adminpannel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href=StyleSheet.css rel="StyleSheet" type="text/css" />
    <title>Technical Khan college of Management and Tecnology</title>
     <meta http-equiv="content-type" content="text/html;charset=utf-8"/>
  
    <!-- Insert to your webpage before the </head> -->
    <script src="sliderengine/jquery.js"></script>
    <script src="sliderengine/amazingslider.js"></script>
    <link rel="stylesheet" type="text/css" href="sliderengine/amazingslider-1.css">
    <script src="sliderengine/initslider-1.js"></script>
    <!-- End of head section HTML codes -->
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 602px;
        }
        .style2
        {
            width: 487px;
        }
        .style3
        {
            width: 188px;
        }
    </style>
</head>
<body background="images/d.jpg" height="100%" width="100%">
<center>
    <form id="form1" runat="server">
    <div>
    <div class="full_page">
     <div id="banner">


     <!-- Insert to your webpage where you want to display the slider -->
    <div class="amazingslider-wrapper" id="amazingslider-wrapper-1" style="display:block;position:relative;max-width:1200px;margin:0px auto 60px;">
        <div class="amazingslider" id="amazingslider-1" style="display:block;position:relative;margin:0 auto;">
            <ul class="amazingslider-slides" style="display:none;">
                <li><img src="images/1.jpg" alt="1"  title="1" />
                </li>
                <li><img src="images/2.jpg" alt="2"  title="2" />
                </li>
                <li><img src="images/3.jpg" alt="3"  title="3" />
                </li>
                <li><img src="images/4.jpg" alt="4"  title="4" />
                </li>
                <li><img src="images/5.jpg" alt="5"  title="5" />
                </li>
            </ul>
            <ul class="amazingslider-thumbnails" style="display:none;">
                <li><img src="images/1-tn.jpg" alt="1" title="1" /></li>
                <li><img src="images/2-tn.jpg" alt="2" title="2" /></li>
                <li><img src="images/3-tn.jpg" alt="3" title="3" /></li>
                <li><img src="images/4-tn.jpg" alt="4" title="4" /></li>
                <li><img src="images/5-tn.jpg" alt="5" title="5" /></li>
            </ul>
        <div class="amazingslider-engine"><a href="http://amazingslider.com" title="jQuery Image Slideshow">jQuery Image Slideshow</a></div>
        </div>
    </div>
    <!-- End of body section HTML codes -->



       

     </div>
     <div id="menu" class="animated flip">
<ul>
  <li><a href="index.aspx">Home</a></li>
  <li><a href="Galary.aspx">Galary</a></li>
  <li><a href="#">Admission</a></li>
  <li><a href="#">Info</a></li>
  <li><a href="#">Scope</a></li>
  <li><a href="#">Career</a></li>
  <li><a href="contactus.aspx">Contact Us</a></li>
  <li><a href="aboutus.aspx">About Us</a></li>
  <li><a href="adminlogin.aspx">Admin Login</a></li>
  <li><a href="userlogin.aspx">User Login</a></li>
</ul>
</div>
    <div id="extra">
    </div>
    <div id="bodyfull" align="center" 
            style="font-size: xx-large; text-decoration: underline; font-weight: bold">
        
        Welcome Admin<br />
        <table align="center" class="style1">
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click2" 
            Text="Add new student/User" />
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
        <asp:Button ID="Button2" runat="server" Text="Add new Employee/Staff" 
            Width="192px" onclick="Button2_Click" />
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
                    <asp:Button ID="Button9" runat="server" onclick="Button9_Click" 
                        Text="Search anything" Width="190px" />
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            Text="Student Details" Width="189px" />
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
                    <asp:Button ID="Button11" runat="server" onclick="Button11_Click" 
                        Text="Show all Table" Width="185px" />
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
            Text="Employee Details" Width="181px" />
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
                    <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
                        Text="Pay Employee/staff Salary" Width="181px" />
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
                    <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
                        Text="Student Fees Deposit" Width="181px" />
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
                    <asp:Button ID="Button7" runat="server" onclick="Button7_Click" 
                        Text="Fees Details" Width="182px" />
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
                    <asp:Button ID="Button8" runat="server" onclick="Button8_Click" 
                        Text="Salary Details" Width="184px" />
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style3">
                </td>
                <td>
                </td>
                <td>
                    </td>
            </tr>
        </table>
        </div>
    <div id="footer"class="animated flip">
        <table>
            <tr>
                <th colspan="25">
                <th>
    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<th>
                    <a href="Default.aspx">Homebook page</a> </th>
<th> &nbsp;&nbsp; <th>
<th><a href="https://twittter.com"> Twitter </a></th>
<th>  &nbsp;&nbsp;<th>
<th><a href="https://google+.com">Google+</a></th>
<th> &nbsp;&nbsp; <th>
<th><a href="#"> About us</a> </th>
<th> &nbsp;&nbsp; <th>
<th><a href="#"> contact us </a></th>

</tr>
<tr>
<th colspan="3"><p>Copyright 1998-2020 www.tkcmt.com. All rights reserved.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p></th>
<th colspan="20">                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    &nbsp;</th>
<th colspan="23"><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;Developed by :-Mohammad Faisal khan</p></th>

</table>


</div>

    
    </div>
    </div>
    </form>
</center>
</body>
</html>
