// Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите целое число:   ");

string number = Console.ReadLine()!;

int length = number.Length;

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (IsPalindrome()) Console.WriteLine($"Введное число - {number} - является палиндромом");
else Console.WriteLine($"Число {number} не является палиндромом");

