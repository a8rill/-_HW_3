// Доп. задание №1:
// Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. 
// На вход будет подаваться число (сумма вклада). При значении меньше 100, будет начислено 5 %, 
// если значение находится в диапазоне от ста до двухсот — 7 %, 
// если больше — 10 %. Отработав, программа должна вывести общую сумму с начисленными процентами.

Console.WriteLine("Введите сумму вклада:");
var deposit = Console.ReadLine();
int number; // Если строчка состоит из чисел, то сюда попадает наше число
// TryParse(строчка, out переменная, куда сохраняется результат перевода)
bool isNumber = int.TryParse(deposit, out number); // True - cтрочка состоит из чисел, False - пр-т буквы, спецсимволы
if (isNumber) // isNumber == true
{
    if (number>0 & number<100)
    {
        double sumPercent = number + (((double)number * 5) / 100);
        Console.WriteLine($"Общая  сумма с начисленными процентами: {sumPercent}");
    }
    else if (number>=100 & number<200)  
    {
        double sumPercent = number + (((double)number * 7) / 100);
        Console.WriteLine($"Общая  сумма с начисленными процентами: {sumPercent}");
    }  
    else if (number>200)  
    {
        double sumPercent = number + (((double)number * 10) / 100);
        Console.WriteLine($"Общая  сумма с начисленными процентами: {sumPercent}");
    }  
    else if (number<0)  
    {
       
        Console.WriteLine($"Вы ввели  отрицательное число! Попробуйте  еще  раз.");
    }  
}
else
{
    Console.WriteLine("Вы ввели недопустимые символы. Попробуйте еще раз!");
}






