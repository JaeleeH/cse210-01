//hilo
//Jaelee Hutchinson
using System;

//player class deals with user input and the user's points
public class Player{
    public int points = 300;
    public int win = 100;
    public int lose = 75;
    
    //get user input
    public string getInput(){
        Console.Write("Higher or lower? [h/l] ");
        string? choice;
        choice = Console.ReadLine();;

        //throw exception
        if (choice == null){
            choice = "h";
        }

        return choice;

    }

    //add points based if user guessed correctly
    public int pointsAdd(int points, int win){
        points = points + win;
        return points;
    }

    //subtract points if user guessed incorrectly
    public int pointsSubtract(int points, int lose){
        points = points - lose;
        return points;
    }

    public bool keepPlaying(){
        Console.Write("Play again? [y/n] ");
        string? continueGame;
        continueGame = Console.ReadLine();

        //throw exception
        if (continueGame == null){
            continueGame = "y";
        }

        if (continueGame == "y"){
            return true;
        }
        else {
            return false;
        }
    }



}