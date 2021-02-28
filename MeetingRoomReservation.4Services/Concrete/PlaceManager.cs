using AutoMapper;
using MeetingRoomReservation._1Shared.Utilities.Concrete;
using MeetingRoomReservation._1Shared.Utilities.Results.Abstract;
using MeetingRoomReservation._1Shared.Utilities.Results.ComplexTypes;
using MeetingRoomReservation._2Entities.Concrete;
using MeetingRoomReservation._2Entities.DTOs;
using MeetingRoomReservation._3Data.Abstract;
using MeetingRoomReservation._4Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._4Services.Concrete
{
    public class PlaceManager: IPlaceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PlaceManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<PlaceDto>> GetAsync(int placeId)
        {
            var place = await _unitOfWork.Places.GetAsync(a => a.Id == placeId);
            if (place != null)
            {
                return new DataResult<PlaceDto>(ResultStatus.Success, new PlaceDto
                {
                    Place = place,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PlaceDto>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", null);
        }

        public async Task<IDataResult<PlaceUpdateDto>> GetPlaceUpdateDtoAsync(int placeId)
        {
            var result = await _unitOfWork.Places.AnyAsync(a => a.Id == placeId);
            if (result)
            {
                var place = await _unitOfWork.Places.GetAsync(a => a.Id == placeId);
                var placeUpdateDto = _mapper.Map<PlaceUpdateDto>(place);
                return new DataResult<PlaceUpdateDto>(ResultStatus.Success, placeUpdateDto);
            }
            else
            {
                return new DataResult<PlaceUpdateDto>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", null);
            }
        }

        public async Task<IDataResult<PlaceListDto>> GetAllAsync()
        {
            var places = await _unitOfWork.Places.GetAllAsync(null);
            if (places.Count > -1)
            {
                return new DataResult<PlaceListDto>(ResultStatus.Success, new PlaceListDto
                {
                    Places = places,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PlaceListDto>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", null);
        }

        public async Task<IDataResult<PlaceListDto>> GetAllByNonDeletedAsync()
        {
            var places = await _unitOfWork.Places.GetAllAsync(a => !a.IsDeleted);
            if (places.Count > -1)
            {
                return new DataResult<PlaceListDto>(ResultStatus.Success, new PlaceListDto
                {
                    Places = places,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PlaceListDto>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", null);
        }

        public async Task<IDataResult<PlaceListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            var places =
                await _unitOfWork.Places.GetAllAsync(a => !a.IsDeleted && a.IsActive);
            if (places.Count > -1)
            {
                return new DataResult<PlaceListDto>(ResultStatus.Success, new PlaceListDto
                {
                    Places = places,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PlaceListDto>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", null);
        }

       
        public async Task<IDataResult<PlaceDto>> AddAsync(PlaceAddDto placeAddDto, string createdByName)
        {
            var place = _mapper.Map<Place>(placeAddDto);
            place.CreatedByName = createdByName;
            place.ModifiedByName = createdByName;
          
           var addedPlace= await _unitOfWork.Places.AddAsync(place);
            await _unitOfWork.SaveAsync();
          
            return new DataResult<PlaceDto>(ResultStatus.Success, place.Name, new PlaceDto {Place = addedPlace, ResultStatus = ResultStatus.Success, Message = "başarılı" });
        }

        public async Task<IDataResult<PlaceDto>> UpdateAsync(PlaceUpdateDto placeUpdateDto, string modifiedByName)
        {
            var place = await _unitOfWork.Places.GetAsync(a => a.Id == placeUpdateDto.Id);
            // var article = Mapper.Map<ArticleUpdateDto, Article>(articleUpdateDto, oldArticle);
            place.ModifiedByName = modifiedByName;
            place.ModifiedDate = DateTime.Now;
            var updatedPlace = await _unitOfWork.Places.UpdateAsync(place);
            await _unitOfWork.SaveAsync();
            return new DataResult<PlaceDto>(ResultStatus.Success, place.Name, new PlaceDto { Place = updatedPlace, ResultStatus = ResultStatus.Success, Message = "başarılı" });
        }

        public async Task<IResult> DeleteAsync(int placeId, string modifiedByName)
        {
            var result = await _unitOfWork.Places.AnyAsync(a => a.Id == placeId);
            if (result)
            {
                var place = await _unitOfWork.Places.GetAsync(a => a.Id == placeId);
                place.IsDeleted = true;
                place.ModifiedByName = modifiedByName;
                place.ModifiedDate = DateTime.Now;
                await _unitOfWork.Places.UpdateAsync(place);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "OK");
            }
            return new Result(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.");
        }

        public async Task<IResult> HardDeleteAsync(int placeId)
        {
            var result = await _unitOfWork.Places.AnyAsync(a => a.Id == placeId);
            if (result)
            {
                var place = await _unitOfWork.Places.GetAsync(a => a.Id == placeId);
                await _unitOfWork.Places.DeleteAsync(place);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "OK");
            }
            return new Result(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.");
        }

        public async Task<IDataResult<int>> CountAsync()
        {
            var placesCount = await _unitOfWork.Places.CountAsync();
            if (placesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, placesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }

        public async Task<IDataResult<int>> CountByNonDeletedAsync()
        {
            var placesCount = await _unitOfWork.Places.CountAsync(a => !a.IsDeleted);
            if (placesCount > -1)
            {
                return new DataResult<int>(ResultStatus.Success, placesCount);
            }
            else
            {
                return new DataResult<int>(ResultStatus.Error, $"Beklenmeyen bir hata ile karşılaşıldı.", -1);
            }
        }


    }
}

