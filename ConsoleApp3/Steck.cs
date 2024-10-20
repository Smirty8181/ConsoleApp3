public class Stack<T>
{
    private MyList<T> list;

    public Stack(int size)
    {
        list = new MyList<T>(size);
    }

    public Stack(Stack<T> other)
    {
        list = new MyList<T>(other.list.Count);
        foreach (var item in other.list.ToArray())
        {
            list.Add(item);
        }
    }
    public void Push(T item)
    {
        list.Add(item);
    }

    public T Pop()
    {
        return list.Remove();
    }

    public T Peek()
    {
        return list.Peek();
    }

    public void Print()
    {
        var items = list.ToArray();
        Console.WriteLine("Содержимое стека: " + string.Join(", ", items));
    }

    public double Average()
    {
        if (list.Count == 0)
            throw new InvalidOperationException("Стек пуст.");

        dynamic sum = 0; 
        foreach (var item in list.ToArray())
        {
            sum += item;
        }
        return sum / list.Count;
    }
}