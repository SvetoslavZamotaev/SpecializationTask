string[] startArr = { "Doom", "GTA", "Hunt", "^^)", "<3", "OpenGL", "D2", "Gothic", "1984" };

int CountThreeLetter(string[] arr, int requiredLen)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= requiredLen)
        {
            count++;
        }
    }
    return count;
}

string[] RequiredArray(string[] arr, int count, int requiredLen)
{
    string[] result = new string[count];
    int indexResult = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= requiredLen)
        {
            result[indexResult] = arr[i];
            indexResult++;
        }
    }
    return result;
}

Console.WriteLine(string.Join(' ', RequiredArray(startArr, CountThreeLetter(startArr, 3), 3)));