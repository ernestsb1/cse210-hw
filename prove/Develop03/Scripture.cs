public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = CreateWordList(text);
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n\n";

        foreach (Word word in _words)
        {
            displayText += $"{word.GetDisplayText()} ";
        }

        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    private List<Word> CreateWordList(string text)
    {
        List<Word> words = new List<Word>();

        string[] wordArray = text.Split(' ');

        foreach (string word in wordArray)
        {
            words.Add(new Word(word.Trim()));
        }

        return words;
    }
}
