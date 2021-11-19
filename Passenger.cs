using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Deepsea
{

    


    internal class Passenger : Person
    {

        public Passenger()
        {

            Pass = DateTime.Now;
            return;
        }


        // public enum EnumGender { Female, Male, Other }//
        //public EnumGender Gender { get; set; }
        public enum Ports { Ports, Hongkong, Singapore, }
        public Ports Gender { get; set; } = Ports.Singapore;
        public DateTime Pass { get; set; }//
        public string Id { get; set; }//
        public string PetCheck { get; set; }//
        
        
    }
    internal class Pet
    {
        public string PetName { get; set; }
        public string Type { get; set; }

    }

}
