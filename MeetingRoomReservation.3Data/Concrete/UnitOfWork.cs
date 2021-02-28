using MeetingRoomReservation._3Data.Abstract;
using MeetingRoomReservation._3Data.Concrete.EntityFrameWork.Contexts;
using MeetingRoomReservation._3Data.Concrete.EntityFrameWork.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._3Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly MeetingRoomReservationContext _context;
        private readonly EfPlaceRepository _placeRepository;


        public UnitOfWork(MeetingRoomReservationContext context)
        {
            _context = context;
        }

        public IPlaceRepository Places => _placeRepository ?? new EfPlaceRepository(_context);



        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
