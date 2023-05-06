namespace DataStructures.Collections.Queues;

public class Queue<T>
{
    private List<T> _elements;

    public List<T> Elements
    {
        get { return this._elements; }
        set { this._elements = value; }
    }

    public int Count
    {
        get { return this._elements.Count; }
    }

    public void Enqueue(T item)
    {
        this._elements.Add(item);
    }

    public T Dequeue()
    {
        if (this.IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T result = this._elements[0];
        this._elements.RemoveAt(0);

        return result;
    }

    public T Peek()
    {
        if (this.IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return this._elements[0];
    }

    public void Clear()
    {

    }

    public bool IsEmpty()
    {
        if (this.Count == 0)
        {
            return true;
        }

        return false;
    }
}
