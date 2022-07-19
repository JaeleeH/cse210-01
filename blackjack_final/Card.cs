//blackjack final project
//Jaelee
using System;

//card class deals with the cards
public class Card : Director{
    static Random randomGenerator = new Random();

    public int card1 = randomGenerator.Next(1,14);
    public int card2 = randomGenerator.Next(1,14);
    public int nextCard = randomGenerator.Next(1,14);


    //display cards
    public void displayCard(int card1, int card2){
        Console.WriteLine($"Your cards are {card1} and {card2}");
    }

    //get next card
    public void getnextCard(int nextCard){
        Console.WriteLine($"Your next card is {nextCard}");
    }

    //determine if player wins or loses
    public void winlose(string choice){
        if (choice == "y"){
            if (card1 + card2 + nextCard > 21){
                Console.WriteLine("You lose!");
            }
        }
        else{
            Console.WriteLine("You win!");
        }
        
    }
    
}