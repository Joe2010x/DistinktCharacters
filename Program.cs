

using System;

namespace DistinktCharacters
{
    internal class Program
    {
    
        public static int DistinktCharacter(int k, string s) {
            return s.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DistinktCharacter(2,"bcb"));
        }
    }
}