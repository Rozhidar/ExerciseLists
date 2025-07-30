

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


List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
int number = 3;
int power = 2;

int index = numbers.IndexOf(number);

int leftIndex = Math.Max(0, index - power);
