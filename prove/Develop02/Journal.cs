public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    private string GetFileName()
    {
        Console.Write("Input file name: ");
        return Console.ReadLine();
    }


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
        using (StreamWriter outputFile = new StreamWriter(GetFileName()))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.CreateFileString()}");
            }


        }
    }

    public void ReadFromFile()
    {
        string[] lines = System.IO.File.ReadAllLines(GetFileName());
        foreach (string line in lines)
        {
            string[] parts = line.Split('#');
            string date = parts[0];
            string prompt = parts[1];
            string input = parts[2];

            Entry entry = new Entry();
            entry.SetAllData(date, prompt, input);
            AddEntry(entry);
        }
    }
}