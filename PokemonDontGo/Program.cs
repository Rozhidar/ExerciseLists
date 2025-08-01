List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
int sum = 0;

while (pokemons.Count > 0)
{
    int currentIndex = int.Parse(Console.ReadLine());
    int elementToRemoveIndex;

    if (currentIndex < 0)
    {
        elementToRemoveIndex = pokemons.First();
        int lastElement = pokemons.Last();
        pokemons.RemoveAt(0);
        pokemons.Insert(0, lastElement);
    }
    else if (currentIndex >= pokemons.Count)
    {
        elementToRemoveIndex = pokemons.Last();
        int firstElement = pokemons.First();
        pokemons.Insert(pokemons.Count, firstElement);
        pokemons.RemoveAt(pokemons.Count - 2);
    }
    else
    {
        elementToRemoveIndex = pokemons[currentIndex];
        pokemons.RemoveAt(currentIndex);
    }

    sum += elementToRemoveIndex;
    pokemons = NormalizeNumbers(pokemons, elementToRemoveIndex);
}

Console.WriteLine(sum);

static List<int> NormalizeNumbers(List<int> list, int element)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] <= element)
        {
            list[i] += element;
        }
        else
        {
            list[i] -= element;
        }
    }

    return list;
}
