using Domain.Entities;

namespace Aplication.DTOs.CategoryDto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public static implicit operator CategoryDto(Category category)
        {
            return new CategoryDto()
            {
                Name = category.Name,
                Id = category.Id
            };

        }
    }
}
