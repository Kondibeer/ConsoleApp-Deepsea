using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Deepsea
{
    internal class Person
    {
        public enum EnumGender { Female, Male, Other }//
        public string Name { get; set; }//
        public string Email { get; set; }//
        public string Phone { get; set; }//
        public EnumGender Gender { get; set; } = Person.EnumGender.Other;
        public string Desription { get; set; }
        public int Cabin { get; set; }
        public bool Onboard { get; set; }
        public DateTime DoB { get; set; }//

        //
        public int Age()
        {
            //TimeSpan t = DateTime.Now - DoB;//

            //DateTime dt = new DateTime(t.Ticks);

            //int age = dt.Year;

            //return age;
            DateTime checkDT = new DateTime(DateTime.Now.Year, DoB.Month, DoB.Day);
            int age = DateTime.Now.Year - DoB.Year;
            if (DateTime.Now > checkDT) age++;
            return age;
        }
    }
}
