using System;
using System.Collections.Generic;
using System.Linq;
namespace StudenTask
{
    class Program
    {
        public static string choice { get; private set; }

        static void Main(string[] args)
        {
            Dictionary<string, double> anar = new Dictionary<string, double>()
            {
                ["Mathematics"] = 4,
                ["Physics"] = 3,
                ["English"] = 3,
                ["Chemistry"] = 5
            };
            Dictionary<string, double> javid = new Dictionary<string, double>()
            {
                ["Mathematics"] = 5,
                ["Physics"] = 5,
                ["English"] = 5,
                ["Chemistry"] = 5
            };
            Dictionary<string, double> vugar = new Dictionary<string, double>()
            {
                ["Mathematics"] = 5,
                ["Physics"] = 3,
                ["English"] = 3,
                ["Chemistry"] = 3
            };

            Dictionary<string, double> ayaz = new Dictionary<string, double>()
            {
                ["Mathematics"] = 2,
                ["Physics"] = 3,
                ["English"] = 3,
                ["Chemistry"] = 4,
            };

            Dictionary<string, double> mahammad = new Dictionary<string, double>()
            {
                ["Mathematics"] = 4,
                ["Physics"] = 4,
                ["English"] = 4,
                ["Chemistry"] = 5,
            };
            Dictionary<string, Dictionary<string, double>> School = new Dictionary<string, Dictionary<string, double>>()
            {

                ["Anar"] = anar,
                ["Vugar"] = vugar,
                ["Ayaz"] = ayaz,
                ["Javid"] = javid,
                ["Mahammad"] = mahammad
            };

            Console.WriteLine("To search by name enter 1");
            Console.WriteLine("To search by avarage mark enter 2");
            Console.Write("Please enter the number: ");
            string condouble = Console.ReadLine();
            int choice;
            bool parsed = int.TryParse(condouble, out choice);
            if (choice == 1)
            {
                Console.Write("Please enter the Name: ");

                string search = Console.ReadLine();

                foreach (KeyValuePair<string, Dictionary<string, double>> item in School)
                {

                    if (item.Key.EndsWith(search.TrimStart('*'), StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("--------------------");
                        Console.WriteLine($"{item.Key}");
                        foreach (KeyValuePair<string, double> a in item.Value)
                        {
                            Console.WriteLine($"{a.Key}: {a.Value}");
                        }
                        double sum = 0;
                        foreach (KeyValuePair<string, double> b in item.Value)
                        {
                            sum = (sum + b.Value);
                        }
                        Console.WriteLine($"Avarage Mark: {sum / 4}");
                    }

                    else if (item.Key.StartsWith(search.TrimEnd('*'), StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("--------------------");
                        Console.WriteLine($"{item.Key}");
                        foreach (KeyValuePair<string, double> a in item.Value)
                        {
                            Console.WriteLine($"{a.Key}: {a.Value}");
                        }
                        double sum = 0;
                        foreach (KeyValuePair<string, double> b in item.Value)
                        {
                            sum = (sum + b.Value);
                        }
                        Console.WriteLine($"Avarage Mark: {sum / 4}");
                    }
                    else if ((search.StartsWith('*') && search.EndsWith('*')))
                    {
                        if (item.Key.Contains(search.Trim('*'), StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine("--------------------");
                            Console.WriteLine($"{item.Key}");
                            foreach (KeyValuePair<string, double> a in item.Value)
                            {
                                Console.WriteLine($"{a.Key}: {a.Value}");
                            }
                            double sum = 0;
                            foreach (KeyValuePair<string, double> b in item.Value)
                            {
                                sum = (sum + b.Value);
                            }
                            Console.WriteLine($"Avarage Mark: {sum / 4}");
                        }
                    }

                }

            }
            if (choice == 2)
            {
                foreach (KeyValuePair<string, Dictionary<string, double>> item in School)
                {
                    double sum = 0;
                    foreach (KeyValuePair<string, double> c in item.Value)
                    {
                        sum = (sum + c.Value);
                    }
                    if (sum / 4 > 4)
                    {
                        Console.WriteLine("--------------------");
                        Console.WriteLine(item.Key);
                        foreach (KeyValuePair<string, double> a in item.Value)
                        {
                            Console.WriteLine($"{a.Key}: {a.Value}");
                        }
                        Console.WriteLine($"Avarage Mark: {sum / 4}");
                    }
                    
                }

            }
            Console.ReadLine();
        }
    }
}