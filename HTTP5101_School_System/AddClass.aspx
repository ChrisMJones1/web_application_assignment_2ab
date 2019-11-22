<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddClass.aspx.cs" Inherits="HTTP5101_School_System.AddClass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <h1>Add a class</h1>
    <div id="class_input">
        <section id="classcode_input">
            <label for="classcode" runat="server">Class Code:</label>
            <asp:TextBox id="classcode" runat="server" placeholder="e.g. http5505"></asp:TextBox>
        </section>
        <section id="teacherid_input">
            <label for="teacherid">Teacher ID:</label>
            <asp:TextBox ID="teacherid" runat="server" placeholder="e.g. 4"></asp:TextBox>
        </section>
        <section id="startdate_input">
            <label for="startdate">Start Date:</label>
            <asp:TextBox ID="startdate" runat="server" placeholder="e.g. 2019-09-14"></asp:TextBox>
        </section>
        <section id="finishdate_input">
            <label for="finishdate">Finish Date:</label>
            <asp:TextBox ID="finishdate" runat="server" placeholder="e.g. 2019-12-14"></asp:TextBox>
        </section>
        <section id="classname_input">
            <label for="classname">Class Name:</label>
            <asp:TextBox ID="classname" runat="server" placeholder="e.g. Introduction to Biology"></asp:TextBox>
        </section>
    </div>
    <asp:Button runat="server" Text="Add" />
    <div id="add_confirmation" runat="server"></div>
</asp:Content>
