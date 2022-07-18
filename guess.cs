//jumper
//Jaelee Hutchinson
using System;

//guess class deals with the guesses
class Guess{
    private int wrongGuess; 

    //start wrong guesses at 0
    public Guess(){
        wrongGuess = 0;
    }

    //add to wrongGuess
    public void guessNum(){
        wrongGuess++;
    }

    //get wrong guess number
    public int getWrongGuess(){
        return wrongGuess;
    }
}



