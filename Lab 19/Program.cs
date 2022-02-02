using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>();
            {
                new Computer() { Cod = 123, Name = "Самсунг", Processor = "Intel", Frequency = 2, AmountRAM = 8, HardDiskCapacity = 1000, Cost = 56000, Quantity = 2 };
                new Computer() { Cod = 456, Name = "Самсунг", Processor = "Core", Frequency = 4, AmountRAM = 16, HardDiskCapacity = 2000, Cost = 69000, Quantity = 1 };
                new Computer() { Cod = 789, Name = "HP", Processor = "Intel", Frequency = 4, AmountRAM = 4, HardDiskCapacity = 1500, Cost = 65000, Quantity = 3 };
                new Computer() { Cod = 987, Name = "Lenovo", Processor = "Core", Frequency = 2, AmountRAM = 8, HardDiskCapacity = 1000, Cost = 98000, Quantity = 1 };
                new Computer() { Cod = 654, Name = "Asus", Processor = "Intel", Frequency = 4, AmountRAM = 16, HardDiskCapacity = 2000, Cost = 75000, Quantity = 4 };
                new Computer() { Cod = 321, Name = "Apple", Processor = "Intel", Frequency = 2, AmountRAM = 8, HardDiskCapacity = 1000, Cost = 150000, Quantity = 1 };
                new Computer() { Cod = 234, Name = "Самсунг", Processor = "Core", Frequency = 4, AmountRAM = 8, HardDiskCapacity = 2000, Cost = 61000, Quantity = 1 };
            };

            Console.WriteLine("Введите тип процессора");
            string processor = Console.ReadLine();
            List<Computer> computers1=computers.Where(x=>x.Processor==processor).ToList();
            Print(computers1);

            Console.WriteLine("Введите объем оперативной памяти");
            int amountRAM = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.AmountRAM >= amountRAM).ToList();
            Print(computers2);

            List<Computer> computers3 = computers.OrderBy(x => x.Cost).ToList();
            Print(computers3);

            IEnumerable < IGrouping < string, Computer>> computers4=computers.GroupBy(x => x.Processor);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach(Computer e in gr)
                {
                    Console.WriteLine($"{e.Cod} {e.Name} {e.Processor} {e.Frequency} {e.AmountRAM } {e.HardDiskCapacity} {e.Cost} {e.Quantity}");
                }
            }

            Computer computer5 = computers.OrderByDescending(x => x.Cost).FirstOrDefault();
            Console.WriteLine($"{computer5.Cod} {computer5.Name} {computer5.Processor} {computer5.Frequency} {computer5.AmountRAM } {computer5.HardDiskCapacity} {computer5.Cost} {computer5.Quantity}");
            
            Computer computer6 = computers.OrderBy(x => x.Cost).FirstOrDefault();
            Console.WriteLine($"{computer5.Cod} {computer6.Name} {computer6.Processor} {computer6.Frequency} {computer6.AmountRAM } {computer6.HardDiskCapacity} {computer6.Cost} {computer6.Quantity}");


            
            Console.WriteLine(computers.Any(x => x.Quantity > 30));

            Console.ReadKey();

        }

        static void Print(List<Computer> computers)
        {
            foreach (Computer e in computers)
                Console.WriteLine( $"{e.Cod} {e.Name} {e.Processor} {e.Frequency} {e.AmountRAM } {e.HardDiskCapacity} {e.Cost} {e.Quantity}");
        }
    }
}
