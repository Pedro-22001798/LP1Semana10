using System;
using System.Collections.Generic;

namespace StringCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] arrayOfStrings = {"pedro", "teste", "fachada", "pedro", "programação"};
            List<string> stringList = new List<string>();
            Stack<string> stringStack = new Stack<string>();
            Queue<string> stringQueue = new Queue<string>();
            HashSet<string> stringHashSet = new HashSet<string>();

            foreach(string s in arrayOfStrings)
            {
                stringList.Add(s);
            }

            foreach(string s in arrayOfStrings)
            {
                stringStack.Push(s);
            }

            foreach(string s in arrayOfStrings)
            {
                stringQueue.Enqueue(s);
            }

            foreach(string s in arrayOfStrings)
            {
                stringHashSet.Add(s);
            }

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