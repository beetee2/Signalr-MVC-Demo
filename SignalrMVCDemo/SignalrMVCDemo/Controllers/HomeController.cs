using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using SignalrMVCDemo.Hubs;

namespace SignalrMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public void CreateWidget()
        {
            WidgetHub.WidgetCount += 1;

            var widgetHubContext = GlobalHost.ConnectionManager.GetHubContext<WidgetHub>();

            widgetHubContext.Clients.All.updateWidgetCount(WidgetHub.WidgetCount);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}