using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)

        {
            
                Console.Write("Enter text to see if its a palindrome:");
                string userinput = Console.ReadLine();
                Palindrome Pal = new Palindrome();
            try
            {
                Console.WriteLine(Pal.IsPalindrone(userinput));
            }
            catch
            {
                Console.WriteLine("There has been an Error");
            }
                do
                {
               
                    Console.WriteLine("Try Again or Exit");
                    userinput = Console.ReadLine();
                if (userinput == "exit")
                {
                    break;
                }

                Console.WriteLine(Pal.IsPalindrone(userinput));
                
                } while (userinput != "exit");
                
            

        }
       
    }
}
