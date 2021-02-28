using MeetingRoomReservation._1Shared.Utilities.Results.Abstract;
using MeetingRoomReservation._2Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._4Services.Abstract
{
    public interface IPlaceService
    {
        Task<IDataResult<PlaceListDto>> GetAllAsync();

        Task<IDataResult<PlaceListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<PlaceListDto>> GetAllByNonDeletedAndActiveAsync();

        Task<IDataResult<PlaceDto>> AddAsync(PlaceAddDto placeAddDto, string createdUser);

        Task<IDataResult<PlaceDto>> UpdateAsync(PlaceUpdateDto placeUpdateDto, string modifiedUser);
        Task<IResult> DeleteAsync(int placeId, string modifiedUser);
        Task<IResult> HardDeleteAsync(int placeId);

       // Task<IResult> UndoDeleteAsync(int placeId, string modifiedUser);
        Task<IDataResult<int>> CountAsync();

        Task<IDataResult<int>> CountByNonDeletedAsync();

    }
}
