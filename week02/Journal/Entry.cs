public class Entry
{
    public string _data = "";
    public string _promptText = "";
    public string _entryText = "";

    public Entry()
    {
        
    }

    public void Display()
    {
        Console.WriteLine($"{_data}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}