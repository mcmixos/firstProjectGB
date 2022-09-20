Console.Clear();

string[] currentArray = new string[] {"Git", "GitHub", "c++", "c#", "Java"};

string[] newArray = NewThreeCharsArrayCreation(currentArray);
Console.WriteLine("New array: " + String.Join (" ", newArray));

string[] NewThreeCharsArrayCreation(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        count++;
    }
    string[] changedArray = new string[count + 1];

    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            changedArray[count] = array[i];
            count++;
        }
    }
    return changedArray;
}