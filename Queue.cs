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
}
