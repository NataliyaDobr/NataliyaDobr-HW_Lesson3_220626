// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

double xa = Prompt("Введите координату первой точки по оси X ");
double ya = Prompt("Введите координату первой точки по оси Y ");
double za = Prompt("Введите координату первой точки по оси Z ");

double xb = Prompt("Введите координату второй точки по оси X ");
double yb = Prompt("Введите координату второй точки по оси Y ");
double zb = Prompt("Введите координату второй точки по оси Z ");

double AB = Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb));

System.Console.WriteLine(AB);