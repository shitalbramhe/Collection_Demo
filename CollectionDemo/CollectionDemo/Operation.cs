using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Operation
    {
        public static void Demo()
        {
            Console.WriteLine("\nIn Demo");
            List<string> list = new List<string>();
            list.Add("shital");
            list.Add("sanket");
            list.Add("ashish");
            list.Add("swara");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
        public static void Stackdemo()
        {
            Console.WriteLine("\nIn Stackdemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("amit");
            stack.Push("aakash");
            stack.Push("amit");
            stack.Push("naveen");
            string pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element:" + pop);
        }
        public static void Queuedemo()
        {
            Console.WriteLine("\nIn Queuedemo");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("harsha");
            queue.Enqueue("praju");
            queue.Enqueue("geeta");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");


            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue =queue.Dequeue();
            Console.WriteLine("Dequeue element:"+dequeue);

            Console.WriteLine("\nIterating the queue elements after dequeue one element:");

            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
         }
        public static void SetDemo()
        {
            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Raj");
            set.Add("Rajesh");
            set.Add("Rakesh");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void DictionaryDemo()
        {
            Console.WriteLine("\nIn DictionaryDemo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(103, "Amitabh");

            Console.WriteLine("Access value using key(key=100):" + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary:");
            foreach(var element in dictionary)
            {
                Console.WriteLine("Key =" + element.Key + "& Value=" + element.Value);
            }

        }
    }
}
