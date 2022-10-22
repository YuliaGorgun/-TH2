// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введи цифру, обозначающую день недели: ");
int dayNumber =  int.Parse (Console.ReadLine()!);

//denNedeli[1] = "понедельник";
//denNedeli[2] = "вторник";
//denNedeli[3] = "среда";
//denNedeli[4] = "четверг";
//denNedeli[5] = "пятница";
//denNedeli[6] = "суббота";
//denNedeli[7] = "воскресенье";

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("этот день выходной");
}    
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("это вообще не день недели");
}
else Console.WriteLine("этот день не выходной");
