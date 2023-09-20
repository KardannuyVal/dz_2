using System;
namespace Задание1
{

    class МирТрудМай
   {
       
      static void Main(string[] args)
      {              
        Console.WriteLine("Второе задание:");
        Console.Write("Введите ваше имя:");
        string? z=Console.ReadLine();
        Console.WriteLine($"Здраствуйте,{z}");
        Console.WriteLine("Второе задание:");
        Console.WriteLine("Поделим два числа");
        Console.Write("Введите первое целое число:");
        int a=Convert.ToInt32(Console.ReadLine());     
        Console.Write("Введите второе целое число(кроме нуля):");        
        int b=Convert.ToInt32(Console.ReadLine());
        if (b==0)
        {
          Console.WriteLine("Делить на ноль нельзя");
        }
        else
        {
          float c=(float)a/b;
          Console.WriteLine($"Результат деления:{c}");
        }  
        Console.WriteLine("Третье задание задание:");
        Console.Write("Введите букву:");
        char input = Console.ReadKey().KeyChar;
        char letter = char.ToLower(input);
        char    nextletter ;
          if (letter == 'z')
            nextletter = 'a';
          else
            nextletter = (char)(((int)letter) + 1);
        Console.WriteLine();
        Console.WriteLine($"Следующая по алфавиту буква:{nextletter}");
        Console.Write("Задание 5:");
        Console.WriteLine("Решим квадратное уравнеие вида: ax^2+bx+c=0");
        Console.Write("Введите значение a:");
        int q= Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение b:");
        int w= Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение c:");
        int e= Convert.ToInt32(Console.ReadLine());
        Console.Write("Найдем корни:"); 
      
         double D= (w*w)-(4*q*e);
         if (D <0)
              {
               Console.WriteLine("Корней нет");
              }
         else if (D == 0) 
              {
                double x= -w/2*q;
                Console.Write($"x={x}");
              }  
          else      
           {
       double x1 = (-w + Math.Sqrt(D)) / (2 * q);
       double x2 = (-w - Math.Sqrt(D)) / (2 * q);
           
       Console.WriteLine($" x1={x1}, x2={x2}");
           }

        
        

          
      }

       
    }
}