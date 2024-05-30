using Domain.Entities;

namespace Aplication.DTOs.OrderItemsDtos
{
    public class AddOrderItemDto
    {
        public int FoodId {  get; set; }
        public Food Food { get; set; }
        public int Amount { get; set; }
        public double Total_Price { get; set; } 
        public int BusketId { get; set; }   
        public Busket Busket { get; set; }
    }
}
