

// ROTATE A GIVEN LIST TO THE LEFT OR TO THE RIGHT FROM A GIVEN INDEX IN IT

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
//int number = 3;
//int power = 2;

//count %= numbers.Count;
//List<int> rotatedNumbers = numbers.GetRange(0, count);
//numbers.RemoveRange(0, count);
//numbers.InsertRange(numbers.Count, rotatedNumbers);

//Console.WriteLine(string.Join(" ", numbers));

//count %= numbers.Count;
//List<int> rotatedNumbers = numbers.GetRange(numbers.Count - count, count);
//numbers.RemoveRange(numbers.Count - count, count);
//numbers.InsertRange(0, rotatedNumbers);

//Console.WriteLine(string.Join(" ", numbers));

///////////////////////////////////////////////////////////////////////////////////////////
///

// REMOVE ELEMENTS IN A LIST FROM A GIVEN ELEMENT WITH A GIVEN POWER OF RANGE


//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
//int number = 3;
//int power = 2;

//int index = numbers.IndexOf(number);

//int leftIndex = Math.Max(0, index - power);

//////////////////////////////////////////////////////////////////////////////////////////

//List<string> names = new List<string> { "ivo", "miro", "tosho", "stefo", "gergan" };
//int start = 0;
//int end = 3;

//string merged = string.Empty;

//for (int i = start; i <= end; i++)
//{
//    //Console.WriteLine(names[i]);
//    merged += names[i];
//    names.Remove(names[i]);
//}

////names.Insert(start, merged);
//Console.WriteLine(string.Join(" ", names));

////////////////////////////////////////////

//string merged = string.Concat(input.Skip(startIndex).Take(endIndex - startIndex + 1));
//input.RemoveRange(startIndex, endIndex - startIndex + 1);
//input.Insert(startIndex, merged);

///////////////////////////////////////////////



List<string> list = new List<string> { "ivoslavuio", "miro", "tosho", "stefo", "gergan" };
int partitions = 3;

string changingElement = list[0];
list.RemoveAt(0);
List<string> parts = new List<string>();

for (int i = 0; i < changingElement.Length; i += partitions)
{
    int length = Math.Min(partitions, changingElement.Length - i);
    parts.Add(changingElement.Substring(i, length));
}

string lastElement = parts[parts.Count - 1];
if (lastElement.Length < partitions)
{
    string concatElement = parts[parts.Count - 2];
    string resultElement = concatElement += lastElement;
    parts.RemoveAt(parts.Count - 1);
    parts.RemoveAt(parts.Count - 1);

    parts.Add(resultElement);
}

parts.Reverse();
for (int i = 0; i < parts.Count; i++)
{
    list.Insert(0, parts[i]);
}

Console.WriteLine(string.Join(" ", parts));

Console.WriteLine(string.Join(" ", list));