using MeetingRoomReservation._1Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._2Entities.Concrete
{
    public class Room:EntityBase,IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PersonCapacity { get; set; }
        public bool Projection { get; set; }

        public bool Computer { get; set; }
        public string WebConference { get; set; }
        public int Area { get; set; }

        public int Status { get; set; }

        public int PlaceID { get; set; }
        public Place Place { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

    }
}
