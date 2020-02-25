using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrainWare.Data.Library.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int Company_Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public IList<Order> Orders { get; set; }
    }
}
