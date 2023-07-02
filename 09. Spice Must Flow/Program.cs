int startingYield = int.Parse(Console.ReadLine());
int extractedSpices = 0;
int days = 0;

while (startingYield >= 100)
{
    days++;
    extractedSpices += startingYield - 26;
    startingYield -= 10;
}

if (days > 0)
{
    extractedSpices -= 26;
}
Console.WriteLine(days);
Console.WriteLine(extractedSpices);