
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(70)]
        public string Name { get; set; } = null!;

        // TO DO: Relation with other table/s

        public virtual ICollection<Book> Books { get; set; }
    }
}
