<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/TeacherMaster.master" AutoEventWireup="true" CodeFile="CourseRequest.aspx.cs" Inherits="Teachers_AllCourses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <div class="block clear">
             <asp:GridView ID="gv_allCourses" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnRowCommand="gv_allCourses_RowCommand">
          <Columns>
         <asp:TemplateField HeaderText="Course Title">
          <ItemTemplate>
              <em><asp:Label ID="lbl_CourseTitle" runat="server" Text='<%# Bind("CourseTitle") %>' ></asp:Label></em>
          </ItemTemplate>
             </asp:TemplateField>
              <asp:TemplateField HeaderText="Student">
          <ItemTemplate>
              <em><asp:Label ID="lbl_username" runat="server" Text='<%# Bind("UserName") %>' ></asp:Label></em>
          </ItemTemplate>
             </asp:TemplateField>
              <asp:TemplateField HeaderText="Action">
          <ItemTemplate>
              <asp:LinkButton ID="lbtn_Accept" runat="server" Text="Agree"  CommandName="Accept" CommandArgument='<%# Bind("JoinId") %>'></asp:LinkButton>
          </ItemTemplate>
             </asp:TemplateField>
              </Columns>
          </asp:GridView>

         </div>

         </div>
         </div>
        </div>

</asp:Content>

