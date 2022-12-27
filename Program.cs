// See https://aka.ms/new-console-template for more information

string[] elements = new string[] {"Hello", "2", "world", ":-)"};
string[] array = new string[elements.Length];

SecondArrayWithIF(elements, array);

int count = 0;
for (int i = 0; i < elements.Length; i++)
    {
    if(elements[i].Length <= 3)
        {
        count++;
        }
    }
PrintArray(array);

void SecondArrayWithIF(string[] elements, string[] array)
{
    int count = 0;
    for (int i = 0; i < elements.Length; i++)
    {
    if(elements[i].Length <= 3)
        {
        array[count] = elements[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write($"from the elements [{String.Join(",", elements)}] the the variables which contain 3 or less digits are [");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

