using MeetingRoomReservation._1Shared.Data.Abstract;
using MeetingRoomReservation._2Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._3Data.Abstract
{
    public interface IPlaceRepository : IEntityRepository<Place>
    {
      

    }
}
