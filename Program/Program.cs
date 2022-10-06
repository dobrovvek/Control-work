string? stroka;
string[] Alex;

Console.WriteLine("Введите массив строк через запятую пример - ['0','1', ...] :");

stroka = Console.ReadLine();
stroka = stroka.Replace("[", "");
stroka = stroka.Replace("]", "");
stroka = stroka.Replace("'", "");

Alex = stroka.Split(',');

NewArray(Alex);

void NewArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 3) Console.Write($"'{array[i]}' ") ;
        
    }
    Console.Write("]");
}
