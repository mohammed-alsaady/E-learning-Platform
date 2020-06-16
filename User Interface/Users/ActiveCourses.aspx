<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/UserMaster.master" AutoEventWireup="true" CodeFile="ActiveCourses.aspx.cs" Inherits="Users_ActiveCourses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <asp:Repeater ID="Repeater2" runat="server">
       <ItemTemplate>
             <ul>
             <li>
              <article>
               <header>
               <h1><u><b><asp:Label ID="lbl_Dept" runat="server" Text='<%# Bind("CourseTitle") %>'></asp:Label></b></u></h1> 
                     
                     <address>
                By Teacher :<a href="#"><asp:Label ID="lbl_Supervisory" runat="server" Text='<%# Eval("UserName") %>'></asp:Label></a>
                     </address>
                  <u>  <time datetime="2045-04-06T08:15+00:00">Open: <asp:Label ID="lbl_Open" runat="server" Text='<%# Eval("CourseOpen") %>'></asp:Label></time>
            <time datetime="2045-04-06T08">Close :<asp:Label ID="lbl_Close" runat="server" Text='<%# Eval("CourseClose") %>'></asp:Label> </time></u>
              </header>
              <div class="comcont">
                  <p><asp:Label ID="lbl_Deptabout" runat="server" Text='<%# Eval("CourseAbout") %>'></asp:Label></p>
                  </div>
                  <div>
              <asp:Button ID="btn_Enroll" runat="server" Text="Details" CommandName="Save"  PostBackUrl='<%# "~/Users/CourseWeek.aspx?Course="+Eval("CourseId") %>' />
                      </div>
            </article> </li> </ul>
       </ItemTemplate>
                 </asp:Repeater> 
         </div></div></div>
</asp:Content>

