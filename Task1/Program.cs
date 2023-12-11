// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter M");
int m = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int n, int m){
    if (m > n) {
        NaturalNumbers(n,m - 1);
        Console.Write(m + " ");
    }
    else if(m < n){
        Console.WriteLine("M must be graiter then N");
    }    
}


NaturalNumbers(n,m);
