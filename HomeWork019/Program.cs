/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int GetNumberFromUser(string userMessage)
{
    Console.WriteLine(userMessage);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
string FindPalindrome(int number)
{
    string result = "";
    int num1 = number / 10000;
    int num2 = (number / 1000) % 10;
    int num3 = (number % 100) / 10;
    int num4 = (number % 10);
    if (num1 == num4 && num2 == num3)
    {
        Console.WriteLine($"Число {number} палиндром.");
    }
    else
    {
        Console.WriteLine($"Число {number} не палиндром.");
    }
    return result;
}
int userNumber = GetNumberFromUser("Введите пятизначное число: ");
string findPalindrome = FindPalindrome(userNumber);

