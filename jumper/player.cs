//jumper
//Jaelee Hutchinson
using System;

//player class deals with user input
class Player{
    List<string> jumper;

    public Player(){
        jumper = new List<string>();
        createJumper();
    }

    //create jumper
    private void createJumper(){
        jumper.Add(" ___ ");
        jumper.Add("/___\\");
        jumper.Add("\\   /");
        jumper.Add(" \\ /");
        jumper.Add("  0  ");
        jumper.Add(" /|\\ ");
        jumper.Add(" / \\ ");
    }

    //if parachute is gone, display loseJumper
    public void displayJumper(int wrongGuesses, int correctWord){
        if (wrongGuesses == correctWord){
            loseJumper();
        }
        else{
            winJumper(wrongGuesses);
        }
    }

    //if guess is correct, display winJumper
    private void winJumper(int wrongGuesses){
        for (int i = wrongGuesses; i < jumper.Count; i++){
            Console.WriteLine(jumper[i]);
        }
        Console.Write("\n");
        Console.WriteLine("^^^^^^^");
    }

    //if parachute is gone, display loseJumper
    private void loseJumper(){
        Console.WriteLine("  x  ");
        Console.WriteLine(" /|\\ ");
        Console.WriteLine(" / \\ ");
        Console.Write("\n");
        Console.WriteLine("^^^^^^^");
    }

    //display current word
    public void displayCurrentWord(string word){
        Console.WriteLine(word);
    }

    //get guessed letter
    public string guessLetter(){
        Console.Write("Guess a letter [a-z]: ");
        string? guess;
        guess = Console.ReadLine();

        //throw exception
        if (guess == null){
            guess = "a";
        }
        return guess;
    }
}