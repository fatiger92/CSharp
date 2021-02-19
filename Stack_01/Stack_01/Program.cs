using System;
using System.Collections.Concurrent; // ConcurrentStack
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Stack_01
{
    class Program
    {
        #region 여기는 기본 Stack
        
        public static Stack<int> m_stack = new Stack<int>();
        static void Main(string[] args)
        {
            m_stack.Push(0);
            m_stack.Push(1);
            m_stack.Push(2);
            m_stack.Push(3);
            m_stack.Push(4);
            m_stack.Push(5);
            m_stack.Push(6);
            m_stack.Push(7);
            m_stack.Push(8);
            m_stack.Push(9);

            double val = m_stack.Pop(); // 9

            foreach (var element in m_stack)
            {
                // expected result = (bottom) 0, 1, 2, 3, 4, 5, 6, 7, 8 (top)
                Console.WriteLine($"현재 스택에 들어 있는 수 :: {element}"); 
            }

            Console.WriteLine($"방금 스택에서 뺀 수 {val}");
        }
        
        #endregion

        #region 여기는 ConcurrentStack
        /*
        static void Main(string[] args)
        {
            var conCurrentStack = new ConcurrentStack<int>();

            //데이터를 스택에 넣는 쓰레드
            Task tPush = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    conCurrentStack.Push(i);
                    Thread.Sleep(100);
                }
            });

            //데이터를 스택에서 읽는 쓰레드
            Task tPop = Task.Factory.StartNew(() =>
            {
                int n = 0;
                int result;

                while (n < 100)
                {
                    if (conCurrentStack.TryPop(out result))
                    {
                        Console.WriteLine(result);
                        n++;
                    }
                    Thread.Sleep(150);
                }
            });

            //두 쓰레드가 끝날 때까지 대기
            Task.WaitAll(tPush, tPop);
        }
        */
        #endregion

        #region conCurrentStack 테스트 
        /*
        public static ConcurrentStack<int> conCurrentStack = new ConcurrentStack<int>();
        static void Main(string[] args)
        {
            conCurrentStack.Push(0);
            conCurrentStack.Push(1);
            conCurrentStack.Push(2);
            conCurrentStack.Push(3);
            conCurrentStack.Push(4);
            conCurrentStack.Push(5);
            conCurrentStack.Push(6);
            conCurrentStack.Push(7);
            conCurrentStack.Push(8);
            conCurrentStack.Push(9);

            int result = 0;

            conCurrentStack.TryPop(out result); // 9

            foreach (var element in conCurrentStack)
            {
                // expected result = (bottom) 0, 1, 2, 3, 4, 5, 6, 7, 8 (top)
                Console.WriteLine($"현재 스택에 들어 있는 수 :: {element}");
            }
            Console.WriteLine($"현재 빼낸 것 :: {result}");
        }
        */
        #endregion
    }
}
