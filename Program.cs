string[] startArr = { "Doom", "GTA", "Hunt", "^^)", "<3", "OpenGL", "D2", "Gothic", "1984" };

int CountThreeLetter(string[] arr, int len)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= len)
        {
            result++;
        }
    }
    return result;
}


