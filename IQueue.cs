namespace DataStructures.Collections.Queues;

interface IQueue<T>
{
    public List<T> Elements { get; set; }
    public int Count { get; }
}