using System;
using System.Collections;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList objArray = new ArrayList();
            objArray.Add("Nguyen");
            objArray.Add("Tran");
            objArray.Add("Van");
            objArray.RemoveAt(2);
            objArray.Insert(2, "Will");
            Console.WriteLine("Capacity: "+objArray.Capacity);
            Console.WriteLine("Count: "+objArray.Count);
            Console.WriteLine();
            Console.WriteLine("Element of the ArrayList:");
            foreach (string item in objArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 0; i < objArray.Count; i++)
            {
                Console.WriteLine(objArray[i]);
            }
            objArray.Sort

        }
    }
}
