<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowTeacher.aspx.cs" Inherits="HTTP5101_School_System.ShowTeacher" %>
<asp:Content ID="Show Teacher" ContentPlaceHolderID="body" runat="server">
    <div id="teacher" runat="server">
        <h2>Details for <span id="teacher_title_fname" runat="server"></span></h2>
        <div>First Name: <span id="teacher_fname" runat="server"></span></div>
        <div>Last Name: <span id="teacher_lname" runat="server"></span></div>
        <div>Employee Number: <span id="employee_number" runat="server"></span></div>
        <div>Hire Date: <span id="hire_date" runat="server"></span></div>
        <div>Salary: <span id="salary" runat="server"></span></div>
    </div>
</asp:Content>
