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
        public DbSet<EstablishmentCategory> Categorys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<EstablishmentBusinness> EstablishmentBusinness { get; set; }
        public DbSet<EstablishmentServices> Services { get; set; }
        public DbSet<Schedules> Schedules { get; set; }
        public DbSet<EstablishmentAddress> EstablishmentAddresses { get; set; }
        public DbSet<UserSchedule> UserSchedules { get; set; }

    }
}
