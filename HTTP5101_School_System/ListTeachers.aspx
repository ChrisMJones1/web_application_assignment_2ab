<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListTeachers.aspx.cs" Inherits="HTTP5101_School_System.ListTeachers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <h1>Teachers</h1>
    <div id="teachers_result" class="_table" runat="server">
        <div class="listitem">
            <div class="col5">NAME</div>
            <div class="col5">LAST NAME</div>
            <div class="col5">EMPLOYEE NUMBER</div>
            <div class="col5">HIRE DATE</div>
            <div class="col5last">SALARY</div>
        </div>
    </div>
</asp:Content>
