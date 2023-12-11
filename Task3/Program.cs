// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void ReverseArray( int [] arr, int i){
    if (i<arr.Length){
        ReverseArray(arr, i+1);
        Console.Write(arr[i] + " ");
    }
}

int [] array = {1, 2, 5, 0, 10, 34};
ReverseArray(array, 0);