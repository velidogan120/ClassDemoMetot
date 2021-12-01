using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Veli");
            myDictionary.Add(1, "Veli");
            myDictionary.Add(1, "Veli");
            myDictionary.Add(1, "Veli");
            Console.WriteLine(myDictionary.Count);
        }
    }    
}
