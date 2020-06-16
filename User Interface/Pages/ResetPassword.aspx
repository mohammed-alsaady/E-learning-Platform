<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMaster.master" AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="Pages_ResetPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="wrapper row3">
  <main class="hoc container clear"> 
    <div class="content">
      <div id="comments">
        
        <h2>Recovery Password :</h2>
          <div class="one_third first">
            <label for="name">Write your Name <span>*</span></label>
              <asp:TextBox ID="txt_NewPassword" runat="server" TextMode="Password" ></asp:TextBox>
          </div>
          <div class="one_third first">
            <label for="name">Confirm Password <span>*</span></label>
              <asp:TextBox ID="txt_ConfirmPassword" runat="server" TextMode="Password" ></asp:TextBox>
          </div>
          <div class="clear">
          <asp:Label ID="lbl_msg" runat="server"></asp:Label>
          </div>
          <div>
              <asp:Button ID="btn_Save" runat="server" Text="Send ..." OnClick="btn_Save_Click1" />
              </div>
          </div>
        </div>
      </main>
      </div>
</asp:Content>

