

namespace Domain.Entities
{
    public  class OrderItem:BaseEntity
    {
        public int FoodId {  get; set; }
        public Food? Food { get; set; }
        public int Amount { get; set; } 
        public double Total_price {  get; set; }
        public int BusketId {  get; set; }
        public Busket? Busket { get; set; }

    }
}
