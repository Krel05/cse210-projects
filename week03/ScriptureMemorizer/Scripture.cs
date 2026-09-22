public class Scripture
{

    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {

        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<int> n = new List<int>();
        for (int i = 0; i < numberToHide; i++)
        {
            n.Add(random.Next(_words.Count()));
        }

        foreach (int i in n)
        {
            _words[i].Hide();
        }
    }

    public string GetDisplayText()
    {
        string fullText = _reference.GetDisplayText() + " ";

        foreach (var word in _words)
        {
            fullText += (word.GetDisplayText() + " ");
        }
        return fullText;
    }

    public bool IsCompleteHidden()
    {
        int totalWords = 0;
        for (int i = 0; i < _words.Count(); i++)
        {
            if (_words[i].IsHidden() == true)
            {
                totalWords++;
            }
        }

        if (totalWords == _words.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}