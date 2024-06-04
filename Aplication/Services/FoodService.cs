using Aplication.DTOs.FoodDto;
using Aplication.DTOs.FoodDtos;
using Aplication.Interfaces;
using Data.Interfaces;
using Domain.Entities;
using FluentValidation;

namespace Aplication.Services
{
    public class FoodService(IUnitOfWork unitOfWork,IValidator<Food> validator) : IFoodService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        private readonly IValidator<Food> _validator = validator;

        public async Task CreteAsync(AddFoodDto addFoodDto)
        {
            var result = await _validator.ValidateAsync(addFoodDto);
            
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
