/*
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
int number = 8; //1st method

int numberSecond;

numberSecond = 8; //2nd method 
//

int result = number * number;

Console.WriteLine(result);
Console.WriteLine($"{number} * {number} = {result}");
Console.Write(numberSecond * numberSecond);
*/

/*
int number = 5;

if (number > 10)

{
Console.WriteLine("number more than 10");
}

else
{
    Console.WriteLine("number no more than 10");
}
*/

/*
int number = 5; 

while(number < 10)

{
    Console.WriteLine(number);
    number ++;
}
*/

/*
int numberFirst = 7;

int numberSecond = 49;

if (numberFirst * numberFirst == numberSecond)

{
Console.WriteLine($"{numberFirst} is a square of {numberSecond}");
}

else
{
  Console.WriteLine($"{numberFirst} isn't a square of {numberSecond}");  
}
*/
/*
Console.WriteLine("Enter the first number");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst * numberFirst == numberSecond)

{
Console.WriteLine($"{numberFirst} is a square of {numberSecond}");
}

else
{
  Console.WriteLine($"{numberFirst} isn't a square of {numberSecond}");  
}
*/
/*
Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("This is Monday");
}

if (number == 2)
{
    Console.WriteLine("This is Tuesday");
}

if (number == 3)
{
    Console.WriteLine("This is Wednesday");
}

if (number == 4)
{
    Console.WriteLine("This is Thursday");
}

if (number == 5)
{
    Console.WriteLine("This is Friday");
}

if (number == 6)
{
    Console.WriteLine("This is Saturday");
}

if (number == 7)
{
    Console.WriteLine("This is Sunday");
}

else
{
    Console.WriteLine("Wrong number");
}
*/
/*
Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("This is Monday");
}

if (number == 2)
{
    Console.WriteLine("This is Tuesday");
}

if (number == 3)
{
    Console.WriteLine("This is Wednesday");
}

if (number == 4)
{
    Console.WriteLine("This is Thursday");
}

if (number == 5)
{
    Console.WriteLine("This is Friday");
}

if (number == 6)
{
    Console.WriteLine("This is Saturday");
}

if (number == 7)
{
    Console.WriteLine("This is Sunday");
}

if (number > 7)
{
    Console.WriteLine("Wrong number");
}
*/
/*
Console.WriteLine("Enter the number");
int number = 6; //Convert.ToInt32(Console.ReadLine());
PrintPower(number);

void PrintPower(int numberSecond)
{
Console.WriteLine($"{numberSecond} * {numberSecond} = {numberSecond * numberSecond}");
numberSecond += 10;
Console.WriteLine("Internal variable " + numberSecond);
}
// wrote rule but not used
*/
Console.WriteLine("Enter the number");

int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int count = -number;

while (count <= number)
{
    Console.Write(count + " ");
    count ++;
}
Console.WriteLine();








