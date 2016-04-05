using System;
using System.Collections;
using System.Collections.Generic;

public class Deck
{
    public string name;
    public List<Card> deck;
    //Array<Card> cards;
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
}
