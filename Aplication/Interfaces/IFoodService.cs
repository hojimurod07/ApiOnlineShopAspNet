using Aplication.DTOs.FoodDto;
using Aplication.DTOs.FoodDtos;

namespace Aplication.Interfaces
{
    public interface IFoodService
    {
        Task CreteAsync(AddFoodDto addFoodDto);
        Task DeleteAsync(int id);
        Task UpdateAsycn(UpdateFoodDto updateDto);
        Task<FoodDto> GetByIdAsync(int id);
        Task<List<FoodDto>> GetAllAsync();

    }
}
