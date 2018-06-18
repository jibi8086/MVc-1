
[SessionAuthorize]--use this
        public ActionResult UploadExcel()
        {
            return View();
        }

///put in common function and call into each page
public class SessionAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return (httpContext.Session["EmployeeID"] != null);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                                  new RouteValueDictionary
                                  {
                                   { "action", "Login" },
                                   { "controller", "Login" }
                                  });
        }
    }
