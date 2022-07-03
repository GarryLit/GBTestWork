/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.   
*/

string[] startArray = {"12","hello","2","world",":-)"};
string[] resultArray = new string[startArray.Length];


for( int i = 0; i < startArray.Length; i++)
{
    if(startArray[i].Length <= 3)
        resultArray[i] = startArray[i];
    else
    {
        continue;
    }    
   
}

System.Console.WriteLine(PrintArray(startArray));
System.Console.WriteLine(PrintArray(resultArray));

string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for( int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]} ";
    }

    result += "]";
  
    return result;
}




