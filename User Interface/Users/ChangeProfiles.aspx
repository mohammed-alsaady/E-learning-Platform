<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/UserMaster.master" AutoEventWireup="true" CodeFile="ChangeProfiles.aspx.cs" Inherits="Users_Profiles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
      <div class="one_third first">
          <p>Address :</p>
          <asp:TextBox ID="txt_Address" runat="server"></asp:TextBox>
      </div>
         <div class="one_third">
             <p>Birth :</p>
             <asp:TextBox ID="txt_Birth" runat="server" TextMode="Date"></asp:TextBox>
             </div>
         <div class="one_third">
            <p>Website :</p>
             <asp:TextBox ID="txt_Website" runat="server" TextMode="Url"></asp:TextBox>  
         </div>
         <div class="one_half first">
             <p>Educational :</p>
             <asp:DropDownList ID="ddl_Educational" runat="server">
                    <asp:ListItem>Less than high school diploma</asp:ListItem>
                    <asp:ListItem>High school diploma</asp:ListItem>
                    <asp:ListItem>Some College but not Degree</asp:ListItem>
                    <asp:ListItem>Associate Degree</asp:ListItem>
                    <asp:ListItem>Bachelors</asp:ListItem>
                </asp:DropDownList>
         </div>
         <div class="one_half">
             <p>Your Picture :</p>
             <asp:FileUpload ID="fu_Picture" runat="server" />
         </div>
         <div class="clear">
             <div class="block clear">
                 <p>About You</p>
                 <asp:TextBox ID="txt_About" runat="server" Rows="10" Columns="25" TextMode="MultiLine"></asp:TextBox>
             </div>
             <div class="clear">
                 <asp:Label ID="lbl_Msg" runat="server"></asp:Label>
             </div>
             <div>
                 <asp:Button ID="btn_Changeprofile" runat="server" Text ="Change Profile" OnClick="btn_Changeprofile_Click" />
             </div>
         </div>
         </div>
         </div>
        </div>
</asp:Content>

