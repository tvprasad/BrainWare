using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Script.Serialization;

namespace BrainWare.Data.Library.Models
{
    [Table("OrderProduct")]
    public class OrderProduct
    {
        public int Order_Id { get; set; } = 0;
        public int Product_Id { get; set; } = 0;

        public Product Product { get; set; }
        [ScriptIgnore]
        public Order Order { get; set; }

        public int Quantity { get; set; } = 0;

        public decimal Price { get; set; } = decimal.Zero;
    }
}