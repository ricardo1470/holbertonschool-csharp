using System;

/// <summary>
/// new class called Queue.
///</summary>
class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count;

    /// <summary>
    /// Queue should not inherit from other classes or interfaces.
    ///</summary>
    /// <return> the Queue’s type.</return>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Class to describe nodes of the queue
    /// </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        /// <summary>
        /// Constructor for the node class
        /// </summary>
        /// <param name="variable">Value to add to the node</param>
        public Node(T variable)
        {
            value = variable;
        }
    }

    /// <summary>
    /// the class Queue that creates a new Node and adds it to the end of the queue.
    /// </summary>
    public void Enqueue(T value)
    {
        Node temp = new Node(value);

        if (head == null)
        {
            head = temp;
            tail = temp;
        }
        else
        {
            tail.next = temp;
            tail = temp;
        }
        count++;
    }

    /// <summary>
    /// the class that returns the number of nodes in the Queue.
    /// </summary>
    /// <returns> returns the number of nodes</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// removes the first node in the queue and returns its value.
    /// If the queue is empty, the method should write Queue is empty to the console
    /// </summary>
    /// <returns> return the default value of the parameter’s type</returns>
    public T Dequeue()
    {
        Node temp = head;

        if (temp == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        head = head.next;
        count--;
        return temp.value;
    }

    /// <summary>
    /// the value of the first node of the queue without removing the node.
    /// </summary>
    /// <returns> returns the value of the first node of the queue</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    /// <summary>
    /// that prints the queue, starting from the head.
    /// </summary>
    public void Print()
    {
        Node temp = head;
        
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        while (temp != null)
        {
            Console.WriteLine("{0}", temp.value);
            temp = temp.next;
        }
    }

    /// <summary>
    /// concatenates all values in the queue only if the queue
    /// is of type String or Char.
    /// If queue is empty, print Queue is empty
    /// If the queue is not of type String or Char,    
    /// print Concatenate() is for a queue of Strings or Chars only. to the console 
    /// </summary>
    /// <return> return null </return>
    public void Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T).Name is string)
        {}
    }
}