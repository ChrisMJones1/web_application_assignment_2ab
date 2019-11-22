<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowClass.aspx.cs" Inherits="HTTP5101_School_System.ShowClass" %>
<asp:Content ID="class_view" ContentPlaceHolderID="body" runat="server">
    <div id="schoolclass" runat="server">
        <h1>Class details for <span id="classcode_title" runat="server"></span></h1>

        <div id="class_info">
            <div class="content-box">
                <h2>Class code:</h2>
                <div id="classcode_display" runat="server"></div>

            </div>
            <div class="content-box">
                <h2>Teacher ID:</h2>
                <div id="teacherid" runat="server"></div>
            </div>
            <div class="content-box">
                <h2>Start date:</h2>
                <div id="startdate" runat="server"></div>
            </div>
            <div class="content-box">
                <h2>Finish date:</h2>
                <div id="finishdate" runat="server"></div>
            </div>
            <div class="content-box">
                <h2>Class name</h2>
                <div id="classname" runat="server"></div>
            </div>
        </div>
    </div>
    <%-- Create a button to render all the enrolled student info --%>
    <div id="show_enrolled" runat="server">
        <asp:Button runat="server" Text="Show Enrolled Students" />
    </div>
    <%-- Create section to render the enrolled students --%>

    <div class="_table" runat="server">
        <div id="students_header" runat="server">
        </div>
        <div id="students_result" runat="server">

        </div>
    </div>
    
</asp:Content>
