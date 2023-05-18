using System;
using System.Collections.Generic;

namespace StringCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<string> stringList = new List<string>()
            {
                new string("pedro"),
                new string("fachada"),
                new string("teste"),
                new string("pedro"),
                new string("programação")
            };
            Stack<string> stringStack = new Stack<string>()
            {
                new string("pedro"),
                new string("fachada"),
                new string("teste"),
                new string("pedro"),
                new string("programação")
            };
            Queue<string> stringQueue = new Queue<string>()
            {
                new string("pedro"),
                new string("fachada"),
                new string("teste"),
                new string("pedro"),
                new string("programação")
            };
            HashSet<string> stringHashSet = new HashSet<string>()
            {
                new string("pedro"),
                new string("fachada"),
                new string("teste"),
                new string("pedro"),
                new string("programação")
            };

            Console.WriteLine("This is the List's order");
            foreach(string s in stringList)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("This is the Stacks's order");
            foreach(string s in stringStack)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("This is the Queue's order");
            foreach(string s in stringQueue)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("This is the HashSet's order");
            foreach(string s in stringHashSet)
            {
                Console.WriteLine(s);
            }
        }
    }
}