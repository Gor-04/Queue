class CustomQueue
{
    private int[] queueArray;
    private int tail;
    private int capacity;

    public CustomQueue(int size)
    {
        queueArray = new int[size];
        capacity = size;
        tail = -1;
    }

    public int Peek()
    {
        if (tail == -1)
        {
            Console.WriteLine("Queue is empty!");
            return -1;
        }
        return queueArray[0];
    }

    public bool Enqueue(int x)
    {
        if (tail == capacity - 1)
        {
            Console.WriteLine("Queue is full!");
            return false;
        }
        tail++;
        queueArray[tail] = x;
        Console.WriteLine($"{x} enqueued successfully.");
        return true;
    }

    public int Dequeue()
    {
        if (tail == -1)
        {
            Console.WriteLine("Queue is empty!");
            return -1;
        }

        int temp = queueArray[0];
        for (int i = 0; i < tail; i++)
        {
            queueArray[i] = queueArray[i + 1];
        }
        tail--;
        Console.WriteLine($"{temp} dequeued successfully.");
        return temp;
    }

    public void PrintQueue()
    {
        if (tail == -1)
        {
            Console.WriteLine("Queue is empty!");
            return;
        }

        Console.Write("Queue: ");
        for (int i = 0; i <= tail; i++)
        {
            Console.Write(queueArray[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the queue: ");
        int size = Convert.ToInt32(Console.ReadLine());

        CustomQueue queue = new CustomQueue(size);

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);

        queue.Dequeue();
        queue.Dequeue();

        queue.PrintQueue();
    }
}
