using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Entities
{
   public class Order
    {
        [Key]
        public int Id { get; set; }

        // important!!
        public string UserId { get; set; } = null!;

        //to do: book details to add..

        #region Book Details
        [StringLength(100)]
        public string? BookAuthor { get; set; }
        [StringLength(100)]
        public string BookTitle { get; set; }
        [StringLength(100)]
        public string? BookCountry { get; set; }
        [StringLength(100)]

        public string? BookCategory { get; set; }
        [StringLength(100)]
        public string? BookType { get; set; }
        [StringLength(100)]
        public string? BookDimensions { get; set; }
        [StringLength(100)]
        public string? BookWeight { get; set; }
        [StringLength(100)]
        #endregion

        public string? Quantity { get; set; }

        public double Price { get; set; }

        public DateTime OrderDate { get; set; } 
        public DateTime ShippedDate { get; set; }

        public DateTime RequiredDate { get; set;}
    }
}
