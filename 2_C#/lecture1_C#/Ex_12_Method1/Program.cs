// Метод Вид1 не принимает ничего и ничего не возвращает
//void Method1();
{
    // Console.WriteLine("тест...");
}
Method1();











// Метод Вид2, что-то принимаю, но ничего не возвращают // вывод сообщения несколько раз
void Method2(string msg)
{
    //Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения"); // именновай аргумент

//void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        //Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4); // сколько раз вывести сообщение - 4 раза
// Method21(count: 4, msg: "новый текст"); // порядок не имеет значения







//Метод Вид3, что-то возвращает, но ничего не принимает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);







// Метод Вид4, что-то принимает и что-то возвращает // склеивание строки
//string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // пустая строка, можно заменить на ...= "";

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf"); // вызов метода: вывод текста 10 раз
//Console.WriteLine(res);

//Вид41 тоже самое, с циклом for
//string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
     {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf");
//Console.WriteLine(res);

//вывод таблицы умножения на экран
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //Console.WriteLine($"{i} x {j} = {i*j}");
    }
    //Console.WriteLine(); // переход на новую строку
}







//Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.

string text = "орвапопоыткдп кпуктк4упт укепщ5опжц4щш" 
            + "лапот  кепокушщ ощшкоепщшко кщео5"     
            + "керн  гно нго ш  шгл г"                 
            + "23к3 235к3  пен е нр";                  

// каждый элемент строки имеет свой индекс, как в массиве
// string s = "qwerty"
//   индексы   012345
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // положить в результат новое значение в виде строки
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);

//Массив. Алгоритм сортировки
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) // вывод массива на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}"); // вывод в одну строку (вместо WriteLine -> Write)
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // array.Length - 1 это общее количество элементов, т.к. индекс начинается с 0
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++) // j = i + 1 - это значит что отсортированные элементы, которые уже вначале строки мы не трогаем
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);