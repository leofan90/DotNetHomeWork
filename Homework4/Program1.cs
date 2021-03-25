using System;

namespace Homework4
{
    public class Node<T>{
        public Node<T> Next {get; set;}
        public T Data {get; set;}
        public Node(T t){
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>{
        private Node<T> head;
        private Node<T> tail;
        public GenericList(){
            tail = head = null;
        }
        public Node<T> Head{
            get => head;
        }
        public void Add(T t){
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void Foreach(GenericList<T> list, Action<GenericList<T>> action){
            action(list);
        }
    }
    class Program1
    {
        void Main(string[] args)
        {
            Action<GenericList<int>> printSum = list => {
            int sum = 0;
            Node<int> node = list.Head;
            do
            {
                sum += node.Data;
                node = node.Next;
            } while (node != null);
            Console.WriteLine(sum);
            };

            Action<GenericList<int>> printMax = list => {
            Node<int> node = list.Head;
            int max = node.Data;
            for ( ; node.Next != null; node = node.Next)
            {
                if (max < node.Next.Data)
                {
                    max = node.Next.Data;
                }
            }
            Console.WriteLine(max);
            };

            Action<GenericList<int>> printMin = list => {
            Node<int> node = list.Head;
            int min = node.Data;
            for ( ; node.Next != null; node = node.Next)
            {
                if (min > node.Next.Data)
                {
                    min = node.Next.Data;
                }
            }
            Console.WriteLine(min);
            };

            Action<GenericList<int>> printList = list => {
            Node<int> node = list.Head;
            for ( ; node.Next != null; node = node.Next)
            {
                Console.WriteLine(node.Data + "->");
            }
            };

            GenericList<int> intlist = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                intlist.Add(i);
            }

            intlist.Foreach(intlist, printMax);
            intlist.Foreach(intlist, printMin);
            intlist.Foreach(intlist, printSum);
            intlist.Foreach(intlist, printList);
        }
    }
}
