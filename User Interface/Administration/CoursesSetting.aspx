<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Administrator.master" AutoEventWireup="true" CodeFile="CoursesSetting.aspx.cs" Inherits="Administration_CoursesSetting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <div class="block clear">
             <asp:Label ID="lbl_Msg" runat="server"></asp:Label>
             <asp:GridView ID="gv_AllCourse" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnRowCommand="gv_AllCourse_RowCommand">
                 <Columns>
                     <asp:TemplateField HeaderText="Course Title :">
          <ItemTemplate>
              <asp:Label ID="lbl_CourseTitle" runat="server" Text='<%# Bind("CourseTitle") %>' > </asp:Label>
          </ItemTemplate>
             </asp:TemplateField>
                     <asp:TemplateField HeaderText="By Teacher :">
          <ItemTemplate>
              <asp:Label ID="lbl_CourseUserName" runat="server" Text='<%# Bind("UserName") %>' ></asp:Label>
          </ItemTemplate>
             </asp:TemplateField>
                     <asp:TemplateField HeaderText="Action">
          <ItemTemplate>
              <asp:LinkButton ID="lbtn_AgreeCourse" runat="server" CommandName="Accept" CommandArgument='<%# Bind("CourseId") %>'>Agree</asp:LinkButton>
          </ItemTemplate>
             </asp:TemplateField>
                 </Columns>
             </asp:GridView>

             </div>
         </div>
         </div>
        </div>
</asp:Content>

