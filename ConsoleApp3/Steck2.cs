class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        stack.Print();

        Console.WriteLine($"Верхний элемент: {stack.Peek()}"); 

        Console.WriteLine($"Среднее арифметическое: {stack.Average()}"); 

        stack.Pop();
        stack.Print(); 
    }
}