using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        class Complex
        {
            public int a, b;

            public Complex(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public Complex add(Complex c)
            {
                Complex p = new Complex(this.a + c.a, this.b + c.b);
                return p;
            }

            public void Write()
            {
                Console.WriteLine(this.a + "/" + this.b);
            }
        }

        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(1, 3);
            Complex c = a.add(b);
            c.Write();
            Console.ReadKey();    
        }
    }
}
