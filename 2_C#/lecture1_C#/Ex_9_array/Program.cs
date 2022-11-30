// Функция возьмет три число и найдет из них максимальное, потом следующие три числе и найдет из них макс и в конце максимальное из трех максимальных. 
//поиск максимума из 9 чисел.
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//   индексы:    0   1   2   3   4   5   6   7   9
int [] array = {11, 21, 31, 41, 15, 61, 17, 211, 19};

int result = Max(
  Max(array[0], array[1], array[2]),
  Max(array[3], array[4], array[5]),
  Max(array[6], array[7], array[8])
);

Console.WriteLine(result);
