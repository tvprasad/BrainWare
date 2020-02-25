using BrainWare.Data.Library.Models;
using System.Collections.Generic;

namespace BrainWare.Data.Library.Interfaces
{
    public interface IOrderService : IEntityBaseService<Order>
    {
        List<Order> GetOrdersForCompany(int companyId);
    }
}
