<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="DeleteClass.aspx.cs" Inherits="HTTP5101_School_System.DeleteClass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="schoolclass" runat="server">
        <h1>Delete class <span id="classcode_title" runat="server"></span>?</h1>

        <div id="class_info">
            <div>
                <h2>Class code:</h2>
                <div id="classcode_display" runat="server"></div>

            </div>
            <div>
                <h2>Teacher ID:</h2>
                <div id="teacherid" runat="server"></div>
            </div>
            <div>
                <h2>Start date:</h2>
                <div id="startdate" runat="server"></div>
            </div>
            <div>
                <h2>Finish date:</h2>
                <div id="finishdate" runat="server"></div>
            </div>
            <div>
                <h2>Class name</h2>
                <div id="classname" runat="server"></div>
            </div>
        </div>
    </div>
    <%-- Create a button to delete the class --%>
    <div id="show_enrolled" runat="server">
        <asp:Button runat="server" Text="Delete" />
    </div>
    <div id="delete_confirmation" runat="server"></div>
</asp:Content>
