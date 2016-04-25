using System;
using System.Collections.Generic;
using System.Text;

public class Deck
{
    public string name;
    public List<Card> deck;


    public Deck()
    {
        this.name = "test";
        this.deck = new List<Card>();

    }
	public Deck(string name)
	{
        this.name = name;
        deck = new List<Card>();
	}

    public void AddCard(string front, string back)
    {
        Card c = new Card(front, back);
        this.deck.Add(c);
    }

    public override String ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Deck Name = " + this.name + "\n");
        foreach(Card c in this.deck) {
            sb.AppendLine("Card front= " + c.frontText);
        }
        return sb.ToString();
    }

    public List<Card> getDeck()
    {
        return this.deck;
    }
}
