using System;
using Microsoft.EntityFrameworkCore;


namespace BookByIdApi.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {
        }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<EstablishmentCategory> Category { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
