namespace Ticket_Management_Application.Modules
{
    public class Ticket
    {
        public int Id { get; set; }
        public int TicketNo { get; set; }
        public string Module { get; set; }
        public string Description { get; set; }
        public string DeveloperComment { get; set; }
        public string TeamAssigned { get; set; }
        public bool IsClosed { get; set; }
        public string Owner { get; set; }
        public string OName {get; set;}
    }
}
