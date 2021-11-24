using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    public class Buses
    {
        string busnum;
        int routenum;
        string name;

        public string Busnum
        {
            get
            {
                return busnum;
            }

            set
            {
                if (value != null)
                {
                    busnum = value;
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value != null)
                {
                    name = value;
                }

            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{name} ");
            Console.WriteLine($"Number of the route:{routenum} ");
            Console.WriteLine($"Number of the bus:{busnum} ");
            
        }
    }
}
