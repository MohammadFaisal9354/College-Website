<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminlogin.aspx.cs" Inherits="adminlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="StyleSheet.css" rel="StyleSheet" type="text/css" />
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
             height: 278px;
         }
         .style2
         {
         }
         .style3
         {
             width: 251px;
         }
         .style4
         {
             width: 377px;
         }
         .style5
         {
             width: 185px;
         }
     </style>
</head>
<body background="images/d.jpg" >
<center>
    <form id="form1" runat="server">
    <div>
    <div id="full_page">
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
    <div id="bodyfull">
       
        <table class="style1">
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td align="center" class="style2" colspan="2" 
                    style="font-size: xx-large; font-weight: bold; text-decoration: underline;">
                    Admin Login</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td align="left" class="style5" style="font-size: x-large; font-weight: bold">
                    Enter User Name</td>
                <td align="left" class="style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="234px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td align="left" class="style5" style="font-size: x-large; font-weight: bold">
                    Enter Password</td>
                <td align="left" class="style3">
                    <asp:TextBox ID="TextBox2" runat="server" Width="232px" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td align="left" class="style5" style="font-size: x-large; font-weight: bold">
                    &nbsp;</td>
                <td align="left" class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td align="left" class="style5" style="font-size: x-large; font-weight: bold">
                    &nbsp;</td>
                <td align="left" class="style3">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" 
                        Width="97px" style="height: 26px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
       
    </div>
    <div id="footer"class="animated flip">
<table>
<tr>
<th colspan="25">  <th>
    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<th><a href="Default.aspx">Home</a><th>
<th>  &nbsp;&nbsp;<th>
<th><a href="https://facebook.com"> Facebook page</a> </th>
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
<th colspan="23"><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;Developed by :-Mohammad Faisal khan</p></th>

</table>


</div>

    
    </div>
    </div>
    </form>
</center>
</body>
</html>
