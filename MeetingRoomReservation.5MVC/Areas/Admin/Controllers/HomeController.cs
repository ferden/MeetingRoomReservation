using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoomReservation._1Shared.Utilities.Results.ComplexTypes;
using MeetingRoomReservation._4Services.Abstract;

namespace MeetingRoomReservation._5MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
   [HttpGet]
        public  IActionResult Index()
        {
            return View();
        }
    }
}
