

using Data.DbContexts.AppDbContext;
using Data.Interfaces;
using Domain.Entities;

namespace Data.Reositories
{
    public class FoodRepository(AppDbContext dbContext):Repository<Food>(dbContext),IFoodRepository
    {
    }
}
