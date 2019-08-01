using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Fibonacci
    {
        private int startNumber;
        private int nextNumber;

        public void PrintFibonacciNumbers()
        {
            startNumber = 0;
            nextNumber = 1;

            for (int i = 0; i < 10; i++)
            {
   
                Console.Write(startNumber + ",");

                int sum = startNumber + nextNumber;

                startNumber = nextNumber;
                nextNumber = sum;

            }
            Console.WriteLine('\n');
        }
    }
}
