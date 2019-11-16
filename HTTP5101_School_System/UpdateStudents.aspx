<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="UpdateStudents.aspx.cs" Inherits="HTTP5101_School_System.UpdateStudents" %>
<asp:Content ID="UpdatingStudents" ContentPlaceHolderID="body" runat="server">
    <div id="updating_students" runat="server">
        <h2>Updating student information </h2>
        <label for="update_studentfname">First name:</label> 
        <asp:Textbox runat="server" ID="update_studentfname" placeholder="John"></asp:Textbox><br />
        <label for ="update_studentlname">Last name:</label>
        <asp:Textbox runat="server" ID="update_studentlname" placeholder="Smith"></asp:Textbox><br />
        <label for="update_studentnumber">Student Number:</label>
        <asp:Textbox runat="server" ID="update_studentnumber" placeholder="John"></asp:Textbox><br />
        <label for ="update_studentenrolmentdate">Enrolment Date:</label>
        <asp:Textbox runat="server" ID="update_studentenrolmentdate" placeholder="John"></asp:Textbox><br />
         <asp:Button runat="server" text="Submit" />
    </div>
</asp:Content>
