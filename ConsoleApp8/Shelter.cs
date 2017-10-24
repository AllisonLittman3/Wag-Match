using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wagMatch
{
    class Shelter
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int ShelterID { get; set; }

        public Shelter()
        {
            Console.WriteLine("Please register your shelter with Wag Match!\n");
            Console.Write("Please enter your shelter name: ");
            Name = Console.ReadLine() ;
            Console.WriteLine("Please enter your address. ");
            Console.Write("Street Address: ");
            StreetAddress = Console.ReadLine();
            Console.Write("City: ");
            City = Console.ReadLine();
            Console.Write("State:" );
            State = Console.ReadLine();
            Console.Write("Zip Code: ");
            ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your phone number: ");
            Phone = Console.ReadLine();
            Console.Write("Please enter your email: ");
            Email = Console.ReadLine();
           
        }

      
    }
}
