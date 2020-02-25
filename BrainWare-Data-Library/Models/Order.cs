using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web.Script.Serialization;

namespace BrainWare.Data.Library.Models
{
    [Table("Order")]
    public class Order
    {        
        [Key]
        public int Order_Id { get; set; }

        public int Company_id { get; set; }
        [ScriptIgnore]
        public Company Company { get; set; }

        public string Description { get; set; } = string.Empty;

        public decimal OrderTotal => OrderProducts.Sum(o => o.Price * o.Quantity);

        public virtual IList<OrderProduct> OrderProducts { get; set; }
    }
}