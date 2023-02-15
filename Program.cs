//start main
int userChoice = GetUserChoice();
while (userChoice != 3){
    Route(userChoice);
    PauseAction();
    userChoice = GetUserChoice();
}
//end main

static int GetUserChoice(){
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if (IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else {
       System.Console.WriteLine( "This is not a valid choice. Please try again.");
       PauseAction();
       return GetUserChoice();
    }
}

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string  userChoice){
    if (userChoice == "1" || userChoice == "2" || userChoice == "3"){
        return true;
    }
    else return false;
}

static void PauseAction(){
    System.Console.WriteLine("\nPress any key to continue");
    Console.ReadKey();
}
//______________________________
static void Route(int userChoice){
    if (userChoice == 1 ){
        GetFull();
    }
    else{
        GetPartial();
    }
}

static void GetFull(){
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    
    PrintFull(number);
}

static void GetPartial(){
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    PrintPartial(number);
}

static void PrintFull(int number){
    for (int i =1; i <= number; i++){
        for (int j = 1; j <= i; j++){
            System.Console.Write("o ");
        }
        System.Console.Write("\n");
    }
}

static void PrintPartial(int number){
    Random rnd = new Random();
    for (int i =1; i <= number; i++){
        for (int j = 1; j <= i; j++){        
            int secondNumber = rnd.Next(4);
            if (secondNumber != 0)
                System.Console.Write("o ");
            else 
                System.Console.Write("  ");
        }
        System.Console.Write("\n");
    }
}