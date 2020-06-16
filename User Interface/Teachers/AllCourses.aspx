<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/TeacherMaster.master" AutoEventWireup="true" CodeFile="AllCourses.aspx.cs" Inherits="Teachers_AllCourses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <div class="block clear">
             <asp:GridView ID="gv_allCourses" runat="server" AutoGenerateColumns="False" AllowPaging="True">
          <Columns>
         <asp:TemplateField HeaderText="Course Title">
          <ItemTemplate>
              <em><asp:Label ID="lbl_CourseTitle" runat="server" Text='<%# Bind("CourseTitle") %>' ></asp:Label></em>
          </ItemTemplate>
             </asp:TemplateField>
              </Columns>
          </asp:GridView>

         </div>

         </div>
         </div>
        </div>

</asp:Content>

