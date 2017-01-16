using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"> arguments </param>
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
            Console.ReadKey();    
        }
    }
}
