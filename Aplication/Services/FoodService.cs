using Aplication.DTOs.FoodDto;
using Aplication.DTOs.FoodDtos;
using Aplication.Interfaces;
using Data.Interfaces;

namespace Aplication.Services
{
    public class FoodService(IUnitOfWork unitOfWork) : IFoodService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public Task CreteAsync(AddFoodDto addFoodDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<FoodDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FoodDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsycn(UpdateFoodDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
