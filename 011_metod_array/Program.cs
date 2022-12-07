int[] array = { 1, 22, 23, 37, 49, 67, 32, 49 };
int n = array.Length;
int find = 49;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}