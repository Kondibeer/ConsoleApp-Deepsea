using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Deepsea
{
    internal class Crew
    {

        public enum CrewRole {Captain, Helmsman, cook, sailors }
        public DateTime Shifts  { get; set; }
        //
        public string CrewId { get; set; }
        //
    }
}
