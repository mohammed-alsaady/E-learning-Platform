<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/UserMaster.master" AutoEventWireup="true" CodeFile="ShowProfile.aspx.cs" Inherits="Users_ShowProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
    <div class="content"> 
      <!-- ################################################################################################ -->
      <h1><asp:Label ID="lbl_UserName" runat="server" Text=""></asp:Label></h1>
       <asp:Image ID="photo" runat="server" Width="30%" Height="40%" CssClass="imgl borderedbox inspace-5"></asp:Image>
     <p><asp:Label ID="lbl_Age" runat="server" Text=""></asp:Label></p>
        <p><asp:Label ID="lbl_Location" runat="server" Text=""><i class="fa fa-map-marker" aria-hidden="true"></i></asp:Label></p>
        <span><asp:Label ID="lbl_Education" runat="server" Text=""></asp:Label></span>
      <p> Find Me Here : <asp:HyperLink ID="hl_website" runat="server"></asp:HyperLink></p>
   <p></p>
        <hr />
       
      <div id="comments">
        <h2>About me ...</h2>
        <ul>
          <li>
            <article>
             
              <div class="comcont">
                  <p><asp:Label ID="lbl_About" runat="server" Text="" style="word-wrap:break-word;" ></asp:Label></p>
                </div>
            </article>
          </li>
          
        </ul>
        
      </div>
      <!-- ################################################################################################ -->
    </div>
    <!-- ################################################################################################ -->
    <!-- / main body -->
    <div class="clear"></div>
 
</div>
</asp:Content>

