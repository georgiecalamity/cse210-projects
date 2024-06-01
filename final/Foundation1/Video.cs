public class Video{
    private string _author;
    private string _title;
    private int _length;
    List<Comment> _commentList;

    public Video(string Author, string Title, int Length, List<Comment> List){
        this._author = Author;
        this._title = Title;
        this._length = Length;
        this._commentList = List;
    }

    public string GetAuthor(){
        return this._author;
    }

    public string GetTitle(){
        return this._title;
    }

    public int GetLength(){
        return this._length;
    }

    public void Display(){
        Console.WriteLine($"Video Title: {this._title}\nAuthor: {this._author} - Length: {this._length} seconds"+
        $"\nComments:{this._commentList.Count}");
    }
    public void DisplayComments(){
        Console.WriteLine("Comments ---");
        for(int i = 0; i < this._commentList.Count; i++){
            Console.WriteLine(this._commentList[i].GetComment());
        }
    }

    public int CommentCount(){
        return this._commentList.Count();
    }
}