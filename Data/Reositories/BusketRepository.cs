using Data.DbContexts.AppDbContext;
using Data.Interfaces;
using Domain.Entities;

namespace Data.Reositories
{
    public class BusketRepository(AppDbContext dbContext):Repository<Busket>(dbContext),IBusketInterface
    {

    }
}
