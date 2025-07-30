List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> bombCharacteristics = Console.ReadLine().Split().Select(int.Parse).ToList();

int bombNumber = bombCharacteristics[0];
int power = bombCharacteristics[1];

while (numbers.Contains(bombNumber))
{
    int index = numbers.IndexOf(bombNumber);

    int leftIndex = Math.Max(0, index - power);
    int rightIndex = Math.Min(numbers.Count - 1, index + power);

    int range = rightIndex - leftIndex + 1;
    numbers.RemoveRange(leftIndex, range);
}

int sum = numbers.Sum();
Console.WriteLine(sum);