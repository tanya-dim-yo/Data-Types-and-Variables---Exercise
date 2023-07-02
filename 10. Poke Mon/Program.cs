int pokemonPower = int.Parse(Console.ReadLine());
int targetDistance = int.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());
double percentage = pokemonPower * 0.5;
int targetsPoked = 0;

while (pokemonPower >= targetDistance)
{
    pokemonPower -= targetDistance;
    targetsPoked++;

    if (pokemonPower == percentage && exhaustionFactor != 0)
    {
        pokemonPower /= exhaustionFactor;
    }
}

Console.WriteLine(pokemonPower);
Console.WriteLine(targetsPoked);