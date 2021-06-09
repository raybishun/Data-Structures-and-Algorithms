using System;
using System.Collections.Generic;
using static System.Console;

namespace TheStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack.DoWork();
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
            Stack<string> names = new Stack<string>();
            names.Push("Andrew");
            names.Push("Bobby");
            names.Push("Candy");
            names.Push("Dana");
            names.Push("Edith");

            WriteLine("Deault content of stack");
        }
    }
}