using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MyDemoAbp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyDemoAbpControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}