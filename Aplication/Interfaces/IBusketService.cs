using Aplication.DTOs.BusketDtos;

namespace Aplication.Interfaces
{
    public  interface IBusketService
    {
        Task CreateAsync(AddBusketDto addBusketDto);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(AddBusketDto addBusketDto);
        Task<List<BusketDto>> GetAllAsync();

    }
}
