using System;

namespace Problems
{
    public class  Program
    {
        static void Main(string[] args)
        {
            string test="Hello, there are five words!";

            string result=Prefix(test);
            Console.WriteLine(result);
        }

        public static string Prefix(string input)
        {            
            int length =input.Length;
            int wCount=input.Split(' ').Length;
            return $"{length},{wCount}:{input}";
        }
    }
}
