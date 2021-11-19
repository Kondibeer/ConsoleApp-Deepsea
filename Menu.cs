using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Deepsea
{
    internal class Menu
    {
        Data data = new Data();
        public Menu() 
        {
            // Her starter vi menu systemet
            
            MenuSwitch();

        
        }

        private void MenuSwitch() 
        {
            //Vi laver en forside
            Console.WriteLine("M*E*N*U\n \n");
            Console.WriteLine("Tilmeld brugerr\t Opkøb billet");
        
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Console.WriteLine("Besætning");
                    break;
                case "2":

                    Passenger p = Pass();
                    data.PassengerList.Add(p);
                    Console.WriteLine("Passager");
                    break ;
                    case "3":
                    Console.WriteLine("Billet");
                    Ticket ticket =GetTicket();
                    break;
                case "4":
                    Console.WriteLine("Show list");
                    Passenger p1 = Pass();
                    data.PassengerList.Add(p1);
                    break;
                case "5":
                    Console.WriteLine("Tilbage til menu");
                    break;

                default:
                    break;
            }


        //Opretter passager og billeter
        
        
        }
        //Input
        private Passenger Pass()
        {

            Passenger passenger = new Passenger();
            Console.WriteLine("Name: ");
            passenger.Name = Console.ReadLine();
            Console.WriteLine("Des: ");
            passenger.Desription = Console.ReadLine();
            Console.WriteLine("");
            passenger.Id = Console.ReadLine();
            foreach (var g in Enum.GetValues(typeof(Person.EnumGender)))
            { 
                Console.WriteLine((int)g + g.ToString()); 
            }
            Console.WriteLine("Gender: ");
            passenger.Gender=(Person.EnumGender)(int.Parse(Console.ReadLine()));

            passenger.Cabin=int.Parse(Console.ReadLine());

            Console.WriteLine("Birth: ");
            passenger.DoB = DateTime.Parse(Console.ReadLine());

            return passenger;

        }
        private Ticket GetTicket()
        {
            Ticket ticket = new Ticket();
            Console.WriteLine("Select ticket: ");
            foreach(var tt in Enum.GetValues(typeof(Ticket.TicketType))) 
            { 
            
            Console.WriteLine((int)tt + "" + tt.ToString());

            }
            Console.Write("1F, 2S, 3E");
            ticket.Type=(Ticket.TicketType)int.Parse(Console.ReadLine());
            return ticket;

        }




        private Crew MakeCrew() 
        { 
        
        Crew crew = new Crew();
            Console.WriteLine("Crew names: ");
            crew.CrewId = Console.ReadLine();

            return crew;

        }

    }

}
