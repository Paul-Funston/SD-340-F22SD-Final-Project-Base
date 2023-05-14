using SD_340_W22SD_Final_Project_Group6.Data;
using SD_340_W22SD_Final_Project_Group6.Models;
using X.PagedList;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SD_340_W22SD_Final_Project_Group6.BLL
{
    public class TicketBL
    {
        private readonly IRepository<Ticket> _ticketRepository;
        public TicketBL(IRepository<Ticket> ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public async Task<ICollection<Ticket>> GetAllTickets()
        {
            return await _ticketRepository.GetAll().ToListAsync();
        }
        public async Task<Ticket> GetTicketWithDetails(int id)
        {
            return await _ticketRepository.GetAll()
                .Include(t => t.Project)
                .Include(t => t.TicketWatchers)
                .ThenInclude(tw => tw.Watcher)
                .Include(u => u.Owner)
                .Include(t => t.Comments)
                .ThenInclude(c => c.CreatedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
