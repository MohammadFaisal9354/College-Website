<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
            height: 300px;
        }
        .style6
        {
            width: 129px;
            height: 39px;
        }
        .style7
        {
            height: 39px;
        }
        .style8
        {
            height: 155px;
            width: 134px;
        }
        .style9
        {
            float: left;
            width: 275px;
        }
        .style10
        {
            width: 98%;
            height: 304px;
        }
        .style12
        {
            height: 2px;
        }
        .style14
        {
            height: 2px;
            width: 221px;
        }
        .style15
        {
            width: 221px;
        }
        .style26
        {
            height: 2px;
            width: 10px;
        }
        .style27
        {
            width: 10px;
        }
        .style34
        {
            height: 2px;
            width: 7px;
        }
        .style43
        {
            width: 221px;
            height: 167px;
        }
        .style44
        {
            width: 10px;
            height: 167px;
        }
        .style45
        {
            width: 192px;
            height: 167px;
        }
        .style46
        {
            width: 7px;
            height: 167px;
        }
        .style47
        {
            height: 167px;
        }
        .style49
        {
            height: 3px;
            width: 10px;
        }
        .style54
        {
            height: 22px;
            width: 10px;
        }
        </style>



  
</head>
<body background="images/d.jpg" >
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
  <li><a href="#">Academics</a></li>
  <li><a href="#">Cources</a></li>
  <li><a href="#">Scope</a></li>
  <li><a href="#">Career</a></li>
  <li><a href="contactus.aspx">Contact Us</a></li>
  <li><a href="aboutus.aspx">About Us</a></li>
  <li><a href="#">Teachers</a></li>
  <li><a href="#">Admission</a></li>
  <li><a href="adminlogin.aspx">Admin Login</a></li>
  <li><a href="userlogin.aspx">User Login</a></li>
</ul>
</div>
    <div id="extra">
    </div>
    <div id="bodyfull" style="background-color: #E9E9E9">


     <div id="bodyup">
     <div id="bodyup_marquee" class="style9">
              
         <table class="style1">
             <tr>
                 <td class="style6">
                     <img src="images/Mohammad%20Faisal.jpg" class="style8" />
                     </td>
                 <td class="style7">
                 <h2 align="center">Founder of College Respected Mohammad Faisal</h2>
                     </td>
             </tr>
             <tr>
                 <td colspan="2">
                     Mohammad Faisal were born on 7 August 1998 in varanasi,he has a dream to provide quality eduations for the students of computer science,for the development of Computer Science Field.</td>
             </tr>
         </table>
              
    </div>
    <div id="bodyup_slider" style="float:left">
        <img src="images/1.gif" height=100% width=100% />
    </div>
    </div>   
     <div id="bodydown">
      <div id="bodydown1" style="float:left">
              
          <table class="style10">
              <tr>
                  <td class="style14">
                  </td>
                  <td class="style26">
                      </td>
                
                  <td rowspan="6">
                      &nbsp;</td>
                  <td class="style34">
                      </td>
                  <td class="style12">
                  </td>
              </tr>
              <tr>
                  <td class="style43">
                      <asp:Image ID="Image1" runat="server" Height="144px" ImageUrl="~/images/i.jpg" 
                          Width="386px" />
                  </td>
                  <td class="style44">
                  </td>
                  <td class="style45">
                      <asp:Image ID="Image3" runat="server" Height="144px" 
                          ImageUrl="~/images/j.png" 
                          Width="211px" />
                  </td>
                  <td class="style46">
                  </td>
                  <td class="style47">
                      <asp:Image ID="Image4" runat="server" Height="144px" 
                          ImageUrl="~/images/k.jpg" 
                          Width="251px" />
                  </td>
              </tr>
              <tr>
                  <td class="style15" rowspan="3">
                      <asp:Image ID="Image5" runat="server" Height="144px" 
                          ImageUrl="~/images/m.jpg" 
                          Width="378px" />
                  </td>
                  <td class="style27">
                      &nbsp;</td>
                  <td rowspan="3" colspan="3">
                      <asp:Image ID="Image6" runat="server" Height="144px" 
                          ImageUrl="~/images/z.jpg" 
                          Width="481px" />
                  </td>
              </tr>
              <tr>
                  <td class="style49">
                  </td>
              </tr>
              <tr>
                  <td class="style54">
                  </td>
              </tr>
              
          </table>
              
    </div>  
    <div id="bodydown2" style="float:left">
              
              <marquee direction="up" height="350px" width="300px"onmouseover="this.stop();" onmouseout="this.start();"><ul>
              <li><a href="index.aspx">
            Seminar on "The Philosophical and Psychological Aspects of Yoga" Key Person(s): Dr. Jyotsna Srivastava, Convener, Section of Philosophy, Mahila Mahavidyalaya, Tkcmt Event Date(s): 18-10-2019 to 19-10-2019</a></li><br />
              <li><a href="index.aspx">दो दिवसीय अन्तर्राष्ट्रीय संगोष्ठी 'गुप्तवंशैकवीर: स्कन्दगुप्त विक्रमादित्य का ऐतिहासिक पुनःस्मरण एवं भारत राष्ट्र का राजनीतिक भविष्य' Key Person(s): भारत अध्ययन केन्द्र Event Date(s): 17-10-2019 to 18-10-2019
[ Concept Note ] [ Form ]</a></li><br />
              <li><a href="index.aspx">A National Worksop on "Learning Paradigm and Aids of Animal Sciences" Key Person(s): Dr. Priya Ranjan Kumar, Organising Secretary, Dept. of Vet. Gyn. & Obs. Event Date(s): 18-10-2019 to 19-10-2019</a></li><br />
              <li><a href="index.aspx">A Workshop on Neutrino Physics:Theory and Experiments Key Person(s): Dr. Venktesh Singh, Convener, Physics Department, Institute of Science , Tkcmt Event Date(s): 19-10-2019 to 25-10-2019</a></li><br />
              <li><a href="index.aspx"> Workshop of Pt. Vidyadhar Vyas (an eminent Vocal exponent of Gwalior Gharana) Key Person(s): Prof. Sangeeta Pandit, Head, Deptt. of Vocal Music, Faculty of Performing Arts, Tkcmt Event Date(s): 20-10-2019 to 21-10-2019</a></li><br />
              <li><a href="index.aspx">Special Lectures (Two) Key Person(s): Dr. Vikram Singh, Coordinator, Deptt. of Physical Education, Faculty of Arts, Tkcmt Event Date(s): 21-10-2019 to 24-10-2019</a></li><br />
              <li><a href="index.aspx">Wheelbox National Employability Test (for Internal final year Students of Tkcmt).</a></li><br />
              <li><a href="index.aspx">Click here for Leadership for Academicians Program (LEAP), a MHRD, GoI initiative .</a></li>
            </ul></marquee>

    </div>      
    </div>     
        
         
    </div>
    <div id="footer"class="animated flip">
<table>
<tr>
<th colspan="25">  <th>
    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<th><a href="index.aspx">Home</a><th>
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
