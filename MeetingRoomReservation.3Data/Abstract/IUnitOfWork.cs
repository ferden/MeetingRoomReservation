using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._3Data.Abstract
{
    public interface IUnitOfWork
    {
        IPlaceRepository Places { get; }

        Task<int> SaveAsync();

    }
}
