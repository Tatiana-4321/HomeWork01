Console.WriteLine("Enter the Number");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (number >= count)
{
    if (count % 2 == 0)
    Console.Write(count + " ");
    count ++;
}