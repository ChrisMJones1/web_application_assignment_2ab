<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="DeleteTeacher.aspx.cs" Inherits="HTTP5101_School_System.DeleteTeacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
        <div id="delete_teachers" runat="server">
        <h1>Please confirm the deleting information:</h1>        
        <div>
            First Name: <span id="teacher_fname" runat="server"></span>
        </div>
        <div>
            Last Name: <span id="teacher_lname" runat="server"></span>
        </div>
        <div>
            Employee Number: <span id="teacher_employeenumber" runat="server"></span>
        </div>
        <div>
            Hire Date: <span id="teacher_hiredate" runat="server"></span>
        </div>
        <div>
            Salary: <span id="teacher_salary" runat="server"></span>
        </div>
        <div>
            <asp:Button runat="server" text="Delete"/>
        </div>        
        <div id="delete_summary" runat="server"></div>
    </div>
</asp:Content>
