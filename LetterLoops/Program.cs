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
            var output = "";
            var inputs = new List<Inputs>()
            {
                new Inputs {AlphaString = "abcd"},
                new Inputs {AlphaString = "RqaEzty"},
                new Inputs {AlphaString = "CwAt"}
            };

            foreach (var input in inputs)
            {
                foreach (var alpha in input.AlphaString)
                {
                    Console.WriteLine(alpha ++);
                };
            }

            Console.ReadLine();
        }
    }
}
