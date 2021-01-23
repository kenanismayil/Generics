using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> employee = new MyDictionary<string>();
            employee.Add("Ahmet Ucar");
            employee.Add("Hatice Yilmaz");
            employee.Add("Sila Gunel");
            employee.Add("Engin Demirog");
            employee.Add("Kenan Ismayil");

            foreach (var worker in employee.Workers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine(employee.Length);


            Console.ReadLine();
        }
    }
}
