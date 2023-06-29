int numberOfLetters = int.Parse(Console.ReadLine());
int sum = 0;

for (int currentLetter = 1; currentLetter <= numberOfLetters; currentLetter++)
{
    char letter = char.Parse(Console.ReadLine());
    sum += (int)letter;
}

Console.WriteLine($"The sum equals: {sum}");