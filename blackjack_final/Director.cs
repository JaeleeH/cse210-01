//blackjack final project
//Jaelee
using System;
#nullable disable


//director class deals with user input
public class Director{
    public string choice = "";

    //get input from user to draw another card
    public string getInput(string choice){
        Console.Write("Would you like to draw another card? [y/n]");
        choice = Console.ReadLine();;

        if ((choice != "y") && (choice != "n")){
            choice = "n";
        }

        return choice;
    }



}