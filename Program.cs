// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Матрица

// int[,] CreateMartix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     Random rnd = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = rnd.Next(101);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         /////////////////////////////////////////////////
//         for (int j = 0; j < matr.GetLength(1); j++)    //
//         {                                              // <- Попали в 0 строку, проверили все столбцы
//             Console.Write($"[{matr[i, j]}]\t");          //
//         }////////////////////////////////////////////////  
//         Console.WriteLine(" ");
//     }
// }

// void SquareElements(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matr[i, j] *= matr[i, j];
//             }
//         }
//     }
// }

// Console.Clear();

// Console.Write("Enter the number of lines -> ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter the number of columns -> ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("\n");

// int[,] result = CreateMartix(rows, cols);
// PrintMatrix(result); //<<<<<<<<<<<<<<<<<<<<<<<<<<< Матрица ДО
// Console.Write("\n");

// Console.WriteLine("Result : \n");

// SquareElements(result);
// PrintMatrix(result); //<<<<<<<<<<<<<<<<<<<<<<<<<<< Матрица ПОСЛЕ
// Console.Write("\n");

// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.

// int[,] CreateMartix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     Random rnd = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = rnd.Next(101);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)    
//         {                                              
//             Console.Write($"[{matr[i, j]}]\t");          
//         } 
//         Console.WriteLine(" ");
//     }
// }

// int GetSumEqualIndex(int[,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)    
//         {                                              
//             if(i == j)
//             {
//                 sum += matr[i,j];
//             }
//         } 
//     } 
//     return sum;
// }


// Console.Clear();

// Console.Write("Enter the number of lines -> ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter the number of columns -> ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("\n");

// int[,] result = CreateMartix(rows,cols);
// PrintMatrix(result);
// Console.WriteLine($"\nResult: {GetSumEqualIndex(result)}");


//////////////////////////////////////////////////////////////////////
// int[,] CreateMartix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     Random rnd = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = rnd.Next(101);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"[{matr[i, j]}]\t");
//         }
//         Console.WriteLine(" ");
//     }
// }

// double[] GetArrayWithMeans(int[,] matr)
// {
//     double[] means = new double[matr.GetLength(0)];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         double currentSum = 0;
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             currentSum += matr[i, j];
//         }
//         double currentMeans = Math.Round(currentSum / matr.GetLength(1), 2);
//         means[i] = currentMeans;
//     }
//     return means;
// }

// Console.Clear();

// Console.Write("Enter the number of lines -> ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter the number of columns -> ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("\n");

// int[,] result = CreateMartix(rows, cols);
// PrintMatrix(result);
// Console.Write("\n");

// double[] means = GetArrayWithMeans(result);
// Console.WriteLine($"Result : [{string.Join(";", means)}]");

/////////////////////////////////////////////////////////////////

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет: 
// "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

// В коде, начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;


// bool ValidatePosition(int[,] array, int x, int y)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         }
//     }
//     if (x > array.GetLength(0) && y <= array.GetLength(1))
//     {
//         Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//         return false;
//     }
//     else if (x <= array.GetLength(0) && y > array.GetLength(1))
//     {
//         Console.WriteLine("Позиция по рядам выходит за пределы массива");
//         return false;
//     }
//     else if (x > array.GetLength(0) && y > array.GetLength(1))
//     {
//         Console.WriteLine("Позиция по рядам и колонкам выходит за пределы массива");
//         return false;
//     }
//     return true;
// }


// int FindElementByPosition(int[,] array, int x, int y)
// {
//     int findElement = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (x == i && y == j)
//             {
//                 findElement = array[i, j];
//             }
//         }
//     }
//     return findElement;
// }

// void PrintResult(int[,] numbers, int x, int y)
// {
//     ValidatePosition(numbers, x - 1, y - 1);
//     Console.WriteLine(FindElementByPosition(numbers, x - 1, y - 1));
// }


// int[,] numbers = new int[,]
// {
//     {10,20,30,40},
//     {50,60,7,8},
//     {9,10,11,12},
// };

// int x = 2;
// int y = 1;

// PrintResult(numbers, x, y);



// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int[,] numbers = new int[,] 
// {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 

// Выводится:

// 9   10  11  12
// 5   6   7   8
// 1   2   3   4

// int[,] numbers = new int[,]
// {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12},
// };

// // Печать массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine(" ");
//     }
// }

// int[,] SwapFirstLastRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         SwapItems(array, i);
//     }
//     return array;
// }


// // Обмен элементами массива
// void SwapItems(int[,] array, int i)
// {
// int temp = array[0, i];
// array[0, i] = array[array.GetLength(0) - 1, i];
// array[array.GetLength(0) - 1, i] = temp;
// }

// // Печать результата
// void PrintResult(int[,] numbers)
// {
//     PrintArray(SwapFirstLastRows(numbers));
// }

// Console.Clear();
// PrintResult(numbers);

// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


// int[,] numbers = new int[,] {
//                 {1, 200, 3},
//                 {1, 123, 0},
//                 {7, 84, 2},
//                 {9, 10, 11}
// };

// /// Вычисление сумм по строкам (на выходе массив с суммами строк)
// int[] SumRows(int[,] array)
// {
//     int[] sums = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int currentSums = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             currentSums += array[i, j];
//         }
//         sums[i] = currentSums;
//     }
//     return sums;
// }

// // Получение индекса минимального элемента в одномерном массиве
// int MinIndex(int[] array)
// {
//     int minIndex = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (array[i] < array[minIndex])
//         {
//             minIndex = i;
//         }
//     }
// return minIndex;
// }

// void PrintResult(int[,] numbers)
// {
// int[] sum = SumRows(numbers);
// Console.WriteLine(MinIndex(sum));
// }

// PrintResult(numbers);


//Урок 6. Массивы и строки//

// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string GetStringFromCharArray(char[] array)
// {
//     string result = string.Empty;  // " "
//     foreach (char symbol in array)
//     // symbol = 'a', symbol = 'b', symbol = 'c', symbol = 'd'
//     {
//         result += symbol;
//         // res = " " + 'a', res = "a"
//         // res = "a" + 'b', res = "ab"
//         // res = "ad" + 'c', res = "abc"
//         // res = "abc" + 'd', res = "abcd"
//     }
//     return result;
// }

// char[] chars = {'1','d','!','2','f'};
// Console.WriteLine($"Массив -> [{string.Join("; ", chars)}]");
// string res = GetStringFromCharArray(chars);
// Console.WriteLine(res);



// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// char [] ConvertStringToCharArray (string str)
// {
//     char [] chars = new char[str.Length];
//     // "hi" -> [,]
//     // "hi" -> [str[0] ,str[1]]
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }

// string str = "Hello World";
// Console.WriteLine($"Строка -> {str}");
// char[] chars = ConvertStringToCharArray(str);
// Console.WriteLine($"Массив -> [{string.Join("; ", chars)}]");

