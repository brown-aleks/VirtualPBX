using System.ComponentModel.DataAnnotations;

namespace VirtualPBX.DAL.Models
{
    public class Phone
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(14)]
        public string? PhoneNumber { get; set; }
        public int RateId { get; set; }
        public Rate? Rate { get; set; }
        public List<CallLog> OutgoingCalls { get; set; } = new();
        public List<CallLog> IncomingCalls { get; set; } = new();

    }
}