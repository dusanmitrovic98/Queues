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

    public void Dequeue()
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
