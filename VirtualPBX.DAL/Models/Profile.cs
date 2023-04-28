namespace VirtualPBX.DAL.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }
        public int EmailId { get; set; }
        public Email? Email { get; set; }
    }
}