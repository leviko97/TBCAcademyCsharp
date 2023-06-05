Console.WriteLine("Pleas write temperature");
double temp = Convert.ToDouble(Console.ReadLine());

if (temp < 0 )
{
    Console.WriteLine("Freezing");
}
else if (temp < 30)
{
    Console.WriteLine("Good weather");
}
else
{
    Console.WriteLine("Toooo hot");
}

