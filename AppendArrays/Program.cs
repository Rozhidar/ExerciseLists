List<string> input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries)
    .Select(element => element.Trim()).Where(element => !string.IsNullOrWhiteSpace(element)).ToList();

List<string> resultList = new List<string>();

for (int i = input.Count - 1; i >= 0; i--)
{
    List<string> currentPart = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
    resultList.AddRange(currentPart);
}

Console.WriteLine(string.Join(" ", resultList));
