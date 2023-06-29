int numberOfPeople = int.Parse(Console.ReadLine());
int elevatorCapacity = int.Parse(Console.ReadLine());
int courses;

if (numberOfPeople <= elevatorCapacity)
{
    courses = 1;
}
else
{
    courses = numberOfPeople / elevatorCapacity;

    if (numberOfPeople % elevatorCapacity != 0)
    {
        courses += 1;
    }
}

Console.WriteLine(courses);