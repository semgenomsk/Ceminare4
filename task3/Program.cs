// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadNumber(string message)
{
    Console.Write(message);    
    return Convert.ToInt32(Console.ReadLine());    
}

int MultNumbersFrom1ToA(int a)
{
    if (a >= 1)     //если A >= одному, то работаем дальше
    {
        int sum=1;
        for (int i=1;i<=a;i++)
        {
            sum=sum*i;  //копим сумму
            //sum += i;
        }
        return sum;     //вернем накопившуюся сумму
    }
    else
    {
        Console.WriteLine("Число A должно быть не меньше 1!");
        return -1;  //не корректно посчитанная сумма (код ошибки)
    }
}

int number = ReadNumber("Введите число: ");
int summa = MultNumbersFrom1ToA(number);
Console.Write($"Произведение элементов от 1 до A = {summa}");