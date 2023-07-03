using System.Numerics;

int snowballsNumber = int.Parse(Console.ReadLine());
int bestSnow = 0;
int bestTime = 0;
int bestQuality = 0;
BigInteger bestValue = 0;

for (int i = 1; i <= snowballsNumber; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

    if (snowballValue > bestValue)
    {
        bestValue = snowballValue;
        bestQuality = snowballQuality;
        bestTime = snowballTime;
        bestSnow = snowballSnow;
    }
}

Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");