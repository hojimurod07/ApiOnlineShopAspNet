using Domain.Entities;

namespace Aplication.DTOs.BusketDtos
{
    public class AddBusketDto
    {
        public int UserId {  get; set; }    
        public User User { get; set; }
        public double TotalPrce { get; set; } 
    }
}
