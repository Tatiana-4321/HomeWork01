Console.WriteLine("Enter the First Number");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second Number");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Third Number");
int numberThird = Convert.ToInt32(Console.ReadLine());
int max = numberFirst;

if(numberFirst > max) max = numberFirst;
if(numberSecond > max) max = numberSecond;
if(numberThird > max) max = numberThird;

Console.Write($"max number = ");
Console.WriteLine(max);

