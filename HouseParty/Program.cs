int commandsNumber = int.Parse(Console.ReadLine());

List<string> peopleOnTheList = new List<string>();

for (int i = 0; i < commandsNumber; i++)
{
    string[] command = Console.ReadLine().Split();
    string name = command[0];

    if (command[2] == "going!")
    {
        int foundPerson = peopleOnTheList.FindIndex(person => person == name);

        if (foundPerson >= 0)
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            peopleOnTheList.Add(name);
        }
    }
    else if (command[2] == "not")
    {
        int foundPerson = peopleOnTheList.FindIndex(person => person == name);

        if (foundPerson >= 0)
        {
            peopleOnTheList.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

Console.WriteLine(string.Join("\n", peopleOnTheList));