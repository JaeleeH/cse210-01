//jumper
//Jaelee Hutchinson
using System;
#nullable disable

//director class will run the game
public class Director{
    private Guess guess;
    private Player player;
    private Words words;
    private string currentWord;
    private string guesses;
    private string completeWord;



    //instance of classes
    public Director(){
        guess = new Guess();
        player = new Player();
        words = new Words();
        currentWord = words.getRandNum();
        completeWord = "";
    }

    //start game
    public void startGame(){
        while (guess.getWrongGuess() < 4){
            completeWord = words.compareWord("");
            
            //display
            player.displayJumper(guess.getWrongGuess(), 4);
            player.displayCurrentWord(completeWord);
                
            //get guess
            guesses = player.guessLetter();
                
            //compare guess to word
            string guessed = words.compareWord(guesses); 
                
            //check if player wins or loses
            if (completeWord == guessed)
                guess.guessNum();
            else
                completeWord = guessed;

            //player wins
            if (completeWord == currentWord){
                Console.WriteLine("You Win!");
            }
        }
            
        //player loses
        player.displayJumper(guess.getWrongGuess(), 4);
        Console.WriteLine("You Lose!");
    }
}
