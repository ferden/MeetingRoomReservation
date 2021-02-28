using MeetingRoomReservation._1Shared.Data.Concrete.EntityFrameWork;
using MeetingRoomReservation._2Entities.Concrete;
using MeetingRoomReservation._3Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._3Data.Concrete.EntityFrameWork.Repositories
{
    public class EfPlaceRepository : EfEntityRepositoryBase<Place>, IPlaceRepository
    {

        public EfPlaceRepository(DbContext context) : base(context)
        {
        }
    }
}
