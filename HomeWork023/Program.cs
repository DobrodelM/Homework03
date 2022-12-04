/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
string getСubeofNumbers(int number)
{
    string result = "";
    int buf1 = 1;
    int buf2 = 0;
    while (buf1 <= number)
    {
        buf2 = buf1 * buf1 * buf1;
        result = result + " " + buf2;
        buf1++;
    }
    return result;
}
int userNumber = getNumberFromUser("Введите число N: ");
string cubeOfNumbers = getСubeofNumbers(userNumber);
Console.WriteLine(cubeOfNumbers);