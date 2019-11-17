//alert("hey");
window.onload = pageReady;
function pageReady()
{
    var ChangeBtn = document.getElementsByClassName("changebtn");   
    var Firstname_Change = document.getElementById("firstname_change");

    ChangeBtn.onmouseclick = DisplayChange;
    function DisplayChange() {
        Firstname_Change.style.display = "block";
    }
}