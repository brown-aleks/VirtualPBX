using Microsoft.EntityFrameworkCore;
using VirtualPBX.DAL.Models;

namespace VirtualPBX.DAL.DataAccess
{
    public interface IApplicationContext
    {
        DbSet<Address> Addresses { get; set; }
        DbSet<CallLog> CallLogs { get; set; }
        DbSet<Email> Emails { get; set; }
        DbSet<Person> People { get; set; }
        DbSet<Phone> Phones { get; set; }
        DbSet<Profile> Profiles { get; set; }
        DbSet<Rate> Rates { get; set; }
    }
}