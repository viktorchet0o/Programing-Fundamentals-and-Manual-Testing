int startNumber = 1;
int endNumber  = int.Parse(Console.ReadLine()); //край на интервала

int sum = 0;

for(int number = startNumber; number <= endNumber; number++)
{
    sum = sum + number;
}

Console.WriteLine(sum);