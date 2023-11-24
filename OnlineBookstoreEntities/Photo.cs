using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Entities
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Url { get; set; } = null!;
        [StringLength(100)]
        public string? Description { get; set; }

        public DateTime DateAdded { get; set; }

        public bool isMain { get; set; }  //dali e cover slika

        
    }
}
