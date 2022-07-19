//blackjack final project
//Jaelee Hutchinson
using System;

public class Program{
    static void Main(){
        //instance of card and director classes
        var card = new Card();
        var director = new Director();

        //display card
        card.displayCard(card.card1, card.card2);
        string choice = director.getInput(director.choice);

        //display next card
        if (choice == "y"){
            card.getnextCard(card.nextCard);
        }

        //decide if the player wins or loses
        card.winlose(director.choice);

    }
}

