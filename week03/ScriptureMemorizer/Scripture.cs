public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string texts)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = texts.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public void HideRandomWords(int numberToHide)
    {
        int visibleWords = 0;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords++;
            }
        }
        numberToHide = Math.Min(numberToHide, visibleWords);

        int hiddenCount = 0;
        Random random = new Random();

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool IsCompletelyHidden()
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
}