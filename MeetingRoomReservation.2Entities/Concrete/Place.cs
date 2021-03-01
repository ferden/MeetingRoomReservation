using MeetingRoomReservation._1Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._2Entities.Concrete
{
    public class Place:EntityBase,IEntity
    {
        public string Name { get; set; }

        public ICollection<MeetingRoom> MeetingRooms { get; set; }
    }
}
