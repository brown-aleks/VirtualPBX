using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPBX.DAL.Models
{
    public class Address
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Region { get; set; }
        [MaxLength(50)]
        public string? City { get; set; }
        [MaxLength(200)]
        public string? StreetAddress { get; set; }
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string? PostalCode { get; set; }
    }
}
