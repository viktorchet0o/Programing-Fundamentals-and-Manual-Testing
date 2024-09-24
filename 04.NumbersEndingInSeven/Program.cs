int startNumber = 7;//начало
int endNumber = int.Parse(Console.ReadLine());//край

//повтарящо се действие определен брой пъти -> for цикъл

//for цикъл със стъпка -> увеличаване на променливата със стойност различна от 1


// Начин 1; цикъл със стъпка
/*for (int number = startNumber; number <= endNumber; number = number += 10 ) 
{
    Console.WriteLine(number);
}*/

for (int number = startNumber; number <= endNumber; number++)
{
    if (number % 10 == 7)
    {
        Console.WriteLine(number);
    }
}