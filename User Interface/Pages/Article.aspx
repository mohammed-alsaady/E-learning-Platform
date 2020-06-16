<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMaster.master" AutoEventWireup="true" CodeFile="Article.aspx.cs" Inherits="Pages_Article" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="wrapper row3">
    <div class="content">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <h1><asp:HyperLink ID="hl_title" runat="server" Text='<%# Eval("ArticleTitle") %>' NavigateUrl='<%# "~/Pages/ArticleDetails.aspx?Article="+ Eval("ArticleId") %>'></asp:HyperLink></h1>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <hr />
            </AlternatingItemTemplate>
        </asp:DataList>


        </div>
    </div>
</asp:Content>

