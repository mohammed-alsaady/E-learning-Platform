<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/TeacherMaster.master" AutoEventWireup="true" CodeFile="NewLecture.aspx.cs" Inherits="Teachers_NewCourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <div class="one_third first">
             <p> Select Course :</p>
             <asp:DropDownList ID="ddl_Course" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_Course_SelectedIndexChanged"></asp:DropDownList>
         </div>
         <div class="one_third">
             <p>Select Week </p>
             <asp:DropDownList ID="ddl_Week" runat="server"></asp:DropDownList>
         </div>
         <div class="block clear">
             <p>Lecture Title :</p>
             <asp:TextBox ID="txt_title" runat="server" ></asp:TextBox>
         </div>
         <div class="one_third first">
             <p>Lecture Path :</p>
             <asp:FileUpload ID="fu_Lecture" runat="server" />
         </div>
         
         
         <div class="clear"></div>
         <div><asp:Label ID="lbl_Msg" runat="server"></asp:Label></div>
         <div>
             <asp:Button ID="btn_Save" runat="server" Text="New Video" OnClick="btn_Save_Click" /> &nbsp;
         </div>
         </div>
        </div>
    </div>
</asp:Content>

