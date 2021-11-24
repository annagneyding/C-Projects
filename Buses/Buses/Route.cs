using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    public class Route
    {
        int amount;
        int routenum;

        List<Buses> buses;
        public void Add(Buses b)
        {
            if (buses == null)
            {
                buses = new List<Buses>();
                // сделать удаление с маршрута
            }
            buses.Add(b);
        }

        public void remove(Buses b)
        {
            if (buses == null)
            {
                Console.WriteLine("Bus on parking!");
            }
            buses.Remove(b);
        }

        public void ShowParking()
        {
            foreach (Buses b in buses)
            {
                b.ShowInfo();
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                if (value > 0 && value < int.MaxValue)
                {
                    amount = value;
                }
            }
        }

        public int Routenum
        {
            get
            {
                return routenum;
            }

            set
            {
                if (value > 0 && value < int.MaxValue)
                {
                    routenum = value;
                }
            }
        }



        public void ShowInfo()
        {
            Console.WriteLine($"Amount of buses on the route:{amount} ");
            Console.WriteLine($"Number of bus route:{routenum} ");
        }
    }
}
