/*
 * Создано в SharpDevelop.
 * Пользователь: Артём
 * Дата: 27.09.2018
 * Время: 18:20
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace lab1nom4
{
	class Program
    {
        
     public static bool IsPrime(int x)
    {
       // for (int i=2; i<=x/i;i++)-Lexeq ,Ваш вариант.
         for (int i = 2; i < x; i++)
             if ((x % i) == 0) return false;
             if (x <= 1) return false;//добавлено
       
         return true;
    }
 
        static void Main()
        {
        	Console.WriteLine("Введите число");
        	
            int n = 0;
            int m = Convert.ToInt32(Console.ReadLine());
      for (int i = n; i < m; i++)
      if (IsPrime(i))
      Console.WriteLine(i);
      Console.ReadKey();
 
       }    
     }
}