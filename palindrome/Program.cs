using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] name = new char[1];

            start:
            for (int i = 0; i < name.Length; i++)
            {
                
                Console.WriteLine("Enter a name:");
                name[i] = Console.ReadLine();
            }

            Array.Reverse(name);
            string backward = new string(name);



          



            Console.ReadLine();

            


            /*string name;
            string backwardsName;

            start:
            Console.WriteLine("Please enter a name: ");
            name = Console.ReadLine();

            
            backwardsName = new string(name.Reverse().ToArray());*/

            /*if (name == backwardsName)
            {
                Console.WriteLine($"{name} is a palindrome \n");
            }

            else
            {
                Console.WriteLine($"{name} is NOT a palindrome \n");
            }*/

            goto start;

            

        }
    }
}
