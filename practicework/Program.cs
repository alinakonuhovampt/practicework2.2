Console.WriteLine("выберите программу, которую хотите запустить: ");

Console.WriteLine("1. Игра угадай число ");
Console.WriteLine("2. Вывести все делители числа");
Console.WriteLine("3. Таблица умножения");
Console.WriteLine("4. Выйти из программы");

int k = 0;
while (k<=3)
{
    int count = Convert.ToInt32(Console.ReadLine());
    k = count; 
    if (count == 1)
    {
        Console.WriteLine("Игра 'угадай число' ");


        Random random = new Random();
        int rnd = random.Next(0, 101);
        Console.WriteLine("Введите число от 0 до 100: ");

        while (true)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < rnd)
            {
                Console.WriteLine("Введите число побольше ");

            }
            else if (a > rnd)
            {
                Console.WriteLine("Введите число поменьше ");
            }
            else 
            {
                Console.WriteLine("Ура победа!");
                break;
            }

        }
        Console.WriteLine("выберите программу: ");
    }
   
    if (count == 2)
    {
        Console.Write("Введи число ");
        int a = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i<=a)
        {
            i++;
            if (a % i == 0)
                Console.WriteLine(i);
        }
        Console.WriteLine("выберите программу: ");
    }
    if (count == 3)
    {
        int[,] A = new int[10, 10];
        for (int i=1; i<=10; i++)
        {
            for (int j = 1; j<=10; j++)
            {
                Console.Write(i * j + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("выберите программу, которую хотите запустить: ");
    }
}
