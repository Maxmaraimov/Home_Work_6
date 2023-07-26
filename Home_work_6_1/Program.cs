// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
Console.Clear();
int Prompt(string message){
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void InputArray(int[] arr){
    for(int i=0;i<arr.Length;i++){
        arr[i]=new Random().Next(-10,10);
    }
}
int ReleaseArray(int[] arr){
    int count = 0;
    for(int i=0;i<arr.Length;i++){
        if(arr[i]>0){
            count++;
        }
    }
    return count;
}
int number = Prompt("Введите кол-во элементов в массиве: ");
Console.WriteLine();

int[] array=new int[number];
InputArray(array);
Console.Write($"[ {string.Join(", ", array)} ]");
Console.WriteLine();

// ReleaseArray(array);
Console.WriteLine($"Положительные элементов: N = {ReleaseArray(array)}");

