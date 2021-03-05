using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoomReservation._4Services.Abstract;
using MeetingRoomReservation._1Shared.Utilities.Results.ComplexTypes;
using MeetingRoomReservation._2Entities.DTOs;
using MeetingRoomReservation._5MVC.Areas.Admin.Models;
using MeetingRoomReservation._1Shared.Utilities.Extensions;
using System.Text.Json;

namespace MeetingRoomReservation._5Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PlaceController : Controller
    {
        private readonly IPlaceService _placeservice;

        public PlaceController(IPlaceService placeservice)
        {
            _placeservice = placeservice;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _placeservice.GetAllAsync();
        
                return View(result.Data);
                      
        }
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_PlaceAddPartial");
        }

        [HttpPost]
        public async Task<IActionResult> Add(PlaceAddDto placeAddDto)
        {
  

            if (ModelState.IsValid)
            {
                var result = await _placeservice.AddAsync(placeAddDto, "fikret");

                if (result.ResultStatus == ResultStatus.Success)
                {
                    var placeAddAjaxModel = JsonSerializer.Serialize(new PlaceAddAjaxViewModel
                    {

                        PlaceDto = result.Data,
                        PlaceAddPartial = await this.RenderViewToStringAsync("_PlaceAddPartial", placeAddDto)
                    });
                    return Json(placeAddAjaxModel);
                }
                else
                        {
                    var placeAddAjaxErrorModel = JsonSerializer.Serialize(new PlaceAddAjaxViewModel
                    {

                        // PlaceDto = result.Data,
                        PlaceAddPartial = await this.RenderViewToStringAsync("_PlaceAddPartial", placeAddDto)
                    });
                    return Json(placeAddAjaxErrorModel);

                }

            }
            else
            {
                var placeAddAjaxErrorModel = JsonSerializer.Serialize(new PlaceAddAjaxViewModel
                {

                   // PlaceDto = result.Data,
                    PlaceAddPartial = await this.RenderViewToStringAsync("_PlaceAddPartial", placeAddDto)
                });
                return Json(placeAddAjaxErrorModel);
            }
                

            }
        }
    }

