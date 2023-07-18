

using System;

namespace DistinktCharacters
{
    internal class Program
    {
        public static int NumOfDistinctChar(string input)
        {
            var str = "";
            foreach (var item in input)
            {
                str += str.Contains(item) ? "" : item; 
            }
            return str.Length;
        }
        public static string DistinktCharacter(int k, string s) {
            var length = s.Length;
            var result = "";
            for (var i=0; i<length -k; i++) {
                for (var j = i+k;j<=length;j++) {
                    var subString = s.Substring(i,j-i);
                    var numOfDistinctChar = NumOfDistinctChar(subString);
                    if ((subString.Length > result.Length) && (numOfDistinctChar <= k)) result = subString;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DistinktCharacter(2,"abcba"));
        }
    }
}