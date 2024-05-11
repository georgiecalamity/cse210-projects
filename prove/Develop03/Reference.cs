using System;

public class Reference{
    public string _book{get; private set;}
    public int _chapter{get; private set;}
    public int _verse{get; private set;}
    public int _endVerse{get; private set;}

    public Reference(string Book, int Chapter, int Verse, int Endverse) {
        _book = Book;
        _chapter = Chapter;
        _verse = Verse;
        _endVerse = Endverse;
    }

    public string getDisplayText() {
        return _endVerse > _verse ? $"{_book} {_chapter}: {_verse}-{_endVerse}" : $"{_book} {_chapter}: {_verse}";
    }
}