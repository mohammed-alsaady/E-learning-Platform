<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMaster.master" AutoEventWireup="true" CodeFile="RecoveryPassword.aspx.cs" Inherits="Pages_RecoveryPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <h2>Recovery Password :</h2>
          <div class="one_third first">
            <label for="name">Write your Name <span>*</span></label>
              <asp:TextBox ID="txt_username" runat="server" ></asp:TextBox>
          </div>
          <asp:Label ID="lbl_msg" runat="server"></asp:Label>
          <div class="clear"></div>
          <div>
              <asp:Button ID="btn_Save" runat="server" Text="Send ..." OnClick="btn_Save_Click" />
              </div>
         </div></div></div>
</asp:Content>

