int ArrayCheck(string[] array, int size)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size) count++;
    }
    return count;


Console.Write("Введите количество строк предполагаемого массива: ");
int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
Console.Write("Введите количество символов строки массива, которое хотите вывести на экран: ");
int m = Convert.ToInt32(Console.ReadLine());
int size = m;
string[] array = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите строку №{0}:   ", i + 1);
    array[i] = Console.ReadLine(); //Заполняем его элементами введенными с клавиатуры
    
}
    Console.WriteLine();
    Console.Write("Start array-> [");
    Console.Write(String.Join(",", array));Console.Write("]"); 

    int count = ArrayCheck(array, size);
