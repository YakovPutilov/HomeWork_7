﻿    // Задача 2: Напишите программу вычисления функции Аккермана 
    // с помощью рекурсии. Даны два неотрицательных числа m и n.

//     функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))
    
int AcMan(int m, int n){
    if(m == 0) return n + 1;
    else{
        if(n == 0){
            return AcMan(m - 1, 1);
        }
        else{
            return AcMan(m - 1, AcMan(m, n - 1));
        }
    }

}

int result = AcMan(3,2);
Console.WriteLine(result);

