using MeetingRoomReservation._2Entities.Concrete;
using MeetingRoomReservation._3Data.Concrete.EntityFrameWork.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._3Data.Concrete.EntityFrameWork.Contexts
{
    public class MeetingRoomReservationContext: DbContext
    {
        public DbSet<Place> Places { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .; Database = MeetingRoomReservation; Trusted_Connection = True; Connect Timeout = 30; MultipleActiveResultSets = True; User ID = sa2; Password = sa31173117");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaceMap());
            modelBuilder.ApplyConfiguration(new MeetingRoomMap());
            modelBuilder.ApplyConfiguration(new ReservationMap()); 

        }

    }
}
