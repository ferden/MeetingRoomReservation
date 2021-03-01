using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingRoomReservation._2Entities.Concrete;

namespace MeetingRoomReservation._3Data.Concrete.EntityFrameWork.Mappings
{
    public class MeetingRoomMap : IEntityTypeConfiguration<MeetingRoom>
    {

        public void Configure(EntityTypeBuilder<MeetingRoom> builder)
        {
            builder.HasKey(ts=>ts.Id);
            builder.Property(ts => ts.Id).ValueGeneratedOnAdd();
            builder.Property(ts => ts.Name).IsRequired(true);
            builder.Property(ts => ts.Name).HasMaxLength(100);
            builder.Property(ts => ts.Description).HasMaxLength(500);
            builder.Property(ts => ts.Projection).IsRequired(true);
            builder.Property(ts => ts.Computer).IsRequired(true);
            builder.Property(ts => ts.WebConference).HasMaxLength(100);   
            builder.Property(ts => ts.PlaceID).IsRequired(true);
            builder.Property(ts => ts.Note).HasMaxLength(100);
            builder.Property(ts=> ts.CreatedByName).HasMaxLength(100);
            builder.Property(ts => ts.ModifiedByName).HasMaxLength(100);
            builder.HasOne<Place>(y => y.Place).WithMany(ts => ts.MeetingRooms).HasForeignKey(y => y.PlaceID);
            builder.ToTable("MeetingRooms");
        //    public string Name { get; set; }
        //public string Description { get; set; }
        //public int PersonCapacity { get; set; }
        //public bool Projection { get; set; }

        //public bool Computer { get; set; }
        //public string WebConference { get; set; }
        //public int Area { get; set; }

        //public int Status { get; set; }

        //public int PlaceID { get; set; }
        //public Place Place { get; set; }



        builder.HasData(
                 new MeetingRoom
                 {
                     Id = 1,
                     PlaceID = 1,
                     Description = "Buyuk Salon2",
                     Name = "1 nolu Salon2",
                     Projection = true,
                     Computer=true,
                     WebConference="zoom",
                     CreatedByName = "initial",
                     IsActive = true,
                     IsDeleted = false,
                     CreatedDate = DateTime.Now,
                     ModifiedByName="Initial",
                     ModifiedDate=DateTime.Now,
                     Status=1,
                     Area=10,
                     PersonCapacity=12,
                     Note="note",
                 });

        } }

}
