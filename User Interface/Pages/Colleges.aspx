<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMaster.master" AutoEventWireup="true" CodeFile="Colleges.aspx.cs" Inherits="Pages_Colleges" %>

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
               <h1><u><b><asp:Label ID="lbl_Dept" runat="server" Text='<%# Bind("CollegeName") %>'></asp:Label></b></u></h1> 
                     <asp:Image ID="img_Article" runat="server" ImageUrl='<%# Bind ("CollegeLogo") %>' Width="400px" Height="420px" />
                     <address>
                       Location  :<asp:Label ID="lbl_Supervisory" runat="server" Text='<%# Eval("CollegeLocation") %>'></asp:Label>
                         <br />
                         Website :<asp:HyperLink ID="hl_web" runat="server" NavigateUrl='<%# Bind("CollegeWebSite") %>' Text='<%# Bind("CollegeName") %>'></asp:HyperLink>
                     </address>
                  <u>  <time datetime="2045-04-06T08:15+00:00">Establish :<asp:Label ID="lbl_Open" runat="server" Text='<%# Eval("CollegeEstablish") %>'></asp:Label></time></u>
              </header>
              <div class="comcont">
                  <p><asp:Label ID="lbl_Deptabout" runat="server" Text='<%# Eval("CollegeAbout") %>'></asp:Label></p>
                  </div>
                  <div>
                  </div>
            </article> </li> </ul>
       </ItemTemplate>
                 </asp:Repeater> 
         </div></div></div>
</asp:Content>

