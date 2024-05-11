using System;

public class Word{
    public string _text{get; private set;}
    public bool _isHidden{get; private set;}

    public Word(string Text) {
        _text = Text;
        _isHidden = false;
    }

    public void Hide() {
        _isHidden = true;
    }

    public void Show() {
        _isHidden = true;
    }

    public string getDisplayText() {
        return _isHidden ? "____" : _text;
    }
}