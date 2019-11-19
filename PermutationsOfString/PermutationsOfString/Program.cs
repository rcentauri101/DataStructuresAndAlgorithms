using System;
using System.Collections.Generic;

namespace PermutationsOfString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<String> perms = PermOfString("abcde");
            foreach (String s in perms)
                Console.WriteLine(s);

            Console.WriteLine($"Total number of permutations = {perms.Count}");
            Console.ReadLine();
        }

        private static List<string> PermOfString(String s)
        {
            if(s.Length == 1)
                return new List<string>() { s };


            String firstChar = s.Substring(0, 1);
            List<String> perms = PermOfString(s.Substring(1));

            List<String> retList = new List<string>();
            foreach (string perm in perms)
            {
                for (int i = 0; i < perm.Length + 1; i++)
                {
                    String completePerm = InsertCharAt(firstChar, perm, i);
                    retList.Add(completePerm);
                }
            }

            return retList;
        }

        private static String InsertCharAt(String charToInsert, String source, int position)
        {
            if (position == 0)
                return charToInsert + source;
            else
                return source.Substring(0, position) + charToInsert + source.Substring(position);
        }
    }
}
