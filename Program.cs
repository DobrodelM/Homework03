/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double DisBetwPoints (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = 0;
    int xqu = (x2-x1)*(x2-x1);
    int yqu = (y2-y1)*(y2-y1);
    int zqu = (z2-z1)*(z2-z1);
    distance = Math.Sqrt(xqu+yqu+zqu);
    return distance;
}
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int x1 = getNumberFromUser("Введите x1: ");
int y1 = getNumberFromUser("Введите y1: ");
int z1 = getNumberFromUser("Введите z1: ");
int x2 = getNumberFromUser("Введите x2: ");
int y2 = getNumberFromUser("Введите y2: ");
int z2 = getNumberFromUser("Введите z2: ");

double distance = DisBetwPoints (x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстояние между точками равно: {Math.Round(distance, 2)}");
