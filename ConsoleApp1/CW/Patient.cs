using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CW
{
    public class Patient
    {
        //fields
        public float fee;

        //PROPERTIES
        public int MRN { get; set; }
        public string name { get; set; }
        public byte age { get; set; }
        public float height { get; set; }


        //CONSTRUSTOR
        public Patient(int MRN, string name, byte age, float height)
        {
            this.MRN = MRN;
            this.name = name;   
            this.age = age;
            this.height = height;

        }

        public Patient() { } //multiple constructor here with different signature(parameter);; this is called constructor overloading
       
        //DECTRUCTOR
        ~Patient() { }

        //METHODS
        public void connsultant() {
            Console.WriteLine($"{this.name} is  consuling");
        }
    }
}
