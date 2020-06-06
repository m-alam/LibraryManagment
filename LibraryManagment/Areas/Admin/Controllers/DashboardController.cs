using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var model = new DashboardModel();
           
            return View(model);
        }
    }
}