namespace Domain.Entities
{
    public  class Busket:BaseEntity
    {
        public int UserId { get; set; }
        public User? User { get; set; }
        public double Total_price { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
       

    }
}
