//tictactoe
//Jaelee Hutchinson
using System.Collections.Generic;


void main(){                              
    List<string> board = createBoard();
    displayBoard(board);    
    bool keepGoing = checkBoard(board);
    string player = "x";
    //when not 3 in a row or draw (starts as false)  
    while(!keepGoing){
        int move = getInput(player);
        board[move -1] = player;
        if (checkWinner(board) == true ){
            keepGoing = false;
            return;
        }
        //output
        displayBoard(board);
        if (player == "x"){ 
            player = "o";                  
        }
        else { 
            player = "x";                  
        }       
    }       
}

//create board
List<string> createBoard(){
    List<string> board = new List<string>(9);
    for(int i=0;i<9;i++){
        board.Add((i + 1).ToString());
    }
    return board;
}

//get user input
int getInput(string player){
    Console.Write($"{player}'s turn to choose a square (1-9): ");
    int inputX  = Convert.ToInt32 (Console.ReadLine());
    return inputX; 
}


//check for 3 in a row verticaly, horizontally, diagonally
bool checkWinner(List<string> board){  
    if ((board[0] == board[1] && board[0] == board[2]) ||
        (board[3] == board[4] && board[3] == board[5]) ||
        (board[6] == board[7] && board[6] == board[8]) ||
        (board[0] == board[3] && board[0] == board[6]) ||
        (board[1] == board[4] && board[1] == board[7]) ||
        (board[2] == board[5] && board[2] == board[8]) ||
        (board[0] == board[4] && board[0] == board[8]) ||
        (board[2] == board[4] && board[2] == board[6])){
        Console.WriteLine("Good game. Thanks for playing!");
        return true;        
    }
    else {
        return false;
    }
}


//check if board is filled
bool checkBoard(List<string> board){
    for(int i=0; i<9;i++){
        if(board[i]!= "x"&& board[i]!="o"){
            return(false);
        }
    }
    return(true);
}
       

//display board
void displayBoard(List<string> board){ 
    Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
    Console.WriteLine("-+-+-");
    Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
    Console.WriteLine("-+-+-");
    Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
    Console.WriteLine();
}


main();
