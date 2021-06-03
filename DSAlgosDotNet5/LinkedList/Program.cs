using System;

// Singly Linked List

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList singlyLinkedList = new();

            singlyLinkedList.InsertFirst(100);
            singlyLinkedList.InsertFirst(50);
            singlyLinkedList.InsertFirst(99);
            singlyLinkedList.InsertFirst(88);
            singlyLinkedList.DispalyList();

            singlyLinkedList.InsertLast(999);
            singlyLinkedList.DispalyList();

            singlyLinkedList.DeleteFirst();
            singlyLinkedList.DispalyList();
        }
    }

    public class SinglyLinkedList
    {
        private Node firstNode;
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        public void InsertFirst(int data)
        {
            Node newNode = new();
            newNode.Data = data;
            newNode.NextNode = firstNode;
            firstNode = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = firstNode;
            firstNode = firstNode.NextNode;
            return temp;
        }

        public void DispalyList()
        {
            Console.WriteLine("List (first -- last)");
            Node current = firstNode;
            while (current != null)
            {
                current.DispalyNode();
                current = current.NextNode;
            }

            Console.WriteLine();
        }

        public void InsertLast(int data)
        {
            Node current = firstNode;
            while (current.NextNode != null)
            {
                current = current.NextNode;
            }

            Node newNode = new();
            newNode.Data = data;
            current.NextNode = newNode;
        }
    }

    public class Node  
    {
        public int Data { get; set; }
        public Node NextNode { get; set; }
        
        public void DispalyNode() 
        {
            Console.WriteLine($"< {Data} >");
        }
    }
}