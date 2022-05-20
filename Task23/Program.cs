Console.WriteLine("Введите целое число ");
int N = int.Parse(Console.ReadLine());
int i = 1;

while(i < N + 1)
{
    Console.WriteLine($"Число {i , 5} | Куб числа {i * i * i , 5}");
    i ++;
}

