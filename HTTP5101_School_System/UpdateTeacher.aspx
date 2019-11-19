<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateTeacher.aspx.cs" Inherits="HTTP5101_School_System.UpdateTeacher" %>
<asp:Content ID="teachers_list" ContentPlaceHolderID="body" runat="server">
     <script type="text/javascript" src="updatestudents_javascript.js" ></script>
    <!-- <style>#firstname_change{display: none;}</style> -->
    <div id="updating_teachers" runat="server">
        <h2>Updating a teacher information: <span id="teacher_fullname" runat="server"></span></h2>

        <div>Current first name: <span id="teacher_fname" runat="server"></span>
            <div id="firstname_update">
                <label for="update_teacherfname">New first name:</label> 
                <asp:Textbox runat="server" ID="update_teacherfname"></asp:Textbox>
            </div>
        </div>

        <div> Current last name: <span id="teacher_lname" runat="server"></span>
            <div id="lastname_update">
               <label for ="update_teacherlname">New last name:</label>
               <asp:Textbox runat="server" ID="update_teacherlname"></asp:Textbox>
            </div>
        </div>

         <div>Current employee number: <span id="teacher_employeenumber" runat="server"></span>
            <div id="employeenumber_update">
                 <label for="update_employeenumber"> New employee number:</label>
                 <asp:Textbox runat="server" ID="update_employeenumber"></asp:Textbox>
                 <asp:RegularExpressionValidator runat="server" ControlToValidate="update_employeenumber" EnableClientScript="true" ErrorMessage="Please enter the right format of employee number" ValidationExpression="^T|n[0-9]{3}$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div> Current hire date: <span id="teacher_hiredate" runat="server"></span>
            <div id="hiredate_update">
                <label for ="update_hiredate"> New hire date:</label>
                <asp:Textbox runat="server" ID="update_hiredate"></asp:Textbox>
            </div>
        </div>

        <div> Current salary: <span id="teacher_salary" runat="server"></span>
            <div id="salary_update">
                <label for ="update_salary"> New salary:</label>
                <asp:Textbox runat="server" ID="update_salary"></asp:Textbox>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="update_salary" EnableClientScript="true" ErrorMessage="Please enter the right format of salary" ValidationExpression="^[0-9]*(\.[0-9]{1,2})?$"></asp:RegularExpressionValidator>
            </div>
        </div>
      
        <asp:Button runat="server" text="Updating" />
        <div id="update_summary" runat="server"></div>
    </div>

</asp:Content>