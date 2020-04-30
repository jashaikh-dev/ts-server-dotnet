using System;
namespace ts_models.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TicketStatus Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EstimateDue { get; set; }
        public DateTime ClosedDate { get; set; }
    }
}