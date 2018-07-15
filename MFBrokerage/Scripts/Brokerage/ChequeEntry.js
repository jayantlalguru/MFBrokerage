function CalculateTotal() {    
    var totalBrokerage = 0;
    if ($.isNumeric($("#txtTrail").val())) {
        totalBrokerage = Number($("#txtTrail").val());
    }
    if ($.isNumeric($("#txtUpfront").val())) {
        totalBrokerage = totalBrokerage + Number($("#txtUpfront").val());
    }
    if ($.isNumeric($("#txtClawback").val())) {
        totalBrokerage = totalBrokerage + Number($("#txtClawback").val());
    }
    $("#lblTotalBrokerage").text(totalBrokerage);
}

function CreateCheque() {    
    var model = {
        ChequeDate: $('#datepickerChequeDate').val(),
        ChequeReceivedDate: $('#datepickerChequeReceivedDate').val(),
        ChequeNumber: $('#txtChequeNumber').val(),
        ChequeAmount: $('#txtChequeAmount').val(),
        Tax: $('#txtTax').val(),
        BrokeragePeriodFrom: $('#datepickerBrokeragePeriodFrom').val(),
        BrokeragePeriodTo: $('#datepickerBrokeragePeriodTo').val(),
        Bank: $('#ddlBank').val(),
        Branch: $('#ddlBranch').val(),
        ReferenceTag: $('#txtReferenceTag').val(),
        Trail: $('#txtTrail').val(),
        Upfront: $('#txtUpfront').val(),
        Clawback: $('#txtClawback').val(),        
        Remarks: $('#txtRemarks').val()
    };
    $.ajax({
        type: 'POST',
        dataType: 'json',
        url: 'CreateCheque',
        data: model,
        success: function (data) {            
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {

        }
    });
}