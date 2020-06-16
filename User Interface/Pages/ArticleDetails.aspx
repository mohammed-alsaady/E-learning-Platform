<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMaster.master" AutoEventWireup="true" CodeFile="ArticleDetails.aspx.cs" Inherits="Pages_ArticleDetails" %>

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
               <h1><u><b><asp:Label ID="lbl_Dept" runat="server" Text='<%# Bind("ArticleTitle") %>'></asp:Label></b></u></h1> 
                     <asp:Image ID="img_Article" runat="server" ImageUrl='<%# Bind ("ArticlePhoto") %>' Width="400px" Height="420px" />
                     <address>
                By  :<a href="#"><asp:Label ID="lbl_Supervisory" runat="server" Text='<%# Eval("UserName") %>'></asp:Label></a>
                     </address>
                  <u>  <time datetime="2045-04-06T08:15+00:00">Open: <asp:Label ID="lbl_Open" runat="server" Text='<%# Eval("ArticleDatePublish") %>'></asp:Label></time></u>
              </header>
              <div class="comcont">
                  <p><asp:Label ID="lbl_Deptabout" runat="server" Text='<%# Eval("ArticleDetails") %>'></asp:Label></p>
                  </div>
                  <div>
                  </div>
            </article> </li> </ul>
       </ItemTemplate>
                 </asp:Repeater> 
         </div></div></div>
</asp:Content>

