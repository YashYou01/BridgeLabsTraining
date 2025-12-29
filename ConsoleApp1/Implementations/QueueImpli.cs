class QueueImpli
{
    int front;
    int rear;
    int[] array;
    int size;

    public QueueImpli(int size)
    {
        this.size = size;
        front = 0;
        rear = 0;
        array = new int[size];
    }

    public void enqueue(int data)
    {
        if (rear == size)
        {
            Console.WriteLine("Queue is Full");
        }
        else
        {
            array[rear++] = data;
        }
    }

    public int dequeue()
    {
        if (front == rear)
        {
            Console.WriteLine("Queue is Empty");
            return -1;
        }

        int ans = array[front++];
        if (front == rear)
        {
            front = 0;
            rear = 0;
        }
        return ans;
    }

    public void print()
    {
        if (front == rear)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }

        Console.WriteLine("Queue elements (front to rear):");
        for (int i = front; i < rear; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
