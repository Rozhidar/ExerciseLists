List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int wagonCapacity = Convert.ToInt32(Console.ReadLine());

string command = string.Empty;

while ((command = Console.ReadLine()) != "end")
{
    List<string> arguments = command.Split().ToList();

    if (arguments[0] == "Add")
    {
        int passengers = Convert.ToInt32(arguments[1]);
        wagons.Add(passengers);
    }
    else if (int.TryParse(arguments[0], out int passengers))
    {
        FindWagonToFitIncomingPassengers(wagons, wagonCapacity, passengers);
    }
}

Console.WriteLine(string.Join(" ", wagons));

static List<int> FindWagonToFitIncomingPassengers(List<int> wagons, int capacity, int passengers)
{
    for (int i = 0; i < wagons.Count; i++)
    {
        int wagonCapacityCheck = wagons[i] + passengers;

        if (wagonCapacityCheck <= capacity)
        {
            wagons[i] += passengers;
            break;
        }
    }

    return wagons;
}