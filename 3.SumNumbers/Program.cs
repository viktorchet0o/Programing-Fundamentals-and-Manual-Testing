int startNumber = 1;
int endNumber = int.Parse(Console.ReadLine()); //брой на числата които трябва да въведа и сумирам

int sum = 0;

for (int number = 1; number <= endNumber; number++)
{
    if (number != endNumber)
    { 
    Console.Write(number + "+");
    }
    else
    {
        Console.Write(number + "=");
    }
    sum = sum + number;
}

Console.WriteLine(sum); 
