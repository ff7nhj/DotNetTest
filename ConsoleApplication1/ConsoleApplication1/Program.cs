using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        const string MyName = "Marci";
        static void Main(string[] args)
        {
            HelloWorld();
            
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello {0}!", MyName);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
    }
}
