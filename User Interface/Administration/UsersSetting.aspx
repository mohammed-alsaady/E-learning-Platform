<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Administrator.master" AutoEventWireup="true" CodeFile="UsersSetting.aspx.cs" Inherits="Administration_UsersSetting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
     <div class="content"> 
     <div id="comments">
         <div>
             <asp:Button ID="btn_Users" runat="server" Text="Students" OnClick="btn_Users_Click" />
             <asp:Button ID="btn_Teachers" runat="server" Text="Teachers" OnClick="btn_Teachers_Click" />
             <asp:Button ID="btn_Administrator" runat="server" Text="Administrators" OnClick="btn_Administrator_Click" />
         </div>
        <div class="block clear">
         <asp:MultiView ID="MultiView1" runat="server">
             <asp:View ID="View1" runat="server">
                 <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" HeaderText="---Students ----" HeaderStyle-BackColor="#00BCDF" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
                     <SideBarStyle Width="20%" />
                     <WizardSteps>
                         <asp:WizardStep ID="WizardStep1" runat="server" Title="All Student">
                                <asp:GridView ID="gv_allUsers" runat="server" AutoGenerateColumns="False" AllowPaging="True">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Student Name :">
                                            <ItemTemplate>
                                            <asp:Label ID="lbl_UserName" runat="server" Text='<%# Bind("UserName") %>' ></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Student Email :">
                                            <ItemTemplate>
                                            <asp:Label ID="lbl_UserEmail" runat="server" Text='<%# Bind("Email") %>' ></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Create Date :">
                                            <ItemTemplate>
                                            <asp:Label ID="lbl_UserEmail" runat="server" Text='<%# Bind("CreateDate") %>' ></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Last Login :">
                                            <ItemTemplate>
                                            <asp:Label ID="lbl_UserEmail" runat="server" Text='<%# Bind("LastLogin") %>' ></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            
                         </asp:WizardStep>
                         <asp:WizardStep ID="WizardStep2" runat="server" Title="Security" >
                             <div class="one_third first" >
                                 <asp:TextBox ID="txt_RemoveSearch" runat="server"></asp:TextBox>
                             </div>
                             <div class="one_third">
                                 <asp:Button ID="btn_RemoveSearch" runat="server" Text="Search..." OnClick="btn_RemoveSearch_Click" />
                             </div>
                             <div>
                             </div>
                               <hr />
                             <div class="block clear">
                                 <asp:GridView ID="gv_RemoveUser" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnRowCommand="gv_RemoveUser_RowCommand">
                                     <Columns>
                                         <asp:TemplateField HeaderText="Student Name :">
                                            <ItemTemplate>
                                            <asp:Label ID="lbl_UserName" runat="server" Text='<%# Bind("UserName") %>' ></asp:Label>
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                         <asp:TemplateField>
                                             <ItemTemplate>
                                                 <asp:LinkButton ID="lbtn_RemoveUser" runat="server" Text="Remove" CommandName="Remove" CommandArgument='<%# Bind("UserId") %>' OnClientClick="return confirm('Do you really want to remove?');"></asp:LinkButton>
                                             </ItemTemplate>
                                         </asp:TemplateField>
                                         <asp:TemplateField>
                                             <ItemTemplate>
                                                 <asp:LinkButton ID="lbtn_Block" runat="server" Text="Block" CommandName="Block" CommandArgument='<%# Bind("UserId") %>' OnClientClick="return confirm('Do you really want to block?');"></asp:LinkButton>
                                             </ItemTemplate>
                                         </asp:TemplateField>
                                     </Columns>
                                 </asp:GridView>
                                 </div>
                         </asp:WizardStep>
                          
                     </WizardSteps>
                 </asp:Wizard>
                 </asp:View>
             <asp:View ID="View2" runat="server">
                 <asp:Wizard ID="Wizard2" runat="server" ActiveStepIndex="0" HeaderText="---Teachers ----" HeaderStyle-BackColor="#00BCDF" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
                     <SideBarStyle Width="20%" />
                     <WizardSteps>
                         <asp:WizardStep ID="WizardStep5" runat="server" Title="All Teachers">

                             <asp:ListBox ID="lb_AllTeacher" runat="server">

                             </asp:ListBox>
                         </asp:WizardStep>
                          <asp:WizardStep ID="WizardStep6" runat="server" Title="Security"> 
                              <div class="one_third first">
                                  <asp:ListBox ID="lb_Allusers" runat="server"></asp:ListBox>
                              </div>
                              <div class="one_third">
                                  <asp:Button ID="btn_AddTeacher" runat="server" Text=">>>>" OnClick="btn_AddTeacher_Click" />
                                  <br />
                                  <asp:Button ID="btn_removeteacher" runat="server" Text="<<<<" OnClick="btn_removeteacher_Click"  />

                              </div>
                              <div class="one_third">
                                   <asp:ListBox ID="lb_AllTeachers" runat="server"></asp:ListBox>
                              </div>
                          </asp:WizardStep>
                         
                         </WizardSteps>
                     </asp:Wizard>
                 </asp:View>
             <asp:View ID="View3" runat="server">
                 <asp:Wizard ID="Wizard3" runat="server" ActiveStepIndex="0" HeaderText="---Administrators ----" HeaderStyle-BackColor="#00BCDF" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
                     <SideBarStyle Width="20%" />
                     <WizardSteps>
                         <asp:WizardStep ID="WizardStep7" runat="server" Title="All">
                             <asp:ListBox ID="lb_AllAdministrators" runat="server"></asp:ListBox>
                         </asp:WizardStep>
                         <asp:WizardStep ID="WizardStep8" runat="server" Title="Security">
                             <div class="one_third first">
                                 <asp:ListBox ID="lb_AllUserAdmin" runat="server"></asp:ListBox>
                             </div>
                             <div class="one_third">
                                 <asp:Button ID="btn_AddAdmin" runat="server"  Text="&gt;&gt;&gt;&gt;" OnClick="btn_AddAdmin_Click" />
                                 <br />
                                 <asp:Button ID="btn_removeAdmin" runat="server"  Text="&lt;&lt;&lt;&lt;" OnClick="btn_removeAdmin_Click" />
                             </div>
                             <div class="one_third">
                                 <asp:ListBox ID="lb_AllAdministratorNew" runat="server"></asp:ListBox>
                             </div>
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

