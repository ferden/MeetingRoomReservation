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
    public class PlaceMap: IEntityTypeConfiguration<Place>

            {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.HasKey(y => y.Id);
            builder.Property(y => y.Id).ValueGeneratedOnAdd();
            builder.Property(y => y.Name).HasMaxLength(100);
            builder.Property(y => y.Name).IsRequired(true);
            builder.Property(y => y.Note).HasMaxLength(100);
            builder.Property(y => y.CreatedByName).HasMaxLength(100);
            builder.Property(y => y.ModifiedByName).HasMaxLength(100);
            builder.ToTable("Places");
            builder.HasData(
             new Place
             {
                 Id = 1,
                 Name = "TOBB AZ Yerleşkesi2",
                 CreatedByName = "initial",
                 IsActive = true,
                 IsDeleted = false,
                 CreatedDate = DateTime.Now,
                 ModifiedByName = "Initial",
                 Note = "Initial",
                 ModifiedDate = DateTime.Now,
             });

        }
    
}
}
