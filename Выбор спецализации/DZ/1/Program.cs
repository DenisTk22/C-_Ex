//
string [] array = new string [5] {"a", "-5", "Ostov", "9", "y"};
string [] array1 = new string [3];
for (int i = 0; i < new Random().Next(0, 3); i++)
{
    array1[i] = array[new Random().Next(0, array.Length-1)];
}
Console.WriteLine($"{string.Join(" ",array1)}");
