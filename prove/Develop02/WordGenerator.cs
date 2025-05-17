public class WordGenerator
{
    private string[] _randomWords =
    {
        "Serendipity: The occurrence of events by chance in a happy or beneficial way.",
        "Ephemeral: Lasting for a very short time.",
        "Ubiquitous: Present, appearing, or found everywhere.",
        "Mellifluous: (of a sound) pleasingly smooth and musical to hear.",
        "Lackadaisical: Lacking enthusiasm and determination; carelessly lazy.",
        "Pernicious: Having a harmful effect, especially in a gradual or subtle way.",
        "Conundrum: A confusing and difficult problem or question.",
        "Esoteric: Intended for or understood by only a small number of people with specialized knowledge.",
        "Juxtaposition: The fact of two things being seen or placed close together with contrasting effect.",
        "Idyllic: Extremely happy, peaceful, or picturesque."
    };

    public string GetRandomWord()
    {
        Random random = new Random();

        int _randomIndex = random.Next(_randomWords.Length);

        return _randomWords[_randomIndex];
    }

    public void Display()
    {
        Console.WriteLine(GetRandomWord());
    }
}