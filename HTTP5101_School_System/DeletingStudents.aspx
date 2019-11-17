<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="DeletingStudents.aspx.cs" Inherits="HTTP5101_School_System.DeletingStudents" %>
<asp:Content ID="DeletingStudents" ContentPlaceHolderID="body" runat="server">
    <div id="deleting_students" runat="server">
        <h2>Deleting student: <span id="student_fullname" runat="server"></span></h2>
        <h2>Please review the following information CAREFULLY before deleting </h2>        
        <div>
            First Name: <span id="student_fname" runat="server"></span>
        </div>
        <div>
            Last Name: <span id="student_lname" runat="server"></span>
        </div>
        <div>
            Student Number: <span id="student_number" runat="server"></span>
        </div>
        <div>
            Enrolment Date: <span id="enrolment_date" runat="server"></span>
        </div>
        <div>
            <asp:Button runat="server" text="Delete" />
        </div>        
        <div id="deleting_summary" runat="server"></div>
    </div>
   
</asp:Content>
