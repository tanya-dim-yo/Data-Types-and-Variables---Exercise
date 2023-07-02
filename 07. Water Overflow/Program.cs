int n = int.Parse(Console.ReadLine());
int capacity = 255;
int filledWater = 0;

for (int i = 1; i <= n; i++)
{
    int litters = int.Parse(Console.ReadLine());

    if (litters > (capacity - filledWater))
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        filledWater += litters;
    }
}

Console.WriteLine(filledWater);