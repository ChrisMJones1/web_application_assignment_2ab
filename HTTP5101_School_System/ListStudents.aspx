<%@ Page Title="Students_Database" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListStudents.aspx.cs" Inherits="HTTP5101_School_System.ListStudents" %>

<asp:Content ID="students_list" ContentPlaceHolderID="body" runat="server">
    <h1>Students</h1>
    <div id="student_nav">
        <asp:label for="student_search" runat="server">Search:</asp:label>
        <asp:TextBox ID="student_search" runat="server" placeholder="Search for a student here"></asp:TextBox>
        <asp:Button runat="server" text="Search"/>
        <%--<div id="sql_debugger" runat="server"></div>--%>
        <%
        //todod: search by keyword
        //search by semester selection(?) -- calendar picker before/after? -- range?
        //order by fname lname asc desc
        %>
    </div>
    <div>
        <a href="AddStudent.aspx" id="top-adding-link" class="button-link">Add a student</a>
        <%
            //creating a link that lead to the adding page of new students into the database
        %>
    </div>
    <div class="_table" runat="server">
        <div class="listitem">
            <div class="col6">STUDENT ID</div>
            <div class="col6">FIRST NAME</div>
            <div class="col6">LAST NAME</div>
            <div class="col6">STUDENT NUMBER</div>
            <div class="col6">ENROLMENT DATE</div>
            <div class="col6last">MODIFY</div>     
        </div>
        <div id="students_result" class="table-content" runat="server"></div>
    </div> 
    <!-- WHAT IF the user scroll through all the page and still can't find the student and want to add the student in the system -->
    <!-- The Add a student link at the end will be helpful in that case -->
    <a href="AddStudent.aspx" id="bottom-adding-link" class="button-link">Add a student</a>
</asp:Content>
