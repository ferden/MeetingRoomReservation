using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoomReservation._4Services.Abstract;
using MeetingRoomReservation._1Shared.Utilities.Results.ComplexTypes;

namespace MeetingRoomReservation._5Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PlaceController : Controller
    {
        private readonly IPlaceService _placeService;

        public PlaceController(IPlaceService palaceService)
        {
            _placeService = palaceService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _placeService.GetAllAsync();
        
                return View(result.Data);
            
            
        }
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_PalaceAddPartial");
        }
    }
}
