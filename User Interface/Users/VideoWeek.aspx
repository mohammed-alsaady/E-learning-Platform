<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/UserMaster.master" AutoEventWireup="true" CodeFile="VideoWeek.aspx.cs" Inherits="Users_VideoWeek" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="comments">
           <asp:Repeater ID="R_Video" runat="server">
            <ItemTemplate>
               <div class="block clear">
                <video width="100%" height="80%" controls="controls">
                 <source src='<%# "/"+ Eval("VideoPath") %>' type="video/mp4" />
                 Your browser does not support the video tag.
               </video>
                   </div>   
            </ItemTemplate>
        </asp:Repeater>
        <h2>Discussing ...</h2>
        
                 <asp:Repeater ID="R_Comments" runat="server" OnItemDataBound="R_Comments_ItemDataBound">
                 <ItemTemplate>
                     <ul>
           <li>
            <article>
              <header>
                   <figure class="avatar"><asp:Image ID="img_User" Width="30" Height="35" runat="server" AlternateText=""/></figure>
                <address>
                By <a href="#"><asp:Label ID="lbl_UserName" runat="server" Text='<%# Eval("UserName") %>'></asp:Label></a>
                </address>
                <time datetime="2045-04-06T08:15+00:00"><asp:Label ID="lbl_DateComment" runat="server" Text='<%# Eval("CommentDate") %>'></asp:Label></time>
              </header>
              <div class="comcont">
               <p><asp:Label ID="lbl_CommentText" runat="server" Text='<%# Eval("CommentText") %>'></asp:Label></p>
                  <asp:HiddenField ID="hf_userid" runat="server" Value='<%# Eval("UserId") %>' />
                    </div>
            </article>
                 </li>
           </ul>
          </ItemTemplate>
          </asp:Repeater>
                
        <h2>Write A Comment</h2>
          <div class="block clear">
            <label for="comment">Your Comment</label>
              <asp:TextBox ID="txt_Comment" runat="server" Columns="25" Rows="10" TextMode="MultiLine"></asp:TextBox>
          </div>
          <div>
              <asp:Label ID="lbl_Message" runat="server"></asp:Label>
          </div>
          <div>
              <asp:Button ID="btn_Save" Text ="Submit" runat="server" OnClick="btn_Save_Click" />
            &nbsp;
              <asp:Button ID="btn_clear" runat="server" Text="Reset Form" OnClick="btn_clear_Click" />
          </div>
                 
      </div>
</asp:Content>

