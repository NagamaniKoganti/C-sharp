<%@ Page Title="" Language="C#" MasterPageFile="~/AnonymousSite.Master" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="SellersGateWay.Registeration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Example to customise create user wizard control
        https://msdn.microsoft.com/en-us/library/ms178342%28v=vs.140%29.aspx
        -->
        <asp:Wizard ID="WizardRegister" runat="server" style="display:inline">
            
            <WizardSteps> 
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Choose Your mail Id">
                      <div class="Reg-Outer-Wrap">
                            <div class="Reg-In-wrap">
                            <div class="Reg-In-label"><asp:Label ID="lblFirstName" runat="server"  Text="First Name"></asp:Label></div>
                            <div class="Reg-Out-text"><asp:TextBox ID="txtFirstName" runat="server" ></asp:TextBox></div>
                            <div class="Reg-Val-1"><asp:RequiredFieldValidator ID="RequiredFirstName" runat="server" ControlToValidate="txtFirstName"  ErrorMessage="Please enter your First Name"></asp:RequiredFieldValidator></div>
                            </div>
                            <div class="Reg-In-wrap">
                            <div class="Reg-In-label"><asp:Label ID="lblLastName" runat="server"  Text="Last Name"></asp:Label></div>
                            <div class="Reg-Out-text"><asp:TextBox ID="txtLastName" runat="server" ></asp:TextBox></div>
                            <div class="Reg-Val-1"><asp:RequiredFieldValidator ID="RequiredLastName" runat="server" ControlToValidate="txtLastName"  ErrorMessage="Please enter your Last Name"></asp:RequiredFieldValidator></div>
                            </div>
                            <div class="Reg-In-wrap">
                            <div class="Reg-In-label"><asp:Label ID="lblPass" runat="server"  Text="Enter Passsword"></asp:Label></div>
                            <div class="Reg-Out-text"><asp:TextBox ID="TxtPassword" runat="server" ></asp:TextBox></div>
                            <div class="Reg-Val-1"><asp:RequiredFieldValidator ID="RequiredPass" runat="server" ControlToValidate="TxtPassword"  ErrorMessage="Please enter Your Password"></asp:RequiredFieldValidator></div>
                            </div>
                            <div class="Reg-In-wrap">
                            <div class="Reg-In-label"><asp:Label ID="lblRePass" runat="server"  Text="Re-Enter Password"></asp:Label></div>
                            <div class="Reg-Out-text"><asp:TextBox ID="TxtRePass" runat="server" ></asp:TextBox></div>
                            <div class="Reg-Val-1"><asp:RequiredFieldValidator ID="RequiredRePass" runat="server" ControlToValidate="TxtRePass"  ErrorMessage="Please Re enter your Password"></asp:RequiredFieldValidator></div>
                            </div>
                      </div>
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" Title="Enter Your Busines Deatils">
                    <div class="Reg-Outer-Wrap">
                            <div class="Reg-In-wrap">
                            <div class="Reg-In-label"><asp:Label ID="lblBusinessName" runat="server"  Text="Your Business name"></asp:Label></div>
                            <div class="Reg-Out-text"><asp:TextBox ID="TxtBusiname" runat="server" ></asp:TextBox></div>
                            <div class="Reg-Val-1"><asp:RequiredFieldValidator ID="RequiredBusinessName" runat="server" ControlToValidate="TxtBusiname"  ErrorMessage="Please enter your E-Mail Id"></asp:RequiredFieldValidator></div>
                            </div>
                            <div class="Reg-In-wrap">
                            <div class="Reg-In-label"><asp:Label ID="lbl" runat="server"  Text="Address"></asp:Label></div>
                            <div class="Reg-Out-text"><asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox></div>
                            <div class="Reg-Val-1"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName"  ErrorMessage="Please enter your First Name"></asp:RequiredFieldValidator></div>
                            </div>
                            <div class="Reg-In-wrap">
                            <div class="Reg-In-label"><asp:Label ID="Label2" runat="server"  Text="Last Name"></asp:Label></div>
                            <div class="Reg-Out-text"><asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox></div>
                            <div class="Reg-Val-1"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName"  ErrorMessage="Please enter your Last Name"></asp:RequiredFieldValidator></div>
                            </div>
                    </div>

                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep3" runat="server" Title="Contact Details">
                    <div class="Reg-Outer-Wrap">
                            <div class="Reg-In-wrap">
                            <div class="Reg-In-label"><asp:Label ID="lblEmailId" runat="server"  Text="E-Mail ID"></asp:Label></div>
                            <div class="Reg-Out-text"><asp:TextBox ID="txtEmailId" runat="server" ></asp:TextBox></div>
                            <div class="Reg-Val-1"><asp:RequiredFieldValidator ID="RequiredEMailId" runat="server" ControlToValidate="txtEmailId"  ErrorMessage="Please enter your E-Mail Id"></asp:RequiredFieldValidator></div>
                            <div class="Reg-Val-2"><asp:RegularExpressionValidator ID="EmailIdValidator" runat="server" ControlToValidate="txtEmailId"  ErrorMessage="Enter correct E-Mail Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></div>
                            </div>
                            <div class="Reg-In-wrap">
                            <div class="Reg-In-label"><asp:Label ID="MobileNumber" runat="server"  Text="Contact Number"></asp:Label></div>
                            <div class="Reg-Out-text"><asp:TextBox ID="txtMobile" runat="server"  ></asp:TextBox></div>
                            <div class="Reg-Val-1"><asp:RequiredFieldValidator ID="RequiredPassword" runat="server" ControlToValidate="txtMobile"  ErrorMessage="Please enter your contact number"></asp:RequiredFieldValidator></div>
                            <div class="Reg-Val-2"><asp:RegularExpressionValidator ID="MobileNumberValidator" runat="server" ErrorMessage="Please enter a valid 10 digit mobile number" ControlToValidate="txtMobile" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator></div>
                            </div>
                            <div class="Reg-In-wrap">
                            <div class="Reg-In-label"><asp:Label ID="lblWebSiteURL" runat="server"  Text="Personal WebSite URL"></asp:Label></div>
                            <div class="Reg-Out-text"><asp:TextBox ID="txtWebSiteURL" runat="server"  ></asp:TextBox></div>
                            <div class="Reg-Val-1"><asp:RegularExpressionValidator ID="WebsiteURLValidator" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtWebSiteURL"></asp:RegularExpressionValidator></div>
                            </div> 
                     </div>
                    </asp:WizardStep>
            </WizardSteps>
            <SideBarTemplate>
                <asp:DataList runat="server" ID="SideBarList" HorizontalAlign="Justify" RepeatDirection="Horizontal">
                <ItemTemplate>
                <div id="divWizardSampleSidebar" runat="server" class="div-WizardSample-Sidebar-Steps">
                <asp:LinkButton runat="server" ID="SideBarButton" Enabled="true" Font-Bold="true" style="text-decoration:none;color:black" />
                </div>
                </ItemTemplate>
                </asp:DataList>
                </tr><tr>
            </SideBarTemplate>
        </asp:Wizard>
</asp:Content>
