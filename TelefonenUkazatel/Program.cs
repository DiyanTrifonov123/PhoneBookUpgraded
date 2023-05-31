using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonenUkazatel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count: ");
            int n = int.Parse(Console.ReadLine());
            AddressEntry[] addressEntries = new AddressEntry[n];

            for (int i = 0; i < n; i++)
            {
                AddressEntry address = new AddressEntry();
                address.Input();
                addressEntries[i] = address;
            }

            foreach (var item in addressEntries)
            {
                item.Output();
            }
        }
    }
}
