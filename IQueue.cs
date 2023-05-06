namespace DataStructures.Collections.Queues;

interface IQueue<T>
{
    public List<T> Elements { get; set; }
    public int Count { get; }
    public void Enqueue(T item);
    public T Dequeue();
    public T Peek();
}