using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    public class Parking
    {
        int amount;
        string title;
        int level;

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
                Console.WriteLine("Bus on the route!");
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

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (value != null)
                {
                    title = value;
                }

            }
        }

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                if (value > 0 && value < int.MaxValue)
                {
                    level = value;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Amount of buses on the parking:{amount} ");
            Console.WriteLine($"Title of parking:{title} ");
            Console.WriteLine($"Level of parking:{level} ");
        }
    }
}
