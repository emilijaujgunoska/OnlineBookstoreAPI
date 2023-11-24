

using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Entities
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = null!;
        [StringLength(650)]
        public string? Description { get; set; }
        [StringLength(100)]
        public string? Country { get; set; }

        // To DO: Relation with other table/s

        public virtual ICollection<Book> Books { get; set; }
    }
}
