 try
            {
                ETLLoginService.ETLCenterLoginService logService = new ETLLoginService.ETLCenterLoginService(); 
                string logDetails = logService.Login(UserName, UserPassword);
                DataTable dt= JsonConvert.DeserializeObject<DataTable>(logDetails);
                employeeId = Convert.ToInt32(dt.Rows[0]["ID"]);
                Session["employeeID"] = employeeId;
                return Json(new {id= employeeId }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                CommonFunctions commonFun = new CommonFunctions();
                commonFun.ExceptionLog(ControllerContext.HttpContext, ex.Message, ex.TargetSite.Name,
                    Convert.ToString(ControllerContext.RouteData.Values["action"]),
                    Convert.ToString(ControllerContext.RouteData.Values["controller"]));
                commonFun = null;
                return Json(new { id = 0 }, JsonRequestBehavior.AllowGet);
            } 
            finally
            {
                Dispose();
            } 
