

using Data.DbContexts.AppDbContext;
using Data.Interfaces;

namespace Data.Reositories
{
    public class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
    {
        private readonly AppDbContext _dbContext = dbContext;

        public IUserRepository UserRepository => new UserRepository(_dbContext);    

        public ICategoryInterface CategoryInterface => new CategoryRepository(_dbContext);
        public IFoodRepository FoodRepository => new FoodRepository(_dbContext);

        public IOrderItemInterface OrderItemInterface => new OrderItemRepository(_dbContext);

        public IBusketInterface BusketInterface => new BusketRepository(_dbContext);
    }
}
