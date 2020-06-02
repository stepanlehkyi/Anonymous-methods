using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Create an anonymous method that takes a string as its argument and returns the string in reversed order.

Examples

Reverse("Hello World") ➞ "dlroW olleH"

Reverse("The quick brown fox.") ➞ ".xof nworb kciuq ehT"

Reverse("Edabit is really helpful!") ➞ "!lufpleh yllaer si tibadE“
*/
namespace Anonymous_Type
{
    public delegate string Reverse(string word);
    class Program
    {

        static void Main(string[] args)
        {
            Reverse reverse = delegate (string word)
            {
                return new string(word.Reverse().ToArray());
            };
            string test1 =  reverse("Hello World");
            string test2 = reverse("The quick brown fox.");
            string test3 = reverse("Edabit is really helpful!");
            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(test3);
        }
    }
}
