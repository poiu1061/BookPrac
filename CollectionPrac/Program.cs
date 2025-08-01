using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CollectionPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stack.push() : object형식의 데이터를 저장할 수 있다.
            //stack.pop() : 저장된 데이터를 pop()메서드로 읽어올 수 있음 마지막에 넣은 데이터부터 읽어온다.
            //stack.peek() : 저장된 데이터를 읽지만 pop처럼 제거하지않아 스택에 데이터를 넣고 계속해서 사용만 할 때는 peek()메서드를 사용하는게 좋다
            #region stack 활용해보기
            Stack stack = new Stack();

            stack.Push("첫번째");
            stack.Push("두번째");
            stack.Push("세번째");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            try
            {
                Console.WriteLine(stack.Pop());
            }
            catch(Exception ex)
            {
                Console.WriteLine($"예외 내용 : {ex.Message}");
            }
            #endregion

            #region queue 활용해보기
            //queue는 stack과 다르게 fifo(first in first out) 즉 선입선출방식이다.
            //queue.enqueue : 데이터를 저장하는 함수
            //queue.denqueue : 데이터를 호출하는 함수

            var queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            #endregion

            #region arrayList 활용해보기
            ArrayList list = new ArrayList();
            list.Add("C#");
            list.Add("TypeScript");

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
            #endregion

            #region Hashtable 활용해보기
            Hashtable hash = new Hashtable();

            hash[0] = "닷넷코리아";
            hash["닉네임"] = "레드플러스";
            hash["사이트"] = "비주얼아카데미";

            foreach(object o in hash.Keys)
            {
                Console.WriteLine(hash[o]);
            }
            #endregion

        }
    }
}
