using AutoMapper;
using MeetingRoomReservation._2Entities.Concrete;
using MeetingRoomReservation._2Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._4Services.AutoMapper.Profiles
{
    public class PlaceProfile:Profile
    {
        public PlaceProfile()
        {
            CreateMap<PlaceAddDto, Place>();
            CreateMap<PlaceUpdateDto, Place>();
        }
    }
}
