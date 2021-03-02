using MeetingRoomReservation._2Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoomReservation._5MVC.Areas.Admin.Models
{

    //MVC için ön tarafta kullanacağım bilgiler
    public class PlaceAddAjaxViewModel
    {
        public PlaceAddDto PlaceAddDto { get; set; }
        public string PlaceAddPartial { get; set; }

        public PlaceDto PlaceDto { get; set; }
    }
}
