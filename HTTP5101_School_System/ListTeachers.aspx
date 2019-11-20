<%@ Page Title="Teachers" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListTeachers.aspx.cs" Inherits="HTTP5101_School_System.ListTeachers" %>
<asp:Content ID="teachers_list" ContentPlaceHolderID="body" runat="server">
    <h1>Teachers</h1>
    <div id="teacher_nav">
        <asp:label runat="server" for="teacher_search">Search:</asp:label>
        <asp:TextBox runat="server" ID="teacher_search" placeholder="Search for a teacher here"></asp:TextBox>
        <asp:Button runat="server" Text="Submit"/>
        <!-- <div id="sql_debugger" runat="server"></div> -->
    </div>
    <div class="_table" runat="server">
        <div class="listitem">
            <div class="col7">ID</div>
            <div class="col7">FIRST NAME</div>
            <div class="col7">LAST NAME</div>
            <div class="col7">EMPLOYEE NUMBER</div>
            <div class="col7">HIRE DATE</div>
            <div class="col7">SALARY</div>
            <div class="col7last">MODIFY</div>
        </div>
        <div id="teachers_result" runat="server">

        </div>
    </div>
</asp:Content>


