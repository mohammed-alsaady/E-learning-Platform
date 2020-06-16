<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/TeacherMaster.master" AutoEventWireup="true" CodeFile="NewCourseWeek.aspx.cs" Inherits="Teachers_NewCourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <div class="block clear">
             <p> Select Your Course :</p>
             <asp:DropDownList ID="ddl_Course" runat="server"></asp:DropDownList>
         </div>
         <div class="one_third first">
             <p>Week Number  :</p>
             <asp:TextBox ID="txt_weekno" runat="server" ></asp:TextBox>
         </div>
         <div class="block clear">
             <p>Week Title :</p>
             <asp:TextBox ID="txt_WeekTitle" runat="server"></asp:TextBox>
         </div>
         <div class="block clear">
             <p>Week Details :</p>
             <asp:TextBox ID="txt_weekdetails" runat="server" TextMode="MultiLine" Rows="10" Columns="25"></asp:TextBox>
         </div>
         <div class="clear"></div>
         <div><asp:Label ID="lbl_Msg" runat="server"></asp:Label></div>
         <div>
             <asp:Button ID="btn_Save" runat="server" Text="New Week" OnClick="btn_Save_Click"  /> &nbsp;
         </div>
         </div>
        </div>
    </div>
</asp:Content>

