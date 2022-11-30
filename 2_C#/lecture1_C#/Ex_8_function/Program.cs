// Функция возьмет три число и найдет из них максимальное, потом следующие три числе и найдет из них макс и в конце максимальное из трех максимальных.
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 2;
int b1 = 54;
int c1 = 15;
int a2 = 15;
int b2 = 152;
int c2 = 15;
int a3 = 15;
int b3 = 400;
int c3 = 15;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

// строки с 19 по 22 можно заменить одной строкой:
int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3)
);

Console.WriteLine(max);