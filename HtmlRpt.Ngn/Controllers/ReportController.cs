using Microsoft.AspNetCore.Mvc;

namespace HtmlRpt.Ngn.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return Content("<html><body>Hello Report</body><html>", "text/html");
        }

        public IActionResult Details(string? name)
        {
            return Content($"<html><body>Hello Report {name}</body><html>", "text/html");
        }
    }
}
