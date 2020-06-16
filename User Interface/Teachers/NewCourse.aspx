<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/TeacherMaster.master" AutoEventWireup="true" CodeFile="NewCourse.aspx.cs" Inherits="Teachers_NewCourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <div class="one_third first">
             <p> Select Field :</p>
             <asp:DropDownList ID="ddl_Subject" runat="server"></asp:DropDownList>
         </div>
         <div class="one_third">
             <p>Course Start :</p>
             <asp:TextBox ID="txt_open" runat="server" TextMode="Date"></asp:TextBox>
         </div>
         <div class="one_third">
             <p>Course Finish :</p>
             <asp:TextBox ID="txt_Close" runat="server" TextMode="Date"></asp:TextBox>
         </div>
         <div class="block clear">
             <p>Course Title :</p>
             <asp:TextBox ID="txt_CourseTitle" runat="server"></asp:TextBox>
         </div>
         <div class="block clear">
             <p>Course About :</p>
             <asp:TextBox ID="txt_About" runat="server" TextMode="MultiLine" Rows="10" Columns="25"></asp:TextBox>
         </div>
         <div class="clear"></div>
         <div><asp:Label ID="lbl_Msg" runat="server"></asp:Label></div>
         <div>
             <asp:Button ID="btn_Save" runat="server" Text="New Course" OnClick="btn_Save_Click" /> &nbsp;
         </div>
         </div>
        </div>
    </div>
</asp:Content>

