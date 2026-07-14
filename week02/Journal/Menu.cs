using System.Collections.Specialized;

public class Menu
{
    public List<string> _menu = new();

    public Menu()
    {
        _menu.Add("1-Write");
        _menu.Add("2-Read");
        _menu.Add("3-Load");
        _menu.Add("4-Save");
        _menu.Add("5-Exit");
    }

    public void ExibirMenu()
    {
        Console.WriteLine("===CHOOSE AN OPTION===");

        foreach (String option in _menu)
        {
            Console.WriteLine(option);
        }
    }
}