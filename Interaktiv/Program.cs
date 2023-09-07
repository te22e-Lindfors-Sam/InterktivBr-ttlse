using System.Diagnostics;

string response = "";


Console.WriteLine("Do you want to play the mouse maze game, a labyrinth with no exit, a maze with no prize? Y or N");

response = Console.ReadLine();
if (response.ToUpper() == "Y"){
    Console.WriteLine("");
    Console.WriteLine("Your goal is to collect cheese and escape the mouse");
    Console.WriteLine("Can you guess the code 4siffror 2,3,4,8");

    //The code is in binery so you wont be able to cheat
    string number1 = Convert.ToInt32("11", 2).ToString();
    string number2 = Convert.ToInt32("1000", 2).ToString();
    string number3 = Convert.ToInt32("100", 2).ToString();
    string number4 = Convert.ToInt32("10", 2).ToString();
    string code = number1+number2+number3+number4;


    response = Console.ReadLine();
    bool won = false;

    if (response != code){
        for (int i = 0; i < 5 && response != code; i++){
            Console.WriteLine("Guess Again"); 
            response = Console.ReadLine();
             if (response == code){
                won = true;
             }
        }
    }
    else{
        won = true;
    }

    if (won){
        Console.WriteLine("You guessed it, You escaped");
    }
    else {
        Console.WriteLine("YOU DIED");
    }
            Thread.Sleep(2000);


}
else if (response.ToUpper() == "N"){
    Console.WriteLine("");
}
else {
    Console.WriteLine("Covard");
    Thread.Sleep(2000);
}

