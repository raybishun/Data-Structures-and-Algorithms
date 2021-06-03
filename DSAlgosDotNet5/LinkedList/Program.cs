using System;

// Singly Linked List

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.insertFirst(100);
            singlyLinkedList.insertFirst(50);
            singlyLinkedList.insertFirst(99);
            singlyLinkedList.insertFirst(88);
            singlyLinkedList.dispalyList();

            singlyLinkedList.insertLast(999);
            singlyLinkedList.dispalyList();

            singlyLinkedList.deleteFirst();
            singlyLinkedList.dispalyList();
        }
    }

    public class SinglyLinkedList
    {
        private Node first;
        public bool isEmpty()
        {
            return first == null;
        }

        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }

        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        public void dispalyList()
        {
            Console.WriteLine("List (first -- last)");
            Node current = first;
            while (current != null)
            {
                current.DispalyNode();
                current = current.next;
            }

            Console.WriteLine();
        }

        public void insertLast(int data)
        {
            Node current = first;
            while (current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }


    public class Node  
    {
        public int data;
        public Node next;

        public void DispalyNode() 
        {
            Console.WriteLine($"< {data} >");
        }
    }
}