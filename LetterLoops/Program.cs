using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var typed = Console.ReadLine();

            var inputs = new List<String>()
            {
               typed
            };

            foreach(var input in inputs)
            {   
                var lowerCase = input.ToLower();
                  
                 for(int i = 0; i < lowerCase.Length; i++)
                 {
                    var letter = lowerCase[i];

                     for(int j = 0; j < i + 1; j++)
                     {
                        if(j == 0)
                        {
                            Console.Write(Char.ToUpper(letter));
                        }
                        else 
                        {
                            Console.Write(letter);
                        }
                        if(j == i)
                        {
                            Console.Write("-");
                        }

                     }
                 }     
            }
        Console.Write("\b \b");
        Console.ReadLine();
        }
    }
}
