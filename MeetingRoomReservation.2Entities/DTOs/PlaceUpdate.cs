using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._2Entities.DTOs
{
    public class PlaceUpdate
    {
        public int Id { get; set; }

        [DisplayName("Yerleşke Adı")]
        [Required(ErrorMessage = "{0} Boş geçilmemelidir")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden Büyük olmamalıdır ")]
        [MinLength(2, ErrorMessage = "{0} {1} karakterden  küçük olmamalıdır ")]
        public string Name { get; set; }

        [DisplayName("Not")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden Büyük olmamalıdır ")]
        [MinLength(1, ErrorMessage = "{0} {1} karakterden  küçük olmamalıdır ")]
        public string Note { get; set; }
        [DisplayName("Aktif Mi")]
        [Required(ErrorMessage = "{0} Boş geçilmemelidir")]
        public bool IsActive { get; set; }
        [DisplayName("Silindi Mi")]
        [Required(ErrorMessage = "{0} Boş geçilmemelidir")]
        public bool IsDeleted { get; set; }
   
    }
}
