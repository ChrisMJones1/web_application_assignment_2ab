<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="UpdateStudents.aspx.cs" Inherits="HTTP5101_School_System.UpdateStudents" %>
<asp:Content ID="UpdatingStudents" ContentPlaceHolderID="body" runat="server">
    <!-- <script type="text/javascript" src="updatestudents_javascript.js" ></script> -->
    <!-- <style>#firstname_change{display: none;}</style> -->
    <div id="updating_students" runat="server">
        <h2>Updating student <span id="student_fullname" runat="server"></span> information </h2>
        <div>
            Current First name: <span id="student_fname" runat="server"></span>
            <!-- <asp:Button class="changebtn" runat="server" text="Change" /> -->
        
            <div id="firstname_change">
                <label for="update_studentfname">New first name:</label> 
                <asp:Textbox runat="server" ID="update_studentfname"></asp:Textbox>
            </div>
        </div>

        <div>
            Current Last name: <span id="student_lname" runat="server"></span>
            <!-- <asp:Button class="changebtn" runat="server" text="Change" /> -->
        
            <div id="lastname_change">
              <label for ="update_studentlname">New last name:</label>
               <asp:Textbox runat="server" ID="update_studentlname"></asp:Textbox>
            </div>
        </div>
         <div>
            Current Student Number: <span id="student_number" runat="server"></span>
            <!-- <asp:Button class="changebtn" runat="server" text="Change" /> -->
        
            <div id="studentnumber_change">
             <label for="update_studentnumber"> New student number:</label>
             <asp:Textbox runat="server" ID="update_studentnumber"></asp:Textbox>
            </div>
        </div>
        <div>
            Current Enrolment Date: <span id="enrolment_date" runat="server"></span>
            <!-- <asp:Button class="changebtn" runat="server" text="Change" /> -->
        
            <div id="studentenrolmentdate_change">
                <label for ="update_studentenrolmentdate"> New enrolment date:</label>
                <asp:Textbox runat="server" ID="update_studentenrolmentdate"></asp:Textbox>
            </div>
        </div>
      
        <asp:Button runat="server" text="Submit" />
        <div id="updating_summary" runat="server"></div>
    </div>
</asp:Content>
