using System;
using System.Collections.Generic;
using static System.Console;

namespace TheStack
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyStack.DoWork();
            StackDemo.DoWork();
        }
    }

    public class MyStack
    {
        public static void DoWork()
        {
            MyStack theStack = new MyStack(4);
            theStack.Push("Star Wars");
            theStack.Push("Jaws");
            theStack.Push("Jaws2");
            theStack.Push("Titanic");
            theStack.Push("Rocky");

            WriteLine("=================== \nAbout to Peek:\n");
            WriteLine($"\'{theStack.Peek()}\' is at the top of the stack.\n");

            WriteLine("=================== \nThe Stack Contains:\n");
            while (!theStack.IsEmpty())
            {
                string movie = theStack.Pop();
                WriteLine(movie);
            }
        }
        
        private int maxSize;
        private string[] stackArray;
        private int top;

        public MyStack()
        {

        }

        public MyStack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void Push(string m)
        {
            if (IsFull())
            {
                WriteLine("Stack is full.");
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                WriteLine("Stack is full.");
                return "--";
            }
            else
            {
                int old_top = top;
                top--;
                return stackArray[old_top];
            }
        }

        public string Peek()
        {
            return stackArray[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return maxSize - 1 == top;
        }
    }

    public class StackDemo
    {
        public static void DoWork()
        {
            Stack<string> names = new();
            names.Push("Andrew");
            names.Push("Bobby");
            names.Push("Candy");
            names.Push("Dana");
            names.Push("Edith");

            WriteLine("Deault content of stack");

            foreach (string name in names)
            {
                WriteLine(name);
            }

            WriteLine($"\nPopping {names.Pop()}");
            WriteLine($"Peek at next item to display what will be stacked {names.Peek()}");
            WriteLine($"Now, after peek, popping {names.Pop()}");

            Stack<string> stack2 = new(names.ToArray());

            WriteLine("\nContents of the first copy:");
            foreach (string name in stack2)
            {
                WriteLine(name);
            }

            string[] array2 = new string[names.Count * 2];
            names.CopyTo(array2, names.Count);

            Stack<string> stack3 = new Stack<string>(array2);

            WriteLine("\nContents of the 2nd copy, with dups and nulls:");
            foreach (string name in stack3)
            {
                WriteLine(name);
            }

            WriteLine($"\nstack2.Contains (\"Dana\") = {stack2.Contains("Dana")}");

            stack2.Clear();

            WriteLine($"\nstack2.Count = {stack2.Count}");
        }
    }
}