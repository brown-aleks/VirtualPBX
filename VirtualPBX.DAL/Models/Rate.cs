using System.ComponentModel.DataAnnotations;

namespace VirtualPBX.DAL.Models
{
    public class Rate
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public List<Phone> Phones { get; set; } = new();
    }
}