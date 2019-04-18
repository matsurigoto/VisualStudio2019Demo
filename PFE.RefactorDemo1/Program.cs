using PFE.RefactorDemo1.Models;
using System;

namespace PFE.RefactorDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomer customer = new MyCustomer();
            DateTime now = DateTime.Now;
            int age = 10;
            string text = age.ToString();
            customer.CreatedOn = now;

            Console.WriteLine(text);
        }
    }
}

// DEMO for Clean code up and setting  
// DEMO for Code Style - var
// DEMO search when debug
