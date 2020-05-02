using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var list = new LinkedList<int>();

          
            list.Add(1);
            list.Add(5);
            list.Add(17);
            list.Add(42);
            list.Add(-69);

           
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            list.Delete(17);

            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
