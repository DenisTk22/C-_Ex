// Поиск позиции нужного элемента в массиве
int [] array = {1, 12, 31, 4, 18, 15, 16, 18};

// n это количество элементов массива
int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        //остановка на первом найденном элементе:
        break;
    }
    //index = index =1; или:
    index ++;
}
