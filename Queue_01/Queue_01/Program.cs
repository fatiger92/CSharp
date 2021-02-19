using System;
using System.Collections.Concurrent;
using System.Collections.Generic;


namespace Queue_01
{
    class Program
    {
        #region 일반적인 Queue 
        /*
        public static Queue<int> queue = new Queue<int>(); 
        static void Main(string[] args)
        {
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach (var element in queue)
            {
                Console.WriteLine($"현재 큐에 들어있는 숫자 :: {element}");
            }

            int next = queue.Dequeue();
            Console.WriteLine($"첫번째로 제거한 숫자 :: {next}");

            next = queue.Dequeue();
            Console.WriteLine($"두번째로 제거한 숫자 :: {next}");

            foreach (var element in queue)
            {
                Console.WriteLine($"Dequeue 후에 큐에 들어있는 숫자 :: {element}");
            }
        }
        */
        #endregion

        public static ConcurrentQueue<int> conCurQueue = new ConcurrentQueue<int>();
        static void Main(string[] args)
        {
            conCurQueue.Enqueue(10);
            conCurQueue.Enqueue(11);
            conCurQueue.Enqueue(12);
            conCurQueue.Enqueue(13);

            foreach (var element in conCurQueue)
            {
                Console.WriteLine($"현재 conCurQueue에 들어있는 수 :: {element}");
            }

            int result = 0;
            conCurQueue.TryDequeue(out result);

            Console.WriteLine($"\n현재 conCurQueue에서 제거한 수 :: {result}\n");

            foreach (var element in conCurQueue)
            {
                Console.WriteLine($"TryDequeue 후 conCurQueue에 들어있는 수 :: {element}");
            }
        }
    }
}
