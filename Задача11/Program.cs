// задача 11 hard. Напишите программу, которая принимает от пользователя целое число любой разрядности и удаляет вторую цифру этого числа.


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int allNum = (int)Math.Log10(num) + 1; 
int predLastNumMnojitel = (int)Math.Pow(10, allNum - 2); 
int result = num % predLastNumMnojitel + num / predLastNumMnojitel / 10 * predLastNumMnojitel; 
Console.WriteLine(result); 