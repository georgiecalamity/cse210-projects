public class Comment{
    private string _name;
    private string _text;

    public Comment(string Name, string Text){
        this._name = Name;
        this._text = Text;
    }

    public string GetComment(){
        return $"{this._name}: \n {this._text}";
    }
}