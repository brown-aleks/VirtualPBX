using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPBX.DAL.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LastName { get; set;}
        public List<Phone> Phones { get; set; } = new();
        public int ProfileId { get; set; }
        public Profile? Profile { get; set; }

        [Timestamp]
        public byte[]? Timestamp { get; set; }
    }
}
