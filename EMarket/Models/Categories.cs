using System.ComponentModel.DataAnnotations.Schema;

namespace EMarket.Models
{
    public class Categories
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? RootId { get; set; }

        public required string Name{ get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
