//jumper
//Jaelee Hutchinson
using System;
#nullable disable

//gameLoop contains the main class to start the game
public class GameLoop{
    static void Main(string[] args){
        //instance of director class
        Director director = new Director();
        director.startGame();
    }
}
