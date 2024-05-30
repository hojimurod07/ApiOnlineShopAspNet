using Aplication.DTOs.CategoryDto;

namespace Aplication.Interfaces
{
    public interface ICategoryService
    {
        Task CreateAsync(AddCategoryDto categoryDto);
        Task UpdateAsync(UpdateCategoryDto categoryDto);
        Task DeleteAsync(int id);
        Task<List<CategoryDto>> GetAllAsync();  


    }
}
