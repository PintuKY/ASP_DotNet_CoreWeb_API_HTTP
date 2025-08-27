using System.Net.Sockets;
using Web_based_ticket_management_WebAPI.AppDB;
using Web_based_ticket_management_WebAPI.Model;
using Web_based_ticket_management_WebAPI.Service;

namespace Web_based_ticket_management_WebAPI.Repositories
{
    public class TicketRepository : ITicket
    {
        private readonly AppDatabaseContex _DbContexts;
        public TicketRepository(AppDatabaseContex dbcontext)
        {
            _DbContexts = dbcontext;
        }
        public Task<IEnumerable<TaskTicket>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<TaskTicket>>(_DbContexts.TaskTickets);
        }
        public async Task<TaskTicket> GetByIdAsync(int id)
        {
            return await _DbContexts.TaskTickets.FindAsync(id);
        }
        public async Task AddAsync(TaskTicket ticket)
        {
            _DbContexts.TaskTickets.Add(ticket);
            await _DbContexts.SaveChangesAsync();

        }
        public async Task UpdateAsync(TaskTicket ticket)
        {
            _DbContexts.TaskTickets.Update(ticket);
            await _DbContexts.SaveChangesAsync();

        }
        public async Task<bool> DeleteAsync(int id)
        {
            var ticket = await _DbContexts.TaskTickets.FindAsync(id);
            if (ticket == null)
                return false;

            _DbContexts.TaskTickets.Remove(ticket);
            await _DbContexts.SaveChangesAsync();
            return true;
        }
    }
}
