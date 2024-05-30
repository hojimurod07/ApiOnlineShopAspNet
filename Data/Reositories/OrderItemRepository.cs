using Data.DbContexts.AppDbContext;
using Data.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Reositories
{
    public class OrderItemRepository(AppDbContext dbContext):Repository<OrderItem>(dbContext),IOrderItemInterface 
    {
    }
}
