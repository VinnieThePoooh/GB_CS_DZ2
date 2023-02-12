// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру, обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number<1 || number>7)
{
    System.Console.WriteLine("Введенное значение не обозначает день недели");
}
else
{
    if ( number == 6 || number == 7)
    {
        System.Console.WriteLine("Выходной");
    }
    else
    {
        System.Console.WriteLine("Будний");
    }
}