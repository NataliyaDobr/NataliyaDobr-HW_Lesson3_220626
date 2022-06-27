// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int a = Prompt("Введите пятизначное число ");

if (a>9999 & a<100000) {
int a1 = a/10000;
int a2 = a/1000%10;
int a4 = a/10%10;
int a5 = a%10;

if (a1==a5 & a2==a4) {
    System.Console.WriteLine($"Число {a} - палиндром");
}

else System.Console.WriteLine($"Число {a} - не является палиндромом");

}
else System.Console.WriteLine("Введенное число не является пятизначным");