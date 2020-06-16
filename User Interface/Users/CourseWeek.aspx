<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/UserMaster.master" AutoEventWireup="true" CodeFile="CourseWeek.aspx.cs" Inherits="Users_CourseWeek" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="comments">
        <asp:Label ID="lbl_Test" runat="server" ></asp:Label>
            <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_ItemCommand" OnItemDataBound="Repeater2_ItemDataBound" >
       <ItemTemplate>
             <ul>
             <li>
              <article>
               <header>
               <h1><u><b><asp:Label ID="lbl_CourseTitle" runat="server" Text='<%# "Week No :"+ Eval("WeekNo") %>'></asp:Label></b></u></h1> 
                  <address>
                <a href="#"><asp:Label ID="lbl_Supervisory" runat="server" Text='<%# Eval("WeekTitle") %>'></asp:Label></a>
                     </address>
              </header>
              <div class="comcont">
                  <p><asp:Label ID="lbl_Deptabout" runat="server" Text='<%# Eval("WeekDetails") %>'></asp:Label></p>
                  <asp:HiddenField ID="week" runat="server" Value='<%#Eval("WeekId") %>' />
                  </div>
                  <div>
                      <p>See Video :</p>
                      <asp:Repeater ID="r_Video" runat="server" >
                          <ItemTemplate>
                         <asp:LinkButton ID="lb_files" runat="server" Text='<%# Eval("VideoTitle") %>' PostBackUrl='<%# "~/Users/VideoWeek.aspx?WeekId="+ Eval("WeekId") %>' ></asp:LinkButton>
                       
                          </ItemTemplate>
                      </asp:Repeater>
                  </div>
                  <hr />
                  <div>
                      <p>Download Lectures : <asp:Label ID="lbl_testing" runat="server"></asp:Label></p>
                      <asp:Repeater ID="r_files" runat="server"  >
                          <ItemTemplate>
                            <asp:LinkButton ID="lb_files" runat="server" Text='<%# Bind("LectureTitle") %>' OnCommand="lb_files_Command" CommandArgument='<%# Bind("LecturePath") %>'  CommandName="Download" ></asp:LinkButton>
                          </ItemTemplate>
                          <SeparatorTemplate><br /></SeparatorTemplate>
                      </asp:Repeater>
               </div>
            </article> </li> </ul>
       </ItemTemplate>
                 </asp:Repeater>      
      </div>
</asp:Content>

