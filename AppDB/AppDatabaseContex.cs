using Microsoft.EntityFrameworkCore;
using Web_based_ticket_management_WebAPI.Model;

namespace Web_based_ticket_management_WebAPI.AppDB
{
    public class AppDatabaseContex : DbContext
    {
        public AppDatabaseContex(DbContextOptions<AppDatabaseContex> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskTicket> TaskTickets { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // any additional configuration
        }
    }
}
