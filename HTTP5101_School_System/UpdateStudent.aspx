<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="UpdateStudent.aspx.cs" Inherits="HTTP5101_School_System.UpdateStudents" %>
<asp:Content ID="UpdatingStudents" ContentPlaceHolderID="body" runat="server">
    <script type="text/javascript" src="updatestudents_javascript.js" ></script>
    <!-- <style>#firstname_change{display: none;}</style> -->
    <div id="updating_students" runat="server">
        <h2>Updating student information: <span id="student_fullname" runat="server"></span></h2>
        <div>
            <!-- Displaying current information can help user confirm it is the right person to update -->
            Current First name: <span id="student_fname" runat="server"></span>
            <!--<div class="changebtn" runat="server">Change</div> -->
            <!-- What if we can create a button when user click on it the text box will appear to let them change -->
        
            <div id="firstname_change">
                <label for="update_studentfname">New first name:</label> 
                <asp:Textbox runat="server" ID="update_studentfname"></asp:Textbox>
            </div>
        </div>

        <div>
            Current Last name: <span id="student_lname" runat="server"></span>
            <!--<div class="changebtn" runat="server">Change</div> -->
        
            <div id="lastname_change">
              <label for ="update_studentlname">New last name:</label>
               <asp:Textbox runat="server" ID="update_studentlname"></asp:Textbox>
            </div>
        </div>
         <div>
            Current Student Number: <span id="student_number" runat="server"></span>
            <!--<div class="changebtn" runat="server">Change</div> -->
        
            <div id="studentnumber_change">
             <label for="update_studentnumber"> New student number:</label>
             <asp:Textbox runat="server" ID="update_studentnumber"></asp:Textbox>
             <%/*What if the user enter the wrong format of student number?*/ %>
             <asp:RegularExpressionValidator runat="server" ControlToValidate="update_studentnumber" EnableClientScript="true" ErrorMessage="Please enter the right format of student number" ValidationExpression="^N|n[0-9]{4}$"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div>
            Current Enrolment Date: <span id="enrolment_date" runat="server"></span>
            <!--<div class="changebtn" runat="server">Change</div> -->
        
            <div id="studentenrolmentdate_change">
                <label for ="update_studentenrolmentdate"> New enrolment date:</label>
                <asp:Textbox runat="server" ID="update_studentenrolmentdate"></asp:Textbox>
            </div>
        </div>
      
        <asp:Button runat="server" text="Updating" />
        <div id="updating_summary" runat="server"></div>
    </div>
</asp:Content>
