var rowCount = 1;
var clonedRow;
function keepClone() {
    var content = $('#tblFlatFees tr');
    clonedRow = content[1].innerHTML;
}
function addFlatFeeTableRow() {    
    rowCount++;        
    var recRow = '<tr id="rowCount' + rowCount + '">';    
    var row = recRow + clonedRow + '</tr>';
    $("#tblFlatFees tbody").append(row); 
    addDeleteButton();
}

function removeTableRow(removeNum) {
    var rowCount = $('#tblFlatFees >tbody >tr').length;
    if (rowCount > 1) {
        $('#rowCount' + removeNum).remove();
    }
}

function addDeleteButton() {
    var tdCol = '<td><input type="image" onclick="removeTableRow(' + rowCount + ')" src="/Contents/images/DeleteRowSmall.png" /></td>'
    $('#rowCount' + rowCount + '').append(tdCol); 
}