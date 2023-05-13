using SD_340_W22SD_Final_Project_Group6.Data;
using SD_340_W22SD_Final_Project_Group6.Models;
using X.PagedList;

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
    }
}
