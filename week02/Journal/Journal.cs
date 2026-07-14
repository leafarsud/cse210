using System.ComponentModel;

public class Journal
{
    public List<Entry> _entries = new(); 

    public Journal()
    {
        
    }   

    public void addEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayJounal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
            
        }

        
    }
}
