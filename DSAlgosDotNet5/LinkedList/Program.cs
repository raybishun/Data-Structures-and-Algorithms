using System;
using System.Collections.Generic;
using System.Text;

// Singly Linked List

namespace TheLinkedList
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

    public class LinkedListDemo
    {
        private static void Demo1()
        {
            string[] words = { "the", "actor", "jumped", "over", "the", "director" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            Display(sentence, "The linked list values:");

            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list");

            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence, "Test 2: Move first node to be last node:");

            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence, "Test 3: Change the last node to 'yesterday':");

            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Display(sentence, "Test 4: Move last node to be first node:");

            sentence.RemoveFirst();
            LinkedListNode<string> current = sentence.FindLast("the");
            IndicateNode(current, "Test 5: Indicate last occurence of 'the':");

            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "lazy");
            IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the':");

            current = sentence.Find("actor");
            IndicateNode(current, "Test 7: INdicate the 'actor' node:");

            sentence.AddBefore(current, "quick");
            sentence.AddBefore(current, "skinny");
            IndicateNode(current, "Test 8: Add 'quick' and 'skinny' before 'actor':");

            Console.ReadLine();
        }

        private static void Display(LinkedList<string> linkedList, string test)
        {
            Console.WriteLine(test);
            foreach (string node in linkedList)
            {
                Console.Write($"{node} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IndicateNode(LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine($"Node '{node.Value}' is not in the list.\n");
                return;
            }

            StringBuilder result = new StringBuilder($"(\" {node.Value} \")");
            LinkedListNode<string> nodeP = node.Previous;

            while (nodeP != null)
            {
                result.Insert(0, $"{nodeP.Value} ");
                nodeP = nodeP.Previous;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append($" {node.Value}");
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}