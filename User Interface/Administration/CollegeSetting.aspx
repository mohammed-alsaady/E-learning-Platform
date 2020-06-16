<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Administrator.master" AutoEventWireup="true" CodeFile="CollegeSetting.aspx.cs" Inherits="Administration_CollegeSetting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <div>
             <asp:Button ID="Button2" runat="server" Text="New" OnClick="Button2_Click" />
             <asp:Button ID="Button3" runat="server" Text="Edit" OnClick="Button3_Click" />
             <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />
         </div>
         <div class="block clear">
         <asp:MultiView ID="MultiView1" runat="server">
             <asp:View ID="View1" runat="server">
                 <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" HeaderText="---New ----" HeaderStyle-BackColor="#00BCDF" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
                 <StepPreviousButtonStyle Width="20%" />
                 <SideBarStyle Width="20%" />
                 <StartNavigationTemplate>
                     <asp:Button ID="StartNextButton" runat="server" CommandName="MoveNext" Text="Next" />
                 </StartNavigationTemplate>
                 <WizardSteps>
                     <asp:WizardStep ID="WizardStep1" runat="server" Title="College :">College Name :<br />
                         <asp:TextBox ID="txt_NewcollegeTitle" runat="server"></asp:TextBox>
                         <br />
                         College Establish :<br />
                         <asp:TextBox ID="txt_NewCollegeEstablish" runat="server" TextMode="Date"></asp:TextBox>
                         <br />
                         College Logo :<br />
                         <asp:FileUpload ID="fu_NewCollegeLogo" runat="server" />
                         <br />
                         College Address :<asp:TextBox ID="txt_NewCollegeAddress" runat="server"></asp:TextBox>
                         <br />
                         College Website :<asp:TextBox ID="txt_NewCollegeWebsite" runat="server"></asp:TextBox>
                         <br />
                         Show in Home Page:<br />
                         <asp:CheckBox ID="cb_NewCollegeShow" runat="server" TextAlign="Left" />
                         <br />
                         <br />
                         College About :<br />
                         <asp:TextBox ID="txt_NewCollegeAbout" runat="server" Rows="15" TextMode="MultiLine"></asp:TextBox>
                         <br />
                         <asp:Label ID="lbl_NewCollege" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                         <br />
                         <asp:Button ID="btn_NewCollegeSave" runat="server" Text="Add ..." OnClick="btn_NewCollegeSave_Click" />
                     </asp:WizardStep>
                     <asp:WizardStep ID="WizardStep2" runat="server" Title="Department :">Select College:
                         <asp:DropDownList ID="ddl_NewDepartmentCollege" runat="server" >
                         </asp:DropDownList>
                         <br />
                         Department Title :<asp:TextBox ID="txt_NewDepartmentTitle" runat="server"></asp:TextBox>
                         <br />
                         About :<br />
                         <asp:TextBox ID="txt_NewDepartmentAbout" runat="server" Rows="10" TextMode="MultiLine"></asp:TextBox>
                         <br />
                         <asp:Label ID="lbl_NewDepartment" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                         <br />
                         <asp:Button ID="btn_NewDepartmentSave" runat="server" OnClick="btn_NewDepartmentSave_Click" Text="Add..." />
                     </asp:WizardStep>
                     <asp:WizardStep ID="WizardStep3" runat="server" Title="Subjects :">Select College :<asp:DropDownList ID="ddl_NewFieldCollege" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_NewFieldCollege_SelectedIndexChanged">
                         </asp:DropDownList>
                         <br />
                         Select Department:<asp:DropDownList ID="ddl_NewFieldDepartment" runat="server">
                         </asp:DropDownList>
                         <hr />
                         <br />
                         Subject Title :<asp:TextBox ID="txt_NewFieldTitle" runat="server"></asp:TextBox>
                         <br />
                         Subject About :<br />
                         <asp:TextBox ID="txt_NewFieldAbout" runat="server" Rows="10" TextMode="MultiLine"></asp:TextBox>
                         <br />
                         <asp:Label ID="lbl_NewField" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                         <br />
                         <asp:Button ID="btn_NewFieldSave" runat="server" Text="Add ..." OnClick="btn_NewFieldSave_Click" />
                         <br />
                         
                     </asp:WizardStep>
                 </WizardSteps>
             </asp:Wizard>
             </asp:View>
             <asp:View runat="server" ID="Edit">

                 <asp:Wizard ID="Wizard2" runat="server" ActiveStepIndex="2" HeaderText="---Update---" HeaderStyle-BackColor="#00BCDF" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
                     <StepPreviousButtonStyle Width="20%" />
                     <SideBarStyle Width="20%" />
                     <StartNavigationTemplate>
                         <asp:Button ID="StartNextButton0" runat="server" CommandName="MoveNext" Text="Next" />
                     </StartNavigationTemplate>
                     <WizardSteps>
                         <asp:WizardStep ID="WizardStep4" runat="server" Title="College :">
                             Select College :<br />
                             <asp:DropDownList ID="ddl_ModifyCollege" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_ModifyCollege_SelectedIndexChanged">
                             </asp:DropDownList>
                             <br />
                             <hr />
                             <br />
                             College Name :<br />
                             <asp:TextBox ID="txt_ModifyCollgeTitle" runat="server"></asp:TextBox>
                             <br />
                             College Establish :<br />
                             <asp:TextBox ID="txt_ModifyCollegeEstablish" runat="server" TextMode="Date"></asp:TextBox>
                             <br />
                             College Logo :<br />
                             <asp:FileUpload ID="fu_ModifyCollegeLogo" runat="server" />
                             <br />
                             College Address :<asp:TextBox ID="txt_ModifyCollgeAddress" runat="server"></asp:TextBox>
                             <br />
                             College Website :<asp:TextBox ID="txt_ModifyCollegeWebsite" runat="server"></asp:TextBox>
                             <br />
                             Show in Home Page :<br />
                             <asp:CheckBox ID="cb_Modify" runat="server" />
                             <br />
                             College About :<br />
                             <asp:TextBox ID="txt_ModifyCollegeAbout" runat="server" Rows="15" TextMode="MultiLine"></asp:TextBox>
                             <br />
                             <asp:Button ID="btn_ModifyCollege" runat="server" Text="Modify..." OnClick="btn_ModifyCollege_Click" />
                         </asp:WizardStep>
                         <asp:WizardStep ID="WizardStep5" runat="server" Title="Department :">
                             Select Department :<asp:DropDownList ID="ddl_ModufyDepartment" runat="server">
                             </asp:DropDownList>
