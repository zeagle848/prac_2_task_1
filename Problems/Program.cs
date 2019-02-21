using System;

namespace Problems.Program
{
    public class  Program
    {
        static void Main(string[] args)
        {
            string test="Hello, there are five words!";

            Program s= new Program();
            string result=s.Prefix(test);
            Console.WriteLine(result);
        }

        public string Prefix(string input)
        {          
            if(input==null){return null;} 
            return $"{input.Length},{input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length}:{input}";        
        }
    }
}
