in common script

function LoadDdls(pathUrl, ddlObject, KeyField, ValueField) {
    $.ajax({
        url: pathUrl,
        type: "GET",
        async: false,
        success: function (result) {

            var resultVals = $.parseJSON(result);

            if (resultVals["Error"] == undefined || resultVals["Error"] == null) {
                for (var i = 0; i < resultVals.length; i++) {
                    ddlObject.append('<option value=' + resultVals[i][KeyField] + '>' + resultVals[i][ValueField] + '</option>');
                }
            }
        }
        ,
        error: function (err) {
            //alert(err.statusText);
        }
    });
}


call ddl function from cshtml 

LoadDdls('/Package/GetCategoryList', $('#ddlCategory'), 'ID_Package_Category', 'PCName');

for removing ddl
  $('#ddlConnection').find('option').not(':first').remove();
