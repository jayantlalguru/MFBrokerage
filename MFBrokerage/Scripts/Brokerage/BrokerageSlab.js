var flatFeesRowCount = 1;
var clonedFlatFeesRow;
var trailFeesRowCount = 1;
var clonedTrailFeesRow;

function keepClone(tableId) {
    var content = $('#' + tableId + ' tr');
    if (tableId == 'tblTrailFees') {
        clonedTrailFeesRow = content[1].innerHTML;
    }
    else if (tableId == 'tblFlatFees') {
        clonedFlatFeesRow = content[1].innerHTML;
    }    
}
function addTableRow(tableId) {    
    if (tableId == 'tblTrailFees') {
        trailFeesRowCount++;
        var recRow = '<tr id="rowCount' + trailFeesRowCount + '">';
        var row = recRow + clonedTrailFeesRow + '</tr>';
    }
    else if (tableId == 'tblFlatFees') {
        flatFeesRowCount++;
        var recRow = '<tr id="rowCount' + flatFeesRowCount + '">';
        var row = recRow + clonedFlatFeesRow + '</tr>';         
    }   
    $('#' + tableId + ' tbody').append(row);
    addDeleteButton(tableId);
}
function removeTableRow(removeNum, tableId) {
    tableId = tableId.id;
    var rowCount = $('#' + tableId + ' >tbody >tr').length;
    if (rowCount > 1) {        
        $('#' + tableId + ' >tbody >#rowCount' + removeNum + '').remove();
    }    
}
function addDeleteButton(tableId) {
    var rowCount;
    if (tableId == 'tblTrailFees') {
        rowCount = trailFeesRowCount;
    }
    else if (tableId == 'tblFlatFees') {
        rowCount = flatFeesRowCount;
    }    
    var tdCol = '<td><input type="image" onclick="removeTableRow(' + rowCount + ', ' + tableId + '); return false;" src="/Contents/images/DeleteRowSmall.png" /></td>'    
    $('#' + tableId + ' >tbody >#rowCount' + rowCount + '').append(tdCol);
}

function CreateFlatFeesBrokerageSlab() {
    var brokerageSlabHeaderModel = {
        AMC: 1,
        Category: 2,
        Scheme: '1,2',
        BrokeragePeriodFrom: '12-May-2018',
        BrokeragePeriodTo: '14-May-2018',
        ClawbackPeriod: 10
    };
    
    var listBrokerageSlabFlatFeesModel = [];
    
    $('#tblFlatFees > tbody  > tr').each(function () {
        var model = {
            BrokerageType: $(this).find("td").eq(0).find("select option:selected").val(),
            Rate: $(this).find("td").eq(1).find(":text").val(),
            AmountFrom: $(this).find("td").eq(2).find(":text").val(),
            AmountTo: $(this).find("td").eq(3).find(":text").val(),
            Location: $(this).find("td").eq(4).find("select option:selected").val(),
            IncludeSIPSTP: $(this).find("td").eq(5).find(":checkbox").is(':checked')
        };        
        listBrokerageSlabFlatFeesModel.push(model);
    })
    
    //listBrokerageSlabFlatFeesModel = JSON.stringify({ 'listBrokerageSlabFlatFeesModel': listBrokerageSlabFlatFeesModel });
    $.ajax({
        type: 'POST',        
        url: 'CreateFlatFees',
        data: JSON.stringify({ 'listBrokerageSlabFlatFeesModel': listBrokerageSlabFlatFeesModel }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {

        }
    });
}