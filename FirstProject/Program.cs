using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program 
    {
       
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            Fizzbuzz fizzbuzz = new Fizzbuzz();
            fibonacci.PrintFibonacciNumbers();
            fizzbuzz.PrintFizzBuzz();
            Console.ReadLine();
            
           
        }      
    }
}
