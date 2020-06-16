<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMaster.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
        <asp:Login ID="Login1" runat="server" ViewStateMode="Disabled" RenderOuterTable="false" DestinationPageUrl="~/Home.aspx">
            <LayoutTemplate>
                <div>
                <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
                </div>
               <div class="one_half first">
                            <asp:Label ID="Label1" runat="server" AssociatedControlID="UserName">User name</asp:Label>
                            <asp:TextBox runat="server" ID="UserName" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." />
                        </div>
                        <div class="one_half first">
                            <asp:Label ID="Label2" runat="server" AssociatedControlID="Password">Password</asp:Label>
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="The password field is required." />
                      </div>
                        <div class="one_half first">
                         <asp:Label ID="Label3" runat="server" AssociatedControlID="RememberMe">Remember me?</asp:Label>
                          <asp:CheckBox runat="server" ID="RememberMe" />
                           </div>
                    
                <div class="clear">
                    <asp:Button ID="Button1" runat="server" CommandName="Login" Text="Log in" />
                </div>
            </LayoutTemplate>
        </asp:Login>
        <div class="block clear">
              <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" NavigateUrl="~/Pages/Register.aspx">Register</asp:HyperLink>
            if you don't have an account.
                  <br />
                  <asp:HyperLink runat="server" ID="hl_resetpassword" NavigateUrl="~/Pages/RecoveryPassword.aspx">Forget Password</asp:HyperLink>
            if you don't remember a password
        </p>
    </div>
          </div>
          </div>
        </div>
</asp:Content>

