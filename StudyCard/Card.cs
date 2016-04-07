using System;

public class Card
{
    int _id;
    public string frontText;
    public string backText;
    public string FrontText
    {
        get
        {
            return this.frontText;
        }
    }
    public string BackText
    {
        get
        {
            return this.backText; 
        }
    }
    public Card(string front, string back)
    {
        this.frontText = front;
        this.backText = back;
    }

    public Card()
    {
        this.frontText = "hey";
        this.backText = "backside text here";
    }
}
