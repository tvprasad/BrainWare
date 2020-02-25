using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Script.Serialization;

namespace BrainWare.Data.Library.Models
{
    /// <summary>
    /// Produce Model
    /// </summary>
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Product_Id { get; set; } = 0;

        public string Name { get; set; }

        public decimal Price { get; set; } = decimal.Zero;
        [ScriptIgnore]
        public IList<OrderProduct> OrderProducts { get; set; }

    }

}