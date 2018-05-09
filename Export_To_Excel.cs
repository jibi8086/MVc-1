 GridView logGrid = new GridView();
 DataTable logData = new DataTable();
 
 //load values  from Database to datatable logdata
 
 if (logData.Rows.Count > 0)
                        {
                            logGrid.DataSource = logData;
                            logGrid.DataBind();
                        }
                        if (logGrid.Rows.Count > 0)
                        {
                        Response.Clear();
                            Response.AddHeader("content-disposition", "attachment;filename=LogReport.xls");
                            Response.Charset = "";
                            Response.ContentType = "application/ms-excel";
                            StringWriter Write = new StringWriter();
                            HtmlTextWriter HtmlWrite = new HtmlTextWriter(Write);
                            logGrid.RenderControl(HtmlWrite);
                            Response.Write(Write.ToString());
                            Response.End();
                            Response.Clear();
                            }
