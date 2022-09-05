// 1) Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int PowNumber(int number, int pow) 
{ 
    int result = 1; 
    for (int i = 0; i < pow; i++) 
    { 
        result *= number; 
    } 
 
    return result; 
} 
 
Console.WriteLine("Введите число A:"); 
int A = int.Parse(Console.ReadLine()); 
 
Console.WriteLine("Введите число B:"); 
int B = int.Parse(Console.ReadLine()); 
 
Console.WriteLine(PowNumber(A, B));

// 2) Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNumberDigits(int number) 
{ 
    int sum = 0; 
    foreach (char digit in number.ToString()) 
    { 
        sum += int.Parse(digit.ToString()); 
    } 
 
    return sum; 
} 
 
Console.WriteLine("Введите число:"); 
int n = int.Parse(Console.ReadLine()); 
Console.WriteLine(SumNumberDigits(n));

// 3) Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetArray(int size) { 
    int[] numbers = new int[size]; 
    var rand = new Random(); 
    for (int i = 0; i < size; i++) 
    { 
        numbers[i] = rand.Next(100); 
    } 
 
    return numbers; 
} 
 
void PrintArray(int[] array) { 
    string result = ""; 
    for (int i = 0; i < array.Count(); i++) 
    { 
        if (i > 0) 
        { 
            result += ", "; 
        } 
        result += array[i]; 
    } 
    Console.WriteLine("[" + result + "]"); 
} 
 
int[] numbers = GetArray(8); 
PrintArray(numbers);