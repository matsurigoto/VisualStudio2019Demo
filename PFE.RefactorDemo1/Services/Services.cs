using System;
using System.Collections.Generic;
using System.Text;

namespace PFE.RefactorDemo1.Services
{
    public class Services
    {
        public string GetSomeString(string one, string two, string three)
        {
            return one + two + three;
        }
    }
}

/* DEMO for Interface and pull member up
 * DEMO for Linq and remove Unused code
             List<string> strings = new List<string>() { one, two, three };
            IEnumerable<string> enumerable()
            {
                foreach (var str in strings)
                {
                    if (str.Length < 3)
                    {
                        yield return str;
                    }
                }
            }   
*/

