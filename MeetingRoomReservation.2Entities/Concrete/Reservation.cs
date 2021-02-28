using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingRoomReservation._1Shared.Entities.Abstract;

namespace MeetingRoomReservation._2Entities.Concrete
{
    public class Reservation : EntityBase, IEntity
    {
        public string RequestUser { get; set; }
        public string MeetingSubject { get; set; }
        public int MeetingType { get; set; }
        public string MeetingDescription { get; set; }
        public DateTime MeetingStartTime { get; set; }
        public DateTime MeetingEndTime { get; set; }
        public string MeetingNotes { get; set; }
        public int MeetingRoomID { get; set; }
        public Room MeetingRoom { get; set; }
    }
}
