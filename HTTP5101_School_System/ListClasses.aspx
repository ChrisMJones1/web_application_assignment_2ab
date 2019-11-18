<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListClasses.aspx.cs" Inherits="HTTP5101_School_System.ListClasses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <h1>Classes</h1>
    <div id="class_nav">
        <asp:label for="class_search" runat="server">Search:</asp:label>
        <asp:TextBox ID="class_search" runat="server" placeholder="Search"></asp:TextBox>
        <asp:Button runat="server" text="Search"/>
    </div>
    <div id="adding_class">
        <a href="AddClass.aspx">Add a Class</a>
    </div>
    <div class="_table" runat="server">
        <div class="listitem">
            <div class="col6">CLASS CODE</div>
            <div class="col6">TEACHER NAME</div>
            <div class="col6">START DATE</div>
            <div class="col6">FINISH DATE</div>
            <div class="col6">CLASS NAME</div>
            <div class="col6last">MODIFY</div>
        </div>
        <div id="classes_result" runat="server">

        </div>
    </div>
</asp:Content>
