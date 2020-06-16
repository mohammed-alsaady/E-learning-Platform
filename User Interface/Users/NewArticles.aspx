<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/UserMaster.master" AutoEventWireup="true" CodeFile="NewArticles.aspx.cs" Inherits="Users_NewArticles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
    <div class="content">
      <div id="comments">
          <div class="one_half first">
            <label for="name">Title <span>*</span></label>
              <asp:TextBox ID="txt_Title" runat="server" ></asp:TextBox>
          </div>
          <div class="one_half">
            <label for="email">Photo For Article <span>*</span></label>
              <asp:FileUpload ID="fu_Article" runat="server" />
          </div>
          <div class="block clear">
            <label for="comment">Details Of Article</label>
              <asp:TextBox ID="txt_Details" runat="server" Columns="25" Rows="20" TextMode="MultiLine"></asp:TextBox>
          </div>
          <div>
              <asp:Label ID="lbl_Message" runat="server"></asp:Label>
          </div>
          <div>
              <asp:Button ID="btn_Save" runat="server" Text="Send ..." OnClick="btn_Save_Click" />
            &nbsp;
              <asp:Button ID="btn_Clear" runat="server" Text="Clear ..." />
          </div>
        
      </div>
    </div>
</div>
</asp:Content>

