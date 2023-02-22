
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// // 23432 -> да

Console.WriteLine("Введите пятизначное  число:");
var stringNumber = Console.ReadLine();
int number;
bool isNumber = int.TryParse(stringNumber, out number); 

if (isNumber)
{
    if (number > 10000 & number < 100000 || number <= -10000 & number > -100000)
    {
        int result = 0;
        int lastNumber = number % 10;
        int lastDNumber = number / 10;

        int last2Number = lastDNumber % 10;
        int last2DNumber = lastDNumber / 10;

        int last3Nunmer = last2DNumber % 10;
        int last3DNumber = last2DNumber / 10;

        int last4Nunmer = last3DNumber % 10;
        int last4DNumber = last3DNumber / 10;

        int last5Nunmer = last4DNumber % 10;
        int last5DNumber = last4DNumber / 10;

        result = (10000 * lastNumber) + (1000 * last2Number) + (100 * last3Nunmer) + (10 * last4Nunmer) + last5Nunmer;
        if (number == result)
        {
            Console.WriteLine($"Число {number} является  палиндромом!");
        }
        else
        {
            Console.WriteLine($"Число {number} не является  палиндромом!");
        }
    }

    else
    { Console.WriteLine("Вы ввели не пятизначное число. Попробуйте еще  раз!"); }
}
else
{
    Console.WriteLine("Вы ввели недопустимые символы. Попробуйте еще  раз ввести только цифры!");
}