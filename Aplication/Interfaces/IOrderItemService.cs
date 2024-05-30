using Aplication.DTOs.OrderItemsDtos;
using Aplication.DTOs.UserDtos;

namespace Aplication.Interfaces
{
    public  interface IOrderItemService
    {
        Task CretaeAsync(AddOrderItemDto dto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateOrderIttemDto dto);
        Task<List<OrderItemDto>> GetAllAsync();
        Task<OrderItemDto> GetByIdAsync(int id);



    }
}
