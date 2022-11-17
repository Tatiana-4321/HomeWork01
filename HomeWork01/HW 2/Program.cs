Console.WriteLine("Enter the First Number");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second Number");
int numberSecond = Convert.ToInt32(Console.ReadLine());
if (numberFirst > numberSecond)
{
    Console.WriteLine($"{numberFirst} is max");
}
else 
{
    Console.WriteLine($"{numberSecond} is max");
}
