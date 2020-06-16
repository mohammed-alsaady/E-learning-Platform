<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Administrator.master" AutoEventWireup="true" CodeFile="ArticlesSetting.aspx.cs" Inherits="Administration_ArticlesSetting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <div class="block clear">
             <asp:Label ID="lbl_Msg" runat="server"></asp:Label>
      <asp:GridView ID="gv_allArticle" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnRowCommand="gv_allArticle_RowCommand">
          <Columns>
         <asp:TemplateField HeaderText="Article Title :">
          <ItemTemplate>
              <asp:Label ID="lbl_ArticleTitle" runat="server" Text='<%# Bind("ArticleTitle") %>' ></asp:Label>
          </ItemTemplate>
             </asp:TemplateField>

              <asp:TemplateField HeaderText="Article By :">
          <ItemTemplate>
              <asp:Label ID="lbl_ArticleBy" runat="server" Text='<%# Bind("UserName") %>' ></asp:Label>
          </ItemTemplate>
             </asp:TemplateField>

                <asp:TemplateField HeaderText="Acceptance? ">
          <ItemTemplate>
              <asp:LinkButton ID="lbl_Accept" runat="server" Text="Agree" CommandName="Accept" CommandArgument='<%# Bind("ArticleId") %>'></asp:LinkButton>
          </ItemTemplate>
             </asp:TemplateField>
              </Columns>
          </asp:GridView>
             </div>
         </div>
         </div>
         </div>
    
</asp:Content>

