using System.Net.Sockets;
using Web_based_ticket_management_WebAPI.Model;

namespace Web_based_ticket_management_WebAPI.Service
{
    public interface ITicket
    {
        Task<IEnumerable<TaskTicket>> GetAllAsync();
        Task<TaskTicket> GetByIdAsync(int id);
        Task AddAsync(TaskTicket ticket);
        Task UpdateAsync(TaskTicket ticket);
        Task<bool> DeleteAsync(int id);
    }
}
