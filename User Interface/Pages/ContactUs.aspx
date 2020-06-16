<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMaster.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="Pages_ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <div class="one_half first">
         <p>Message Title : </p>
         <asp:TextBox ID="txt_title" runat="server"></asp:TextBox>
         </div> 
         <div class="one_half first">
         <p>Your Email : </p>
         <asp:TextBox ID="txt_Email" runat="server"></asp:TextBox>
         </div> 
         <div class="block clear">
         <p>Your Message : </p>
         <asp:TextBox ID="txt_Body" runat="server" TextMode="MultiLine" Rows="10" Columns="20"></asp:TextBox>
         </div> 
         <div class="clear">
             <asp:RequiredFieldValidator ID="rfv_Title" runat="server" ControlToValidate="txt_title" ForeColor="#CC0000" ValidationGroup="Send">Title Missing</asp:RequiredFieldValidator>
             <br />
             <asp:RequiredFieldValidator ID="rfv_body" runat="server" ControlToValidate="txt_Body" ForeColor="#CC0000" ValidationGroup="Send">Message Missing</asp:RequiredFieldValidator>
             <br />
             <asp:RequiredFieldValidator ID="rfv_email" runat="server" ControlToValidate="txt_Email" ForeColor="#CC0000" ValidationGroup="Send">email missing</asp:RequiredFieldValidator>
             <br />
             <asp:RegularExpressionValidator ID="rev_email" runat="server" ControlToValidate="txt_Email" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Email wrong</asp:RegularExpressionValidator>
             <br />
         </div>
         <div >
             <asp:Label ID="lbl_Msg" runat="server"></asp:Label>
         </div>
         <div>
             <asp:Button ID="btn_Send" runat ="server" Text="Send" ValidationGroup="Send" OnClick="btn_Send_Click" />
         </div>
         </div></div></div>
</asp:Content>

