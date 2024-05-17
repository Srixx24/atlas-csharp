using System;

class Queue<T>
{
    public Type CheckType()
    {
        return typeof(T);
    }

    public class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    public Node head;
    public Node tail;
    public int count;

    public void Enqueue(T item)
    {
        Node newNode = new Node(item);

        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }

        count++;
    }

    public int Count()
    {
        return count;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T value = head.Value;
            head = head.Next;
            count--;

            if (head == null)
            {
                tail = null;
            }

            return value;
        }
    }

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.Value;
        }
    }

    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        
        Node cur = head;

        while (cur != null)
        {
            Console.WriteLine(cur.value);
            cur = cur.next;
        }
    }
}