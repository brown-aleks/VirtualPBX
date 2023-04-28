using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPBX.DAL.DataAccess
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=VirtualPBX;Username=postgres;Password=admin");
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
