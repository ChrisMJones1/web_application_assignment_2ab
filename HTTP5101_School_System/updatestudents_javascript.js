//alert("hey");
window.onload = pageReady;
function pageReady() {
    var ChangeBtn = document.getElementById("changebtn");   
    var Firstname_Change = document.getElementById("firstname_change");

    ChangeBtn.onclick = DisplayChange;
    function DisplayChange() {
        Firstname_Change.style.display = "block";
    }
}