using System;

namespace TheQueue
{
    // The Queue Data Structure in .NET 5.0
    //      FIFO
    //      Enqueue - Adding to the end of the queue
    //      Dequeue - Removing from the front of the queue

    class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new(5);
            myQueue.Insert(100);
            myQueue.Insert(10);
            myQueue.Insert(20);
            myQueue.Insert(30);
            myQueue.View();

            Console.WriteLine($"Front of queue is: {myQueue.PeekFront()}");

            Console.WriteLine("About to remove an item from the queue...");

            myQueue.Remove();

            Console.WriteLine($"Front of queue is: {myQueue.PeekFront()}");
        }
    }

    public class MyQueue
    {
        private int maxSize;
        private long[] myQueue;
        private int front;
        private int rear;
        private int items;

        public MyQueue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0;
        }

        public void Insert(long j)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }

                rear++;

                myQueue[rear] = j;
                items++;
            }
        }

        public long Remove()
        {
            long temp = myQueue[front];
            front++;
            if (front == maxSize)
            {
                front = 0;
            }
            return temp;
        }

        public long PeekFront()
        {
            return myQueue[front];
        }
        
        public bool IsEmpty()
        {
            return items == 0;
        }

        private bool IsFull()
        {
            return items == maxSize;
        }

        public void View()
        {
            Console.Write("[");
            for (int i = 0; i < myQueue.Length; i++)
            {
                Console.Write($"{myQueue[i]} ");
            }
            Console.WriteLine("]");
        }
    }
}
