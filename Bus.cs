using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus();
            Console.WriteLine("Please enter the colour");
            bus1.setColour(Console.ReadLine());

            Console.WriteLine("Please enter the registration number");
            bus1.setRego(Console.ReadLine());

            Console.WriteLine("Please enter amount of doors");
            bus1.setDoors (int.Parse (Console.ReadLine()));

            Console.WriteLine("Please enter amount of seats");
            bus1.setSeats (int.Parse (Console.ReadLine()));

            Console.WriteLine();


            Console.WriteLine($" Colour:{bus1.getColour()}  \n Registration:{bus1.getRego()} \n Number of Doors:{bus1.getDoors()} \n Number of Seats: {bus1.getSeats()}");
            Console.WriteLine();

            Console.WriteLine("Thanks maaaaaaaaaaaaaate!");
            Console.ReadLine();
        }
    }


    class Bus
    {
        string colour;
        string rego;
        int doors;
        int seats;


        public string getColour()
        {
            return colour;
        }

        public void setColour(string col)
        {
            colour = col;
        }

        public string getRego()
        {
            return rego;
        }

        public void setRego(string reg)
        {
            rego = reg;
        }

        public float getDoors()
        {
            return doors;
        }

        public void setDoors(int door)
        {
            doors = door;
        }

        public float getSeats()
        {
            return seats;
        }

        public void setSeats(int seat)
        {
            seats = seat;
        }
    }
}