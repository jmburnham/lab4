//main
string mode = "";
while(mode != "3")
{
    Menu(ref mode);
    if(mode == "1")
    {
        Problem1(ref mode);
    }
    if(mode == "2")
    {
        Problem2(ref mode);
    }
    if(mode == "3")
    {
        Exit(ref mode);
    }
    if(mode != "1" && mode != "2" && mode != "3")
    {
        System.Console.WriteLine("You have made an incorrect selection.  Enter a valid selection of '1', '2', or '3' for the program to run.");
    }
}

//*******************************METHODS**************************//
//menu

static void Menu(ref string mode)
{
    System.Console.WriteLine("Please choose a problem.  Enter the corresponding number to select.");
    System.Console.Write("1. Problem 1" + "\n" + "2. Problem 2" + "\n" + "3. Exit" + "\n");
    mode = Console.ReadLine();
}

//problem 1
static void Problem1(ref string mode){
    for(int i = 11; i > 1; i--)
    {
        for(int j = i; j > 1; j--){
            Console.Write("*");
        }
        Console.Write("\n");
    }
}

//formatting
for(int k = 0; k < 2; k++)
{
    Console.Write("\n");
}


//problem 2
static void Problem2(ref string mode){
    for(int i = 1; i < 5; i++)
    {
        Console.Write(i + "\t");
        for(int j = 0; j < 10; j++)
        {
        Console.Write((i * j) + "\t");
        }
        Console.Write("\n");
    }
}

//exit
static void Exit(ref string mode)
{
    System.Console.WriteLine("Have a nice day!");
}