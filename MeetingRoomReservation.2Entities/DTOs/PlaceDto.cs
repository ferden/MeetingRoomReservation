using MeetingRoomReservation._1Shared.Entities.Abstract;
using MeetingRoomReservation._2Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._2Entities.DTOs
{
    public class PlaceDto: DtoGetBase
    {
        public Place Place { get; set; }
    }
}
