namespace ClassBasedOopSample;

public class DataStructure
{
    public void Run()
    {
        var fruits = new List<string> { "apple", "orange" };
        Console.WriteLine(fruits[0]); // -> apple

        var man = new Dictionary<string, string>();
        man.Add("name", "Taro");
        man.Add("age", "20");
        Console.WriteLine(man["name"]); // -> Taro
    }
}