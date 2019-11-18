<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="UpdateClass.aspx.cs" Inherits="HTTP5101_School_System.UpdateClass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="schoolclass" runat="server">
        <h1>Update Class information for <span runat="server" id="classcode_title"></span></h1>

        <div id="class_input">

            <section id="classcode_input">
                <div>Current class code: <span id="classcode_display" runat="server"></span></div>
                <label for="new_classcode" runat="server">New Class Code:</label>
                <asp:TextBox id="new_classcode" runat="server" placeholder="e.g. http5505"></asp:TextBox>
            </section>

            <section id="teacherid_input">
                <div>Current teacher ID: <span id="teacherid" runat="server"></span></div>
                <label for="new_teacherid">New Teacher ID:</label>
                <asp:TextBox ID="new_teacherid" runat="server" placeholder="e.g. 4"></asp:TextBox>
            </section>

            <section id="startdate_input">
                <div>Current Start Date: <span id="startdate" runat="server"></span></div>
                <label for="new_startdate">New Start Date:</label>
                <asp:TextBox ID="new_startdate" runat="server" placeholder="e.g. 2019-09-14"></asp:TextBox>
            </section>
            <section id="finishdate_input">
                <div>Current Finish Date: <span id="finishdate" runat="server"></span></div>
                <label for="new_finishdate">New Finish Date:</label>
                <asp:TextBox ID="new_finishdate" runat="server" placeholder="e.g. 2019-12-14"></asp:TextBox>
            </section>
            <section id="classname_input">
                <div>Current Class Name: <span id="classname" runat="server"></span></div>
                <label for="new_classname">New Class Name:</label>
                <asp:TextBox ID="new_classname" runat="server" placeholder="e.g. Introduction to Biology"></asp:TextBox>
            </section>
        </div>
        <section>
            <asp:Button runat="server" Text="Submit" />
        </section>
    </div>
</asp:Content>
