int numberOfKegs = int.Parse(Console.ReadLine());
string bestModel = "";
double maxVolume = 0;

for (int i = 1; i <= numberOfKegs; i++)
{
    string model = Console.ReadLine();
    float radius = float.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double volume = Math.PI * Math.Pow(radius, 2) * height;

    if (volume > maxVolume)
    {
        maxVolume = volume;
        bestModel = model;
    }
}

Console.WriteLine(bestModel);