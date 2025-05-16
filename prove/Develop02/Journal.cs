public class Journal
{
    public List<Entry> _entries = new List<Entry>();



    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void WriteToFile()
    {
        using (StreamWriter outputFile = new StreamWriter("journal.txt"))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.CreateFileString()}");
            }


        }
    } 
}