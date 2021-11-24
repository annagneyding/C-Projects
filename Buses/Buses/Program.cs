using System;
using System.Collections.Generic;
using System.Text;

namespace Buses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Parking> parking = new List<Parking>();
            List<Route> route = new List<Route>();
            List<Buses> buses = new List<Buses>();

            int i = 0;
            int k = 1;

            do
            {
                Console.WriteLine("\n     CHOOSE ANY OPTION!");
                Console.WriteLine();
                Console.WriteLine("1.Create parking");
                Console.WriteLine("2.Create route");
                Console.WriteLine("3.Add bus on the parking"); 
                Console.WriteLine("4.Get information about parking");
                Console.WriteLine("5.Remove parking"); /////////////
                Console.WriteLine("6.Add car on the route"); 
                Console.WriteLine("7.Get information about route");
                Console.WriteLine("8.Get information about bus");
                Console.WriteLine();

                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1: // Создание парковки
                        Parking parking1 = new Parking();
                        parking1.Level = k;
                        Console.WriteLine("Level of parking: " + k);
                        Console.Write("Enter title: ");
                        parking1.Title = Console.ReadLine();
                        parking.Add(parking1);
                        break;

                    case 2: // Создание маршрута
                        Route route1 = new Route();    
                        Console.WriteLine("Enter number of the route: ");
                        route1.Routenum = Convert.ToInt32(Console.ReadLine());   
                        route.Add(route1);
                        break;

                    case 3: // Добавить автобус на парковку
                        Buses b1 = new Buses();
                        Console.Write("Enter level of the parking: ");
                        int lvl = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        foreach (var p in parking)
                        {
                            if (p.Level == lvl)
                            {
                                Console.WriteLine();
                                Console.Write("Enter number of the bus: ");
                                b1.Busnum = Console.ReadLine();
                                Console.Write("Enter number of the route: ");
                                b1.Routenum = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter name and lastname of driver: ");
                                b1.Name = Console.ReadLine();
                                Console.WriteLine();
                                p.Add(b1);
                                p.Amount++;
                            }
                        }
                        break;

                    case 4: // Получить информацию об автобусах на парковке
                        Console.WriteLine("Enter level of parking: ");
                        // if(g.Num = k)
                        int num = Convert.ToInt32(Console.ReadLine());
                        foreach (var p in parking)
                        {
                            if (p.Level == num)
                            {
                                Console.Write("Information about parking: ");
                                Console.WriteLine();
                                p.ShowInfo();
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 5: // Удаление
                        Console.WriteLine("Enter number of parking, which you would remove: ");
                        int numberg = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        for (int a = 0; a < parking.Count; a++)
                        {
                            if (parking[a].Level == numberg)
                            {
                                parking.RemoveAt(a);
                                break;
                            }
                        }
                        Console.Write("Parking is deleted!");
                        break;

                    case 6: // Добавить автобус на маршрут
                        Buses b2 = new Buses();
                        Console.Write("Enter number of route: ");
                        int numrt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        foreach (var r in route)
                        {
                            if (r.Routenum == numrt)
                            {

                                Console.Write("Enter number of the route: ");
                                b2.Routenum = Convert.ToInt32(Console.ReadLine());      
                                r.Add(b2);
                                r.Amount++;
                            }
                        }
                        break;

                    case 7: // Получить информацию об автобусах на маршруте 
                        Console.WriteLine("Enter number of the route:");
                        // if(g.Num = k)
                        int rtnum = Convert.ToInt32(Console.ReadLine());
                        foreach (var r in route)
                        {
                            if (r.Routenum == rtnum)
                            {
                                Console.WriteLine("Information about this route:");
                                Console.WriteLine();
                                r.ShowInfo();
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 8:
                        Console.WriteLine("Enter number of the bus:"); // Получить информацию об отдельном автобусе
                        string numbus = Console.ReadLine();
                        Console.WriteLine();
                        foreach (var b in buses)
                        {
                            if(b.Busnum == numbus)
                            {
                                Console.WriteLine("Information about bus:");
                                b.ShowInfo();
                                Console.WriteLine();
                            }
                        }
                        break;
                }
            } while (i != 9);
        }
    }
}
