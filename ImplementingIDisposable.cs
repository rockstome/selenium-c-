using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ImplementingIDisposable i = new ImplementingIDisposable())
            {
                Console.WriteLine(i.ToString());
            }

            Console.ReadLine();
        }
    }

    public class ImplementingIDisposable : IDisposable
    {
        public override string ToString()
        {
            return "ToString method was called";
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose method was called");
        }
    }
}
