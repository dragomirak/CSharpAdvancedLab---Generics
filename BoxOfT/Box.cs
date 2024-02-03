

namespace BoxOfT;

public class Box<T>
{
    private List<T> data;

    public Box()
    {
        this.data = new List<T>();
    }

    public int Count
    {
        get
        {
            return this.data.Count;
        }
    }

    public void Add(T element)
    {
        this.data.Add(element);
    }

    public T Remove()
    {
        if (this.data.Count == 0)
        {
            throw new InvalidOperationException("The box is empty.");
        }
        var lastElement = this.data.Last();
        this.data.RemoveAt(this.data.Count - 1);

        return lastElement;
    }
}
