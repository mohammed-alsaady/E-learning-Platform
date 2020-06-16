<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Administrator.master" AutoEventWireup="true" CodeFile="ContacMessage.aspx.cs" Inherits="Administration_ArticlesSetting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <div class="block clear">
             <asp:Label ID="lbl_Msg" runat="server"></asp:Label>
      <asp:GridView ID="gv_allArticle" runat="server" AutoGenerateColumns="False" AllowPaging="True" >
          <Columns>
         <asp:TemplateField HeaderText="Message Title :">
          <ItemTemplate>
              <asp:Label ID="lbl_ArticleTitle" runat="server" Text='<%# Bind("ContactTitle") %>' ></asp:Label>
          </ItemTemplate>
             </asp:TemplateField>

              <asp:TemplateField HeaderText="From :">
          <ItemTemplate>
              <asp:Label ID="lbl_ArticleBy" runat="server" Text='<%# Bind("ContactEmail") %>' ></asp:Label>
          </ItemTemplate>
             </asp:TemplateField>
               <asp:TemplateField HeaderText="Date :">
          <ItemTemplate>
              <asp:Label ID="lbl_ArticleBy" runat="server" Text='<%# Bind("ContactDate") %>' ></asp:Label>
          </ItemTemplate>
             </asp:TemplateField>
               <asp:TemplateField HeaderText="Message :">
          <ItemTemplate>
              <asp:Label ID="lbl_ArticleBy" runat="server" Text='<%# Bind("ContactBody") %>' ></asp:Label>
          </ItemTemplate>
             </asp:TemplateField>
              </Columns>
          </asp:GridView>
             </div>
         </div>
         </div>
         </div>
    
</asp:Content>

