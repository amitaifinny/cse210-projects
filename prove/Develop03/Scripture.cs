public class Scripture
{
    List<Word> _word;
    Reference _reference;

    public Scripture(Reference reference, List<Word> word)
    {
        _reference = reference;
        _word = word;
    }
}