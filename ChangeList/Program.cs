List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split();
    int element, position;

    switch (arguments[0])
    {
        case "Delete":
            element = int.Parse(arguments[1]);
            list = DeleteEqualElements(list, element);
            break;

        case "Insert":
            element = int.Parse(arguments[1]);
            position = int.Parse(arguments[2]);
            list = InsertElementAtPosition(list, element, position);
            break;
    }
}

Console.WriteLine(string.Join(" ", list));

static List<int> InsertElementAtPosition(List<int> list, int element, int position)
{
    list.Insert(position, element);
    return list;
}

static List<int> DeleteEqualElements(List<int> list, int element)
{
    list.RemoveAll(n => n == element);
    return list;
}