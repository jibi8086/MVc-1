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


/*
  public JsonResult GetTaskName()
        {

            try
            {
                string jResult = string.Empty;
                using (SqlConnection con = new SqlConnection(consString))
                {
                    using (SqlCommand cmd = new SqlCommand("VTwo.UspDropDownBind"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@ID_Module", 4);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dataReader);
                        con.Close();
                        if (dataTable.Rows.Count > 0)
                        {
                            jResult = JsonConvert.SerializeObject(dataTable, Newtonsoft.Json.Formatting.Indented);
                            if (jResult != string.Empty)
                                return Json(jResult, JsonRequestBehavior.AllowGet);
                        }
                        else
                        {

                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Dispose();
            }
            return Json(new { flag = false }, JsonRequestBehavior.AllowGet);
        }
        
        */
