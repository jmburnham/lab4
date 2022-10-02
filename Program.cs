//main


//problem 1
for(int i = 11; i > 1; i--)
{
    for(int j = i; j > 1; j--){
        Console.Write("*");
    }
    Console.Write("\n");
}

//formatting
for(int k = 0; k < 2; k++)
{
Console.Write("\n");
}


//problem 2
for(int i = 1; i < 5; i++)
{
    Console.Write(i + "\t");
    for(int j = 0; j < 10; j++)
    {
    Console.Write((i * j) + "\t");
    }
    Console.Write("\n");
}
