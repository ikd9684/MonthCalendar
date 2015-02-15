using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplicationOfCalendar.Models;

namespace WebApplicationOfCalendar.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            CalendarViewModel viewModel = new CalendarViewModel();
            viewModel = CalendarBusinessLogic.getCalendar(viewModel);

            // アクションのデフォルトビューを表示
            return View(viewModel);
        }
    }
}
