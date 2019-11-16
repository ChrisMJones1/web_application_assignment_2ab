<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddingStudents.aspx.cs" Inherits="HTTP5101_School_System.AddingStudents" %>
<asp:Content ID="AddingStudents" ContentPlaceHolderID="body" runat="server">
    <div id="adding_students" runat="server">
        <h2>Adding student information </h2>
        <label for="adding_studentfname">First name:</label> 
        <asp:Textbox runat="server" ID="adding_studentfname" placeholder="John"></asp:Textbox><br />
        <label for ="adding_studentlname">Last name:</label>
        <asp:Textbox runat="server" ID="adding_studentlname" placeholder="Smith"></asp:Textbox><br />
        <label for="adding_studentnumber">Student Number:</label>
        <asp:Textbox runat="server" ID="adding_studentnumber" placeholder="John"></asp:Textbox><br />
        <label for ="adding_studentenrolmentdate">Enrolment Date:</label>
        <asp:Textbox runat="server" ID="adding_studentenrolmentdate" placeholder="John"></asp:Textbox><br />
         <asp:Button runat="server" text="Adding" />
    </div>
</asp:Content>
