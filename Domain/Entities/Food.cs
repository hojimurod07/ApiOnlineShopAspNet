﻿

namespace Domain.Entities
{
    public class Food:BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price {  get; set; }
        public int CategoryId {  get; set; }
        public Category? Category { get; set; } 
        public List<OrderItem> OrderItems {  get; set; } = new List<OrderItem>();

    }
}
