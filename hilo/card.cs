//hilo
//Jaelee Hutchinson
using System;

//card class deals with the current and next cards
public class Card{
    static Random randomGenerator = new Random();
    public int currentCard = randomGenerator.Next(1,14);
    public int nextCard = randomGenerator.Next(1,14);

    //display current card
    public void displayCard(int currentCard){
        Console.WriteLine($"The card is {currentCard}");
    }

    //compare current to next card
    public bool compare(){
        if ((currentCard < nextCard) || (currentCard == nextCard)){
            return true;
        }
        else {
            return false;
        }
          
    }

    //display next card
    public void showCard(int nextCard){
        Console.WriteLine($"The next card is {nextCard}");
    }



}