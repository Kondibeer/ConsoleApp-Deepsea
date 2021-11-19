using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Deepsea
{
    internal class Data
    {
        public Data()
        {

            Passenger passenger1=new Passenger();
            passenger1.Name = "Kurt";
            passenger1.Email = "MM@mail.dk";
            passenger1.Desription = "";
            passenger1.DoB = new DateTime(1933, 4, 21);
            passenger1.Gender = (Passenger.Ports)Person.EnumGender.Other;

            PassengerList.Add(passenger1);

            Ticket ticket1=new Ticket();
            ticket1.Origin = Ticket.Ports.Bangkok;
            ticket1.Depart = new DateTime(2021, 12, 01);
            ticket1.Arrive = new DateTime(2021, 12, 18);
            ticket1.Des = Ticket.Ports.Hongkong;
            ticket1.CabinNr = 666;
            ticket1.TicketId = 5;



        }

        public List<Ticket> TicketList { get; set; }
        public void ShowTicket()
        {

            foreach(Ticket ticket in TicketList)
            { 
            
            Console.WriteLine($"{ticket.Origin} + Depart {ticket.Depart}");
            
            }

        }

        public List<Passenger> PassengerList= new List<Passenger>();
        public void ShowPassList()
        {

            foreach (Passenger p in PassengerList)
            {

                Console.WriteLine($"Name: {p.Name} + Description: {p.Desription} + Gender: {p.Gender} + Age: {p.Age} + Email: {p.Email} + Phone: {p.Phone} + Cabin: {p.Cabin}" );
            
            }

        }
    }
}
