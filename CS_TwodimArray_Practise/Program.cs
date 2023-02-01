using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS_TwodimArray_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1 Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее произведение всех элементов, сумму четных элементовмассива А, сумму нечетных столбцов массива В
            //int[] A = new int[5];
            //int[,] B = new int[3,4];

            //int sum = 0, product = 1;;
            //int even_a = 0, odd_b = 0; 

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write("Enter element " + (i + 1) + " for one-dimen. array: ");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine();    
            //}
            //Console.Write("1D Array: ");
            //foreach (int i in A) {
            //    Console.Write("{0,4}", i);
            //}
            //Console.WriteLine();

            //Random rd= new Random();
            //Console.Write("\n2D Array: \n");
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        B[i,j] = rd.Next(10,30);
            //        Console.Write("{0,4}", B[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //int min = A[0], max = A[0];

            //foreach (var item in A)
            //{
            //    if (item < min) min = item;
            //    if (item > max) max = item;
            //    sum += item;
            //    if (item % 2 == 0) even_a += sum;
            //    product *= item;
            //}
            //foreach (var item in B) {
            //    if (item < min) min = item;
            //    if (item > max) max = item;
            //    sum += item;
            //    if (item % 2 == 1) odd_b += sum;
            //    product *= item;
            //}

            //Console.WriteLine();

            //Console.Write("Min - " + min + "\n");
            //Console.WriteLine("Max - " + max);
            //Console.WriteLine("Sum - " + sum);
            //Console.WriteLine("Product - " + product);
            //Console.WriteLine("Sum of even elements of 1D array - " + even_a);
            //Console.WriteLine("Sum of odd elements of 2D array - " + odd_b);
            #endregion
            #region #2 Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.
            //int[,] array = new int[5,5];
            //Random rd = new Random();
            //Console.Write("\n2D Array 5x5: \n");
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = rd.Next(-100, 100);
            //        Console.Write("{0,4}", array[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //int maxindexX = 0, maxindexY = 0;
            //int minindexX = 0, minindexY = 0;
            //int max = array[0, 0];
            //int min = array[0, 0];


            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (array[i, j] > max)
            //        {
            //            max = array[i, j];
            //            maxindexX = i;
            //            maxindexY = j;
            //        }
            //        if (array[i, j] < min)
            //        {
            //            min = array[i, j];
            //            minindexX = i;
            //            minindexY = j;
            //        }
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Max - " + max);
            //Console.WriteLine("Min - " + min);

            //int sum_between_max_and_min = 0;
            //for (int i = maxindexX; i <= minindexX; i++)
            //{
            //    for (int j = minindexY; j <= minindexX; j++)
            //    {
            //        sum_between_max_and_min += array[i, j];
            //    }
            //}
            //Console.WriteLine("Sum between " + min + " index element and " + max + " index element is - " + sum_between_max_and_min );
            #endregion
            #region #3 Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря.
            //int encryption = 0, key = 3;
            //string encryptedText = "", decryptedText = "";
            //Console.WriteLine("Write the word to be encrypted: ");
            //string text = Console.ReadLine();

            //for (int i = 0; i < text.Length; i++)
            //{
            //    int txtUser = (int)text[i];
            //    encryption = txtUser + key;
            //    encryptedText += Char.ConvertFromUtf32(encryption);
            //}

            //Console.WriteLine("Encrypted text: ");
            //Console.WriteLine(encryptedText);

            //for (int i = 0; i < text.Length; i++)
            //{
            //    int txtUser = (int)encryptedText[i];
            //    encryption = txtUser - key;
            //    decryptedText += Char.ConvertFromUtf32(encryption);
            //}
            //Console.WriteLine("Decrypted text: ");
            //Console.WriteLine(decryptedText);

            #endregion
            #region #4 Создайте приложение, которое производит операции над матрица

            //int[] ar = new int[10];
            //int figure = 0;
            //int sum = 0;
            //int mult = 1;
            //Random rnd = new Random();
            //Console.WriteLine("Array: ");
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    ar[i] = rnd.Next(1, 20);
            //    Console.Write("{0,4}", ar[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("\b1- Add figure\n2- Sum\n3- Multiplication");
            //int answer = Convert.ToInt32(Console.ReadLine());
            //if (answer < 0 || answer > 3) return;

            //if(answer == 1)
            //{
            //    Console.WriteLine("Enter a figure: ");
            //    figure = Convert.ToInt32(Console.ReadLine());
            //}


            //switch (answer) {
            //    case 1:
            //        for (int i = 0; i < ar.Length; i++)
            //        {
            //            ar[i] += figure;
            //        }
            //        break;
            //    case 2:
            //        for (int i = 0; i < ar.Length; i++)
            //        {
            //           sum += ar[i];
            //        }
            //        break;
            //    case 3:
            //        for (int i = 0; i < ar.Length; i++)
            //        {
            //            mult *= ar[i];
            //        }
            //        break;
            //}
            //Console.WriteLine();
            //if (answer == 1) {
            //    Console.WriteLine("New Array: ");
            //    for (int i = 0; i < ar.Length; i++)
            //    {
            //        Console.Write("{0,4}", ar[i]);
            //    }
            //}
            //else if(answer == 2)
            //{
            //    Console.WriteLine("Sum - " + sum);
            //}
            //else if(answer == 3)
            //{
            //    Console.WriteLine("Mult - " + mult);
            //}


            //Console.WriteLine();
            #endregion
            #region #5 Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать  его результат.
            ////5 + 2 // 200 - 100
            //String expression = Console.ReadLine();
            //string[] temp = expression.Split();
            //int result = 0;
            //if (expression.IndexOf('-') != -1)
            //{
            //    result = int.Parse(temp[0]) - int.Parse(temp[2]);
            //}
            //else if(expression.IndexOf("+") != -1)
            //{
            //    result = int.Parse(temp[0]) + int.Parse(temp[2]);
            //}

            //Console.WriteLine(expression + " = " + result);
            //Console.ReadLine();
            #endregion
            #region #6 Пользователь с клавиатуры вводит некоторый текст. Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре.
            //String str = Console.ReadLine();
            //Char[] arr = str.ToCharArray();
            //bool isNewSentence = false;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (arr[i] == '.' || i == 0)
            //    {
            //        isNewSentence = true;
            //    }
            //    if ((int)arr[i] > 97 && (int)arr[i] < 122 && isNewSentence == true) { 
            //        isNewSentence= false;
            //        arr[i] = (char)(arr[i] - 32);
            //    }
            //}
            //Console.WriteLine(arr);
            #endregion
            #region #7 Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно должно быть заменено на набор символов *
            //Console.WriteLine("Enter your text: ");
            //String str = Console.ReadLine();
            //Char[] arr = str.ToCharArray();
            //Console.WriteLine("Enter ban word: ");
            //String ban = Console.ReadLine();

            //int count   = 0;
            //int changed = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
               
            //    for (int j = 0; j < ban.Length; j++)
            //    {
            //        if (count == ban.Length)
            //        {
            //            for (int k = 0; k < ban.Length; k++)
            //            {
            //                arr[i - 1 + k] = '*';
            //            }
            //            i += count;
            //            count = 0;
            //            changed++;

            //        }
            //        if (arr.Length > i + j)
            //        {
            //            if (arr[i + j] == ban[j])
            //            {
            //                count++;
            //            }
            //            else
            //            {
            //                count = 0;
            //            }
            //        }
                    
            //    }
                
            //}

            //Console.WriteLine("Ban word - " + ban);
            //Console.WriteLine("Result: ");
            //Console.WriteLine(arr);
            //Console.WriteLine("Statistic - " + changed + " words were changed");
            #endregion

        }
    }
}
