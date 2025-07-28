List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "End")
{
    List<string> arguments = command.Split().ToList();
    int number, index, count;
    string leftOrRightCommand = string.Empty;

    switch (arguments[0])
    {
        case "Add":
            number = int.Parse(arguments[1]);
            inputList = AddNumberToList(inputList, number);
            break;

        case "Insert":
            number = int.Parse(arguments[1]);
            index = int.Parse(arguments[2]);

            if (index >= 0 && index <= inputList.Count)
            {
                inputList = InsertNumber(inputList, number, index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            break;

        case "Remove":
            index = int.Parse(arguments[1]);

            if (index >= 0 && index <= inputList.Count)
            {
                inputList = RemoveNumber(inputList, index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            break;

        case "Shift":
            leftOrRightCommand = arguments[1];
            int iterationCount = int.Parse(arguments[2]);

            if (leftOrRightCommand == "left")
            {
                inputList = LeftRotation(iterationCount, inputList);
            }
            else if (leftOrRightCommand == "right")
            {
                inputList = RightRotation(iterationCount, inputList);
            }
            break;
    }
}

Console.WriteLine(string.Join(" ", inputList));

static List<int> RightRotation(int iterationCount, List<int> list)
{
    iterationCount %= list.Count;
    List<int> rotatedPart = list.GetRange(list.Count - iterationCount, iterationCount);

    list.RemoveRange(list.Count - iterationCount, iterationCount);
    list.InsertRange(0, rotatedPart);

    return list;
}

static List<int> LeftRotation(int iterationCount, List<int> list)
{
    iterationCount %= list.Count;
    List<int> rotatedPart = list.GetRange(0, iterationCount);

    list.RemoveRange(0, iterationCount);
    list.InsertRange(list.Count, rotatedPart);

    return list;
}

static List<int> RemoveNumber(List<int> list, int index)
{
    list.RemoveAt(index);
    return list;
}

static List<int> InsertNumber(List<int> list, int number, int index)
{
    list.Insert(index, number);
    return list;
}

static List<int> AddNumberToList(List<int> list, int number)
{
    list.Add(number);
    return list;
}