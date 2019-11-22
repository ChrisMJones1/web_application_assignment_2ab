<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddTeacher.aspx.cs" Inherits="HTTP5101_School_System.Add_Teacher" %>
<asp:Content ID="AddTeachers" ContentPlaceHolderID="body" runat="server">
    <div id="add_teachers" runat="server">
        <h2>Add a new teacher</h2>
        <div id="sql_debugger" runat="server"></div>
        <div>
            <label for="add_teacherfname">First name:</label> 
            <asp:Textbox runat="server" ID="add_teacherfname" Placeholder="Ella"></asp:Textbox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="add_teacherfname" EnableClientScript="true" ErrorMessage="Please enter the teacher first name"></asp:RequiredFieldValidator>
        </div>
        <div>
            <label for ="add_teacherlname">Last name:</label>      
            <asp:Textbox runat="server" ID="add_teacherlname" Placeholder="Qi"></asp:Textbox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="add_teacherlname" EnableClientScript="true" ErrorMessage="Please enter the teacher last name"></asp:RequiredFieldValidator>
        </div>
        <div>
            <label for="add_employeenumber">Employee Number:</label>
            <asp:Textbox runat="server" ID="add_employeenumber" placeholder="T123"></asp:Textbox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="add_employeenumber" EnableClientScript="true" ErrorMessage="Please enter the employee number"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator runat="server" ControlToValidate="add_employeenumber" EnableClientScript="true" ErrorMessage="Please enter a valid employee number" ValidationExpression="^T|n[0-9]{3}$"></asp:RegularExpressionValidator>
        </div>
        <div>
            <label for ="add_hiredate">Hire Date:</label>
            <asp:Textbox runat="server" ID="add_hiredate" placeholder="20 Nov 2019"></asp:Textbox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="add_hiredate" EnableClientScript="true" ErrorMessage="Please enter the hire date"></asp:RequiredFieldValidator>
        </div>   
        <div>
            <label for ="add_salary">Salary:</label>
            <asp:Textbox runat="server" ID="add_salary" placeholder="00.00"></asp:Textbox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="add_salary" EnableClientScript="true" ErrorMessage="Please enter the salary"></asp:RequiredFieldValidator><br />
            <asp:Button runat="server" text="Add" />
        </div> 
        <div id="Add_Summary" runat="server" ShowSummary="true"></div>
    </div>         <%/* */ %>
</asp:Content>
