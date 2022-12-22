// Рекурсия. В аздачах сравниваются методы применения рекурсии и обычных циклов (итеративный подход)

//Задача. Собрать строку с числами от а до б, а <= б
//Итеративный подход
string NumberFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(NumberFor(1, 10));

//Рекурсивный подход
string NumberRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumberRec(a + 1, b);
    else return string.Empty;
}
Console.WriteLine(NumberRec(1, 10));
//==============================================================

//Задача. сумма чисел от 1 до n
//Итеративный подход
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result  += i;
    return result;
}
Console.WriteLine(SumFor(10));

//Рекурсивный подход
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n-1);
}
Console.WriteLine(SumRec(10));
//==============================================================

//Задача. Факториал числа
//Итеративный подход
int FactorialFor(int n)
{
    int result = 1;
    for (int i=1; i <= n; i++) result *=1;
    return result;
}
Console.WriteLine(FactorialFor(10));

//Рекурсивный подход
int FactorialRec(int n)
{
    if (n==1) return 1;
    else return n * FactorialRec(n-1);
}
Console.WriteLine(FactorialRec(10));
//==============================================================

//Задача. Вычислить а в степени n
//Итеративный подход
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
Console.WriteLine(PowerFor(2, 10));

//Рекурсивный подход
int PowerRec(int a, int n)
{   //return n == 0 ? 1 : PowerRec(a, n-1) * a; // заменят две строки ниже - тернарный оператор
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(2, 10));

//Математический подход
int PowerRecMath(int a, int n)
{   
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerRecMath(2, 10));
//==============================================================

//Задача. Перебор слов. Имеются четыре буквы: а, и, с, в. Покажите все слова, состоящие из Т букв, которые можно построить из букв этого алфавита.
//Итеративный подход. Для каждой новой буквы в слове нужно будет добавлять новый цикл
char[] s = { 'а', 'и', 'с', 'в'};
int count = s.Length;
int n = 1;
// только для слова из 4х букв:
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                Console.WriteLine($"{n++, -5} {s[i]} {s[j]} {s[k]} {s[l]}");
            }
        }
    }
}

//Рекурсивный подход
void FindWords(string alphavet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphavet.Length; i++)
    {
        word[length] = alphavet[i];
        FindWords(alphavet, word, length + 1);
    }
}

FindWords("аисв", new char[5]);
//==============================================================

//Обход содержимого папок
//Итеративный подход.
string part = "/Users/Denis/Desktop/Обучение GB/1 Пакет Разработчик/1 четверть/5_workshop/2_C#/lecture1_C#/Ex_4_Div";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}

//Рекурсивный подход
void CatalogInfo(string path, string indent = "")
{
    DirectiryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();
}
