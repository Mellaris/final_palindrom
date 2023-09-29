
Console.WriteLine("Число - Палиндром");
Console.Write("Введите ваше число(10 система счисления): ");
int number = Convert.ToInt32(Console.ReadLine());
int help = number;
int help_2 = number;
int count = 0;
string otvet = "";
string otvet_2 = "";
int count_2 = 0;
int[] massiv = new int[36];
int index = 0;
string[] letter = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
int[] numb_er = new int[26] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 };
for (int sistem = 2; sistem <= 36; sistem++)
{
    count = 0;
    help = help_2;
    number = help_2;
    while (help >= sistem)
    {
        help = help / sistem;
        count++;
    }
    int[] result = new int[count + 1];
    for (int i = 0; sistem <= 36 && i < count + 1; i++)
    {
        result[i] = number % sistem;
        number = number / sistem;
    }
        for (int i = count; i >= 0; i--)
        {
            if (result[i] <= 9)
            {
                otvet = otvet + result[i];
            }
            for (int q = 0; q < 26; q++)
            {
                if (result[i] == numb_er[q])
                {
                    otvet = otvet + letter[q];
                }
            }
        }
        for (int i = 0; i <= count; i++)
        {
            if (result[i] <= 9)
            {
                otvet_2 = otvet_2 + result[i];
            }
            for (int q = 0; q < 26; q++)
            {
                if (result[i] == numb_er[q])
                {
                    otvet_2 = otvet_2 + letter[q];
                }
            }
        }
        Console.WriteLine($"\nОтвет: {otvet}");
       //Console.WriteLine($"\nОтвет: {otvet_2}");
    if (otvet == otvet_2 && otvet.Length > 1)
    {
        //Console.WriteLine(sistem);
        count_2 = count_2 + 1;
        massiv[index] = sistem;
        index = index + 1;
    }
    otvet = "";
    otvet_2 = "";
}
if (count_2 == 1)
{
    Console.Write($"unique:  ");
    for (int i = 0; i < count_2; i++)
    {
        Console.Write($"{massiv[i]} ");
    }
}
else if (count_2 > 1)
{
    Console.Write($"multiple: ");
    for (int i = 0; i < count_2; i++)
    {
        Console.Write($"{massiv[i]} ");
    }
}
else
{
    Console.Write($"none ");
}