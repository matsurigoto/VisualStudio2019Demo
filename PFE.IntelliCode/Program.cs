using System;

namespace PFE.IntelliCode
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputService output = new OutputService();

            if (output.IsMorning())
            {
                Console.WriteLine(output.GetGoodMorning());
            }
            else
            {
                Console.WriteLine(output.GetGoodMorning());
            }
        }
    }
}
