public class Word
{

    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        char[] newString = _text.ToCharArray();
        int textLenght = _text.Length;
        for (int i = 0; i < textLenght; i++)
        {
            newString[i] = '_';
        }

        _text = new string(newString);
    }

    public void Show()
    {
        
    }

    public bool IsHidden()
    {
        char[] newString = _text.ToCharArray();
        if (newString[0] == '_')
        {
            _isHidden = true;
        }
        else
        {
            _isHidden = false;
        }

        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}