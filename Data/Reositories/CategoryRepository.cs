using Data.DbContexts.AppDbContext;
using Data.Interfaces;
using Domain.Entities;

namespace Data.Reositories
{
    public class CategoryRepository(AppDbContext dbContext):Repository<Category>(dbContext),ICategoryInterface
    {

    }
}
