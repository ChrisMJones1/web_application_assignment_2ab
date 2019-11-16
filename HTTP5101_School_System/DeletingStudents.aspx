<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="DeletingStudents.aspx.cs" Inherits="HTTP5101_School_System.DeletingStudents" %>
<asp:Content ID="DeletingStudents" ContentPlaceHolderID="body" runat="server">
    <div id="deleting_students" runat="server">
        <h2>Please review the student information before you delete </h2>
        <label for="delete_studentfname">First name:</label> 
        <asp:Textbox runat="server" ID="delete_studentfname" placeholder="John"></asp:Textbox><br />
        <label for ="delete_studentlname">Last name:</label>
        <asp:Textbox runat="server" ID="delete_studentlname" placeholder="Smith"></asp:Textbox><br />
        <label for="delete_studentnumber">Student Number:</label>
        <asp:Textbox runat="server" ID="delete_studentnumber" placeholder="John"></asp:Textbox><br />
        <label for ="delete_studentenrolmentdate">Enrolment Date:</label>
        <asp:Textbox runat="server" ID="delete_studentenrolmentdate" placeholder="John"></asp:Textbox><br />
        <asp:Button runat="server" text="Delete" />
    </div>
</asp:Content>
