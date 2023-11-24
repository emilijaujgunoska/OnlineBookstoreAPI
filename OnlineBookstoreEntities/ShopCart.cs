using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Entities
{
    public class ShopCart
    {
        [Key]
        public int Id { get; set; }

        public double Price { get; set; }

        public DateTime DateAdded { get; set; }

        // TO DO: Relation with other table/s + other properties
        [StringLength(100)]
        public string UserId { get; set; } = null!;

        public int BookId { get; set; }



       
    }
}
