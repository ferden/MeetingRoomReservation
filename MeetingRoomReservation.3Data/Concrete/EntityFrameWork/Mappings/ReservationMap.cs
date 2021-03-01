using MeetingRoomReservation._2Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._3Data.Concrete.EntityFrameWork.Mappings
{
    public class ReservationMap: IEntityTypeConfiguration<Reservation>

            {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();// 1er 1er arttır
            builder.Property(t => t.RequestUser).IsRequired(true);
            builder.Property(t => t.MeetingSubject).HasMaxLength(100);
            builder.Property(t => t.MeetingSubject).IsRequired(true);
            builder.Property(t => t.MeetingType).IsRequired(true);
            builder.Property(t => t.MeetingDescription).HasMaxLength(100);
            builder.Property(t => t.MeetingStartTime).IsRequired(true);
            builder.Property(t => t.MeetingEndTime).IsRequired(true);
            builder.Property(t => t.MeetingNotes).HasMaxLength(1000);
            builder.Property(t => t.CreatedByName).HasMaxLength(100);
            builder.Property(t => t.CreatedByName).HasMaxLength(100);
            builder.Property(t => t.IsActive).IsRequired(true);
            builder.Property(t => t.IsDeleted).IsRequired(true);
            builder.HasOne <MeetingRoom>(mr => mr.MeetingRoom).WithMany(t => t.Reservations).HasForeignKey(ts => ts.MeetingRoomID);
            builder.ToTable("Reservations");
            //            public string RequestUser { get; set; }
            //public string MeetingSubject { get; set; }
            //public int MeetingType { get; set; }
            //public string MeetingDescription { get; set; }
            //public DateTime MeetingStartTime { get; set; }
            //public DateTime MeetingEndTime { get; set; }
            //public string MeetingNotes { get; set; }
            //public int MeetingRoomID { get; set; }
            //public MeetingRoom MeetingRoom { get; set; }
            builder.HasData(
             new Reservation
             {
                 Id = 1,
                 RequestUser = "fikret.erden",
                 MeetingSubject = "test toplanti Basliği",
                 MeetingType = 1,
                 MeetingStartTime = DateTime.Now,
                 MeetingEndTime = DateTime.Now.AddMinutes(30),
                 MeetingNotes = "Notlar",
                 MeetingRoomID = 1,
                 ModifiedByName = "initial",
                 ModifiedDate = DateTime.Now,
                 Note = "Not",
                 MeetingDescription = "Test Desc Topantisi",
                 CreatedByName = "initial",
                 IsActive = true,
                 IsDeleted = false,
                 CreatedDate = DateTime.Now,
             });
        }

    }
}
