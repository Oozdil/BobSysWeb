using BobSysWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BobSysWeb.Data
{
    public class WematchDbContext : DbContext
    {
        public WematchDbContext(DbContextOptions<WematchDbContext> options) : base(options)
        {
        }

        public DbSet<DatabaseDetailModel> DatabaseDetailModels { get; set; }
    }
}