&nbsp;<br />
                             <hr />
                             <br />
                             Department Title :<asp:TextBox ID="txt_ModifyDeptTitle" runat="server"></asp:TextBox>
                             <br />
                             About :<br />
                             <asp:TextBox ID="txt_ModifyDeptAbout" runat="server" Rows="10" TextMode="MultiLine"></asp:TextBox>
                             <br />
                             <asp:Label ID="lbl_ModifyDept" runat="server" ForeColor="Red"></asp:Label>
                             <br />
                             <asp:Button ID="btn_ModifyDepartment" runat="server" Text="Save" OnClick="btn_ModifyDepartment_Click" />
                         </asp:WizardStep>
                         <asp:WizardStep ID="WizardStep6" runat="server" Title="Subjects :">
                             Select Subject :<asp:DropDownList ID="ddl_ModifyField" runat="server">
                             </asp:DropDownList>
                             <br />
                             <hr />
                             <br />
                             Subject Title :<asp:TextBox ID="txt_ModifyFieldTitle" runat="server"></asp:TextBox>
                             <br />
                             Subject About:<br />
                             <asp:TextBox ID="txt_ModifyFieldAbout" runat="server" Rows="10" TextMode="MultiLine"></asp:TextBox>
                             <br />
                             <br />
                             <asp:Label ID="lbl_ModifyField" runat="server" Font-Bold="True"></asp:Label>
                             <br />
                             <br />
                             <asp:Button ID="btn_ModifyField" runat="server" Text="Modify" OnClick="btn_UpdateCollege_Click" />
                         </asp:WizardStep>
                     </WizardSteps>
                 </asp:Wizard>

             </asp:View>
             <asp:View ID="Delete" runat="server">

                 <asp:Wizard ID="Wizard3" runat="server" ActiveStepIndex="2" HeaderText="---Delete---" HeaderStyle-BackColor="#00BCDF" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
                     
                     <StepPreviousButtonStyle Width="20%" />
                     <SideBarStyle Width="20%" />
                     <StartNavigationTemplate>
                         <asp:Button ID="StartNextButton1" runat="server" CommandName="MoveNext" Text="Next" />
                     </StartNavigationTemplate>
                     <WizardSteps>
                         <asp:WizardStep ID="WizardStep7" runat="server" Title="College :">
                             Select College :<br />
                             <asp:DropDownList ID="ddl_DeleteCollege" runat="server">
                             </asp:DropDownList>
                             <br />
                             <hr />
                             <br />
                             <asp:Button ID="btn_DeleteCollege" runat="server" Text="Delete..." OnClick="btn_DeleteCollege_Click" />
                         </asp:WizardStep>
                         <asp:WizardStep ID="WizardStep8" runat="server" Title="Department :">
                             Select Department :<asp:DropDownList ID="ddl_DeleteDept" runat="server">
                             </asp:DropDownList>
                             &nbsp;<br />
                             <hr />
                             <br />
                             <asp:Label ID="lbl_DeleteDept" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                             <br />
                             <asp:Button ID="btn_DeleteDept" runat="server" Text="Delete..." OnClick="btn_DeleteDept_Click" />
                         </asp:WizardStep>
                         <asp:WizardStep ID="WizardStep9" runat="server" Title="Subjects :">
                             Select Subject :<asp:DropDownList ID="ddl_DeleteField" runat="server">
                             </asp:DropDownList>
                             <br />
                             <hr />
                             <br />
                             <asp:Label ID="lbl_DeleteField" runat="server"></asp:Label>
                             <br />
                             <br />
                             <asp:Button ID="btn_DeleteField" runat="server" Text="Delete" OnClick="btn_DeleteField_Click" />
                         </asp:WizardStep>
                     </WizardSteps>
                 </asp:Wizard>

             </asp:View>
         </asp:MultiView>
             </div>
         </div>
         </div>
        </div>
</asp:Content>

