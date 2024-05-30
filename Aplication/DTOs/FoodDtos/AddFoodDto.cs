using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.DTOs.FoodDto
{
    public  class AddFoodDto
    {
        public string Name {  get; set; }  = string.Empty;
        public string Description { get; set; } = string.Empty ;
        public double Price {  get; set; }
        public int CategoryId {  get; set; }
        public Category Category { get; set; }  
        public List<OrderItem> OrderItems { get; set; }
    }
}
