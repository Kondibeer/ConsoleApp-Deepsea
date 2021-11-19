using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Deepsea
{
    internal class Ticket
    {
        public enum Ports {Bangkok, Hongkong, Singapore }
        public Ports Origin { get; set; } = Ports.Bangkok;
        public Ports Des { get; set; } = Ports.Bangkok;
        public enum TicketType { First, Second, Economy}
        public TicketType Type { get; set; } = TicketType.Economy;
        public DateTime Depart { get; set; }
        public DateTime Arrive { get; set; }
        public int TicketId { get; set; }
        public int CabinNr { get; set; }
        public bool Schedule { get; set; }


    }
}
