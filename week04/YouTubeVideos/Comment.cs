public class Comment
{
    //store the comementer's name and stores what the person said.
    public string Name { get; set; }
    public string Text { get; set; }
    
    //Allows us to provide information when creating a new object.
    public Comment(string name , string text)
    {
        Name = name;
        Text = text;
    }
}