//jumper 
//Jaelee Hutchinson
using System;

//list of words to use for the game
public class Words{
    private string currentWord = "";
    private int randNum = 0;
    private bool currentLetter;
    public string nullWord = "null";
    private List<string> guessedLetters = new List<string>();
    private List<string> words = new List<string>(20) {"apple","baseball", "clock", "eyebrow", "fireplace", "garbage", "heaven", 
        "icecream", "jungle", "lighthouse", "mountain", "national", "octopus", "pharmacy", "retail", "chestnut", "important", 
        "exercise", "biscuit", "teamwork"};

    //create random number to choose word from list
    //set currentWord to random number
    public string getRandNum(){
        Random random = new Random();
        int currentWord = random.Next(0,(words.Count -1));
        nullWord = words[currentWord];
        return words[currentWord];
    }

    //compare guessed letters to word
    public string compareWord(string guess){
        string completeWord = "";
        //compares the characters
        foreach (var word in nullWord){
            currentLetter = false;
            foreach (var guessed in guessedLetters){
                if (Convert.ToString(guessed) == Convert.ToString(word)){
                    completeWord = completeWord + guessed;
                    currentLetter = true;
                }
            }
            //add guessed letters to list
            if (guess.Equals(Convert.ToString(word)) && currentLetter != true){
                completeWord = completeWord + word;
                guessedLetters.Add(Convert.ToString(word));
                currentLetter = true;
            }
            //add space
            if(string.IsNullOrWhiteSpace(Convert.ToString(word))){
                completeWord = completeWord + " ";
            }
            //add characters to list
            else if ("\'".Equals(Convert.ToString(word)) && currentLetter != true){
                completeWord = completeWord + word;
                guessedLetters.Add(Convert.ToString(word));
                currentLetter = true;
            }
            else if ("-".Equals(Convert.ToString(word)) && currentLetter != true){
                completeWord = completeWord + word;
                guessedLetters.Add(Convert.ToString(word));
                currentLetter = true;
            }
            else if (",".Equals(Convert.ToString(word)) && currentLetter != true){
                completeWord = completeWord + word;
                guessedLetters.Add(Convert.ToString(word));
                currentLetter = true;
            }
            //add blank line 
            else if (currentLetter != true){
                completeWord = completeWord + "_";
            }
        }
        return completeWord;
    }
}

