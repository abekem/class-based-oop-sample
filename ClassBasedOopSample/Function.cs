namespace ClassBasedOopSample;

public class Function
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public void Run()
    {
        Console.WriteLine(Add(10, 20));
        Console.WriteLine(Add(5, Add(1, 2)));
    }
}