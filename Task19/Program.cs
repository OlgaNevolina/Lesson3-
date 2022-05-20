Console.Write("Введите целое число: ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (IsPalindrome()) Console.WriteLine($"{number} палиндром");
else Console.WriteLine($"{number} не палиндром");

