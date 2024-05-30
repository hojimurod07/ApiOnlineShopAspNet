

namespace Data.Interfaces
{
    public  interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        ICategoryInterface CategoryInterface { get; }
        IFoodRepository FoodRepository { get; }
        IOrderItemInterface OrderItemInterface { get; }
        IBusketInterface BusketInterface { get; }
    }
}
