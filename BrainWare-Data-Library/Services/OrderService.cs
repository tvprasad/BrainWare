using BrainWare.Data.Library.Interfaces;
using BrainWare.Data.Library.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace BrainWare.Data.Library.Services
{
    public class OrderService : IEntityBaseService<Order>, IOrderService
    {
        private readonly DBContext _context;
        public OrderService(DBContext context)
        {
            _context = context;
        }
        public List<Order> GetOrdersForCompany(int companyId)
        {
            var orders = _context.Orders
                     .Include(c => c.Company)
                     .Include(c => c.OrderProducts)
                     .ThenInclude(o => o.Product)
                     //.Where(o=>o.Company_id ==companyId)
                     .ToList();

            return orders;
        }
    }
}
