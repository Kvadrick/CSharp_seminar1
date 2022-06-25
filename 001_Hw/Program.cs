int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 100);

Console.WriteLine(numberA);
Console.WriteLine(numberB);

int Max = numberA;
int min = numberB;

if(numberA > numberB)
{
    Max = numberA;
    min = numberB;
}
else
{
    Max = numberB;
    min = numberA;
}
Console.Write("Max = ");
Console.WriteLine(Max);

Console.Write("min = ");
Console.WriteLine(min);
