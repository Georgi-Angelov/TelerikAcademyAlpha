using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Students_and_workers
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker(150, 10);
            Console.WriteLine(worker.MoneyPerHour());
        }
    }
}
