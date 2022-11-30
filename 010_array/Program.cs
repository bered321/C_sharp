int Max(int arg1, int agr2, int agr3)
{
    int result = arg1;
    if (agr2 > result) result = agr2;
    if (agr3 > result) result = agr3;
    return result;
}

int[] array = { 11, 12, 13, 20, 25, 23, 28, 29, 54 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);