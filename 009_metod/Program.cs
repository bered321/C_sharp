int Max(int arg1, int agr2, int agr3)
{
    int result = arg1;
    if (agr2 > result) result = agr2;
    if (agr3 > result) result = agr3;
    return result;
}

int a1 = 10;
int b1 = 20;
int c1 = 30;
int a2 = 10;
int b2 = 600;
int c2 = 30;
int a3 = 10;
int b3 = 1111120;
int c3 = 30;

/*nt max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);*/

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);