using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

namespace Ticket_Management_Application.Modules
{
  
    public class TicketService : ITicketService
    {
        public string constr = "Data Source=DESKTOP-MLHRI2K; Initial Catalog= Db_supportTicket; Integrated Security=true";
        private List<Ticket> tickets = new List<Ticket>();
        private int nextTicketId = 1;
        private int ticketCounter;

        public void CreateTicket(Ticket ticket)
        {
            
            ticket.TicketNo = GenerateUniqueTicketNo();

         
            tickets.Add(ticket);
        }

        private int GenerateUniqueTicketNo()
        {
            throw new NotImplementedException();
        }

      


        public List<Ticket> GetTickets()
        {
            return tickets;
        }

        public Ticket GetTicketById(int id)
        
        {
            var ticket = tickets.FirstOrDefault(t => t.Id == id);
            if (ticket !=null) 
             return ticket;
                
            return new Ticket();
        }

        public void CreatedTicket(Ticket ticket)
        {
            ticket.Id = nextTicketId++;
            tickets.Add(ticket);
        }
       

        public void UpdateTicket(Ticket ticket)
        {
            var existingTicket = GetTicketById(ticket.Id);
            if (existingTicket != null)
            {
                existingTicket.Module = ticket.Module;
                existingTicket.Description = ticket.Description;
                existingTicket.DeveloperComment = ticket.DeveloperComment;
                existingTicket.TeamAssigned = ticket.TeamAssigned;
                existingTicket.IsClosed = ticket.IsClosed;
            }
        }

        public void ReassignTicket(int id, string teamAssigned)
        {
            var existingTicket = GetTicketById(id);
            if (existingTicket != null)
            {
                existingTicket.TeamAssigned = teamAssigned;
            }
        }

        public void ReopenTicket(int id)
        {
            var existingTicket = GetTicketById(id);
            if (existingTicket != null)
            {
                existingTicket.IsClosed = false;
            }
        }

        public void ResolveTicket(int id)
        {
            var existingTicket = GetTicketById(id);
            if (existingTicket != null)
            {
                existingTicket.IsClosed = true;
            }
        }

        public int GetNextTicketNo()
        {
            throw new NotImplementedException();
        }

        int ITicketService.GenerateUniqueTicketNo()
        {
            throw new NotImplementedException();
        }
      
    }
}
