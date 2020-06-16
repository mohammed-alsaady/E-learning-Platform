<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/UserMaster.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Users_ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
      <div class="one_third first">
          <p>Old Password :</p>
          <asp:TextBox ID="txt_Oldpassword" runat="server" TextMode="Password"></asp:TextBox>
          </div>
         <div class="clear">
             <hr />
         </div>
         <div class="one_third first">
             <p>New Password :</p>
             <asp:TextBox ID="txt_NewPassword" runat="server" TextMode="Password"></asp:TextBox>
         </div>
         <div class="one_third first">
             <p>Confirm New Password :</p>
             <asp:TextBox ID="txt_confirmpassword" runat="server" TextMode="Password"></asp:TextBox>
         </div>
         <div class="clear">
         </div>
         <div >
             <asp:RequiredFieldValidator ID="rfv_OldPassword" runat="server" ControlToValidate="txt_Oldpassword" Display="Dynamic" ForeColor="Red" ValidationGroup="Change">Old Password</asp:RequiredFieldValidator>
             <br />
             <asp:RequiredFieldValidator ID="rfv_NewPassword" runat="server" ControlToValidate="txt_NewPassword" Display="Dynamic" ForeColor="Red" ValidationGroup="Change">New Password</asp:RequiredFieldValidator>
             <br />
             <asp:CompareValidator ID="cv_Password" runat="server" ControlToCompare="txt_NewPassword" ControlToValidate="txt_confirmpassword" Display="Dynamic" ForeColor="Red" ValueToCompare="Change">Password non matching</asp:CompareValidator>
             <br />
             <asp:Label ID="lbl_Msg" runat="server" ForeColor="Red"></asp:Label>
         </div>
         <div>
             <asp:Button ID="btn_ChangePassword" runat="server" Text="Change Password" OnClick="btn_ChangePassword_Click" ValidationGroup="Change" />
         </div>
     </div></div></div>
</asp:Content>

