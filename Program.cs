// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.WriteLine("Enter the number of the day of the week: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 6 || dayWeek == 7)
{
    Console.WriteLine("This is the day of the week off");
}
else if (dayWeek < 1 || dayWeek > 7)
{
    Console.WriteLine("There is no such day");
}
else
{
    Console.WriteLine("This is the day of the week is not a day off");
}