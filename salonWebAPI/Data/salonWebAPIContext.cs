using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using salonWebAPI.Model;

namespace salonWebAPI.Data
{
    public class salonWebAPIContext : DbContext
    {
        public salonWebAPIContext (DbContextOptions<salonWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<salonWebAPI.Model.Client> Client { get; set; }
    }
}
