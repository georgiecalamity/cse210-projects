using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var wordsToHide = _words.Where(word => !word._isHidden).OrderBy(x => random.Next()).Take(numberToHide).ToList();
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string getDisplayText()
    {
        return $"{_reference.getDisplayText()}: {string.Join(" ", _words.Select(word => word.getDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word._isHidden);
    }
}