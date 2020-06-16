<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/CoursesMaster.master" AutoEventWireup="true" CodeFile="ShowCourses.aspx.cs" Inherits="Pages_ShowCourses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="content three_quarter">
      <div id="comments">
          <div class="one_third first">
               <asp:Label ID="lbl_Departmentselect" runat ="server" Text="Select Department :"></asp:Label>
             <asp:DropDownList ID="ddl_Department" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_Department_SelectedIndexChanged" >
        </asp:DropDownList>
        
              </div>
          <div class="one_third">
               <asp:Label ID="lbl_Field" runat ="server" Text="Select Field :"></asp:Label>
               <asp:DropDownList ID="ddl_Field" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_Field_SelectedIndexChanged">
        </asp:DropDownList>
        
              </div>
            <div class="clear"></div>
            <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_ItemCommand" >
       <ItemTemplate>
             <ul>
             <li>
              <article>
               <header>
               <h1><u><b><asp:Label ID="lbl_Dept" runat="server" Text='<%# Eval("CourseTitle") %>'></asp:Label></b></u></h1> 
                     
                     <address>
                By Teacher :<a href="#"><asp:Label ID="lbl_Supervisory" runat="server" Text='<%# Eval("UserName") %>'></asp:Label></a>
                     </address>
                  <u>  <time datetime="2045-04-06T08:15+00:00">Open: <asp:Label ID="lbl_Open" runat="server" Text='<%# Eval("CourseOpen") %>'></asp:Label></time>
            <time datetime="2045-04-06T08">Close :<asp:Label ID="lbl_Close" runat="server" Text='<%# Eval("CourseClose") %>'></asp:Label> </time></u>
              </header>
              <div class="comcont">
                  <p><asp:Label ID="lbl_Deptabout" runat="server" Text='<%# Eval("CourseAbout") %>'></asp:Label></p>
                  </div>
                  <div>
              <asp:Button ID="btn_Enroll" runat="server" Text="Enroll" CommandName="Join" CommandArgument ='<%# Eval("CourseId") %>' />
                      </div>
            </article> </li> </ul>
       </ItemTemplate>
                 </asp:Repeater>
        
            
          
            
         
         
      </div>
    </div>
</asp:Content>

