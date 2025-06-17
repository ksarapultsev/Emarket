using System.ComponentModel.DataAnnotations.Schema;

namespace EMarket.Models
{
    public class Sales
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int GoodsId { get; set; }

        public int Amount { get; set; }

        public decimal GoodsPrice { get; set; }

        public decimal FullPrice{ get; set; }

        public int UserId { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

    }
}
