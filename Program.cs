// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string [] array_initial = new string [5] {"125","3467","873","99","0076"};
string [] alter_array = new string[5];

alter_array = CreateArray(array_initial, alter_array);
Console.Write("Исходный массив: ");
Output(array_initial);
Console.Write("Преобразованный массив: ");
Output(alter_array);

string [] CreateArray(string [] array, string [] new_array)
{
  int j = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      new_array[j] = array[i];
      j++;
    }
  }
  return new_array;
}

void Output(string [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i]+" ");
  }
  Console.WriteLine();
}