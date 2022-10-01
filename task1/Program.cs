// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadNumber(string message)
{
    Console.Write(message);    
    return Convert.ToInt32(Console.ReadLine());    
}

int SumNumbersFrom1ToA(int a)
{
    if (a >= 1)     //если A >= одному, то работаем дальше
    {
        int sum=0;
        for (int i=1;i<=a;i++)
        {
            sum=sum+i;  //копим сумму
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
int summa = SumNumbersFrom1ToA(number);
Console.Write($"Сумма элементов от 1 до A = {summa}");
