using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoublyLinkedList dList = new DoublyLinkedList();
            //dList.addNode(1);
            //dList.addNode(2);
            //dList.addNode(3);
            //dList.addNode(4);
            //dList.addNode(5);
            //LinkedList lnklist = new LinkedList();
            //lnklist.PrintAllNodes();
            //Console.WriteLine();

            //lnklist.AddAtLast(12);
            //lnklist.AddAtLast("John");
            //lnklist.AddAtLast("Peter");
            //lnklist.AddAtLast(34);
            //lnklist.PrintAllNodes();
            //Console.WriteLine();

            //lnklist.AddAtStart(55);
            //lnklist.PrintAllNodes();
            //Console.WriteLine();

            ////lnklist.RemoveFromStart();
            //lnklist.PrintAllNodes();

            //Console.ReadKey();
            Node root = null;
            Tree bst = new Tree();
            int Size = 200;
            int[] a = new int[Size];
            Random ran = new Random();
            for(int i = 0; i<Size; i++)
            {
                a[i] = ran.Next(10);
            }
            for(int i = 0; i<Size; i++)
            {
                root = bst.Insert(root, a[i]);
            }
        }
        //public class Node
        //{
        //    public Node Next;
        //    public object Data;
        //}
        //public class LinkedList
        //{
        //    public Node Head;
        //    public Node Current;
        //    public int count;
        //    public LinkedList()
        //    {
        //        Head = new Node();
        //        Current = Head;
        //    }
        //    public void AddAtLast(object data)
        //    {
        //        Node newNode = new Node();
        //        newNode.Data = data;
        //        Current.Next = newNode;
        //        Current = newNode;
        //        count++;
        //    }
        //    public void AddAtStart(object data)
        //    {
        //        Node newNode = new Node();
        //        newNode.Data = data;
        //        newNode.Next = Head.Next;
        //        Head.Next = newNode;
        //    }
        //    public void PrintAllNodes()
        //    {
        //        Node Current = Head;
        //        while(Current.Next != null)
        //        {
        //            Current = Current.Next;
        //            Console.WriteLine(Current.Data);
        //        }
        //        {
        //            Console.WriteLine("Null");
        //        }
        //    }
        //}

        //public class Node
        //{
        //    public Node Next;
        //    public object Data;
        //}
        //public class LinkedList
        //{
        //    public Node Head;
        //    public Node Current;
        //    public int count;
        //    public LinkedList()
        //    {
        //        Head = new Node();
        //        Head = Current;
        //    }
        //    public void AddAtStart(object data)
        //    {
        //        Node newNode = new Node();
        //        newNode.Data = data;
        //        newNode.Next = Head.Next;
        //        Head = newNode;
        //        count++;
        //    }
        //    public void AddAtLast(object data)
        //    {
        //        Node newNode = new Node();
        //        newNode.Data = data;
        //        Current.Next = newNode;
        //        Current = newNode;
        //        count++;



        //    }

        //}
        public class DoublyLinked
        {
            public DoublyLinked Next;
            public object Data;
            public DoublyLinked Prev;

        }
        public class DoublyLinkedList
        {
            public DoublyLinked Head = null;
            public DoublyLinked Tail = null;
            public DoublyLinkedList()
            {
                Head = new DoublyLinked();
                Tail = new DoublyLinked();
            }


            public void addNode(object data)
            {
                DoublyLinked newNode = new DoublyLinked();
                newNode.Data = data;
                if (Head == null)
                {
                    Head = Tail = newNode;
                    Head.Prev = null;
                    Tail.Next = null;
                }
                else
                {
                    Tail.Next = newNode;
                    newNode.Prev = Tail;
                    Tail = newNode;
                    Tail.Next = null;
                }
            }
        }

        public class Node
        {
            public int Data;
            public Node Right;
            public Node Left;
        }
        public class Tree
        {
            public Node Insert(Node root, int data)
            {
                if (root == null)
                {
                    root = new Node();
                    root.Data = data;
                }
                else if(data < root.Data)
                {
                    root.Left = Insert(root.Left, data);
                }
                else
                {
                    root.Right = Insert(root.Right, data);
                }
                return root;
            }
        }
    }




}

