class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split().ToList();
        string command;

        while ((command = Console.ReadLine()) != "3:1")
        {
            string[] arguments = command.Split();

            switch (arguments[0])
            {
                case "merge":
                    int startIndex = int.Parse(arguments[1]);
                    int endIndex = int.Parse(arguments[2]);

                    startIndex = Math.Max(0, startIndex);
                    endIndex = Math.Min(input.Count - 1, endIndex);

                    if (startIndex <= endIndex && startIndex < input.Count)
                    {
                        input = MergeStrings(input, startIndex, endIndex);
                    }
                    break;

                case "divide":
                    int index = int.Parse(arguments[1]);
                    int partitions = int.Parse(arguments[2]);

                    if (index >= 0 && index < input.Count && partitions > 0 && partitions <= 100)
                    {
                        input = DivideStrings(input, index, partitions);
                    }
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", input));
    }

    static List<string> DivideStrings(List<string> list, int index, int partitions)
    {
        if (partitions < 1)
        {
            return list;
        }

        string element = list[index];
        list.RemoveAt(index);

        List<string> parts = new List<string>();
        int partLength = element.Length / partitions;
        int remainder = element.Length % partitions;

        int currentIndex = 0;

        for (int i = 0; i < partitions; i++)
        {
            int currentPartLength = partLength + (i < remainder ? 1 : 0);

            if (currentIndex + currentPartLength > element.Length)
            {
                currentPartLength = element.Length - currentIndex;
            }

            parts.Add(element.Substring(currentIndex, currentPartLength));
            currentIndex += currentPartLength;
        }

        list.InsertRange(index, parts);
        return list;
    }

    static List<string> MergeStrings(List<string> list, int startIndex, int endIndex)
    {
        if (startIndex > endIndex)
        {
            return list;
        }

        StringBuilder merged = new StringBuilder();

        for (int i = startIndex; i <= endIndex; i++)
        {
            merged.Append(list[i]);
        }

        list.RemoveRange(startIndex, endIndex - startIndex + 1);
        list.Insert(startIndex, merged.ToString());

        return list;
    }
}
