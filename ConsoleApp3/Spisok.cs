public class MyList<T>
{
    private T[] items;
    private int count;
    private int capacity;

    public MyList(int size)
    {
        items = new T[size];
        count = 0;
        capacity = size;
    }

    public void Add(T item)
    {
        if (count >= capacity)
        {
            throw new InvalidOperationException("Стек переполнен.");
        }
        items[count++] = item;
    }

    public T Remove()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Стек пуст.");
        }
        return items[--count];
    }

    public T Peek()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Стек пуст.");
        }
        return items[count - 1];
    }

    public int Count => count;

    public T[] ToArray()
    {
        T[] result = new T[count];
        Array.Copy(items, result, count);
        return result;
    }
}