using System.Collections.Generic;

namespace Ticket_Management_Application.Modules
{
    public interface ITicketService
    {
        List<Ticket> GetTickets();
        int GetNextTicketNo();
        int GenerateUniqueTicketNo();
        void CreateTicket(Ticket ticket);
        Ticket GetTicketById(int id);
        void CreatedTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        void ReassignTicket(int id, string teamAssigned);
        void ReopenTicket(int id);
        void ResolveTicket(int id);
    }
}
