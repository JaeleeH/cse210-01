//hilo
//Jaelee Hutchinson
using System;

//gameLoop contains the main class that calls the card and player classes
public class gameLoop{

    static void Main(){
        //instance of card and player classes
        var card = new Card();
        var player = new Player();

        //display cards and ask user for h/l
        card.displayCard(card.currentCard);
        string choice = player.getInput();
        card.showCard(card.nextCard);
 
        //display score based on h/l
        int points;
        if ((card.compare() && choice == "h") || (!card.compare() && choice == "l")){
            points = player.pointsAdd(player.points, player.win);
            Console.WriteLine($"Your score is {points}");
        }
        else {
            points = player.pointsSubtract(player.points, player.lose);
            Console.WriteLine($"Your score is {points}");
        }

        //ask to play again
        bool continueGame = player.keepPlaying();

        //play again
        while (continueGame && points >= 0){
            //new instance of card and player classes
            card = new Card();
            player = new Player();

            //display cards and ask user for h/l
            card.displayCard(card.currentCard);
            choice = player.getInput();
            card.showCard(card.nextCard);

            //display score based on h/l
            if ((card.compare() && choice == "h") || (!card.compare() && choice == "l")){
                points = player.pointsAdd(points, player.win);
                Console.WriteLine($"Your score is {points}");
            }
            else {
                points = player.pointsSubtract(points, player.lose);
                Console.WriteLine($"Your score is {points}");
            }

            //ask to play again
            continueGame = player.keepPlaying();
            Console.WriteLine();
        }

    }


}