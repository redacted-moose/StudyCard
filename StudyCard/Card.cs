using System;

public class Card
{
    int _id;
    string _frontText;
    string _backText;
    public string FrontText
    {
        get
        {
            return this._frontText;
        }
    }
    public string BackText
    {
        get
        {
            return this._backText; 
        }
    }
    public Card(string front, string back)
    {
        this._frontText = front;
        this._backText = back;
    }
}
