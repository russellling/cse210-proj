public class Scripture
{
    private References _references;
    private List<Word> _words;

    public Scripture(References references, string text)
    {
        _references = references;
        _words = new List<Word>();

        // split text into words
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
    Random random = new Random();

    // Only get visible words
    List<Word> visibleWords = new List<Word>();
    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            visibleWords.Add(word);
        }
    }

    for (int i = 0; i < numberToHide; i++)
    {
        if (visibleWords.Count == 0)
        {
            break;
        }
        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();
        visibleWords.RemoveAt(index); // Don't pick it again this round
    }
    }

    public string GetDisplayText()
    {
        string display = _references.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display;
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public bool IsCompleteHidden()
    {
        return AllWordsHidden();
    }
}