using System;
namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Первое задание:");
        Console.WriteLine($"int:\t {int.MaxValue}-{int.MaxValue}", int.MaxValue, int.MaxValue);
        Console.WriteLine($"uint:\t{uint.MaxValue}-{uint.MinValue}" );
        Console.WriteLine($"short:\t{short.MaxValue}-{short.MinValue}");
        Console.WriteLine($"ushort:\t{ushort.MaxValue} - { ushort.MinValue}");
        Console.WriteLine($"long:\t{long.MaxValue} - { long.MinValue}");
        Console.WriteLine($"ulong:\t{ulong.MaxValue} - { ulong.MinValue}"); 
        Console.WriteLine($"float:\t{float.MaxValue} - {float.MinValue}");
        Console.WriteLine($"double:\t{double.MaxValue} - {double.MinValue}");
        Console.WriteLine($"decimal:\t{ decimal.MaxValue} - { decimal.MinValue}");
        Console.WriteLine($"bool:\t{bool.TrueString} - {bool.FalseString}");
        Console.WriteLine($"char:\t{char.MaxValue} - {char.MinValue}");
        Console.WriteLine($"string:\tAny characters");
        Console.WriteLine("Второе задание:");
        Console.Write("Введите ваше имя:");
        string? name = Console.ReadLine();
        Console.Write("Введите ваш город:");
        string? city = Console.ReadLine();
        Console.Write("Введите ваш возраст:");
        int age= Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите ваш PIN-код:");
        string? PIN_code = Console.ReadLine();
        Console.WriteLine("Информация пользователя:");
        Console.WriteLine("Имя: " + name);
        Console.WriteLine("Город: " + city);
        Console.WriteLine("Возраст: " + age);
        Console.WriteLine("PIN-код: " + PIN_code);
        Console.WriteLine("Третье задание:");
        Console.WriteLine("Введите строку:");
        string? str = Console.ReadLine();
        int length = str.Length;
        Console.WriteLine($"Количество символов:{length}");
        Console.WriteLine("Четвертое задание:");
        Console.WriteLine("Здравствуйте, мой дорогой друг.Как тебя зовут?");
        string? имя=Console.ReadLine();
        Console.WriteLine($"Привет, {имя}.");
        Console.WriteLine("Спроси меня знаю ли я что-то о тайной комнате");
        Console.ReadLine();
        Console.WriteLine("Хочешь расскажу о ней?(да/нет)");
        string? answer=Console.ReadLine();
        if (answer=="да")
         {
            Console.Write("A я не расскажу.");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
             Console.Clear();
         }
        else 
         {
           Console.WriteLine("Жаль, тогда прощай.");  
         } 
         Random kardan= new Random();
        int number_1=kardan.Next(0,9); 
        Console.Write($"Пусть дан штрихкод без контрольной цифры: {number_1}");
        int number_2=kardan.Next(0,9); 
        Console.Write(number_2);
        int number_3=kardan.Next(0,9); 
        Console.Write(number_3);
        int number_4=kardan.Next(0,9); 
        Console.Write(number_4);
        int number_5=kardan.Next(0,9); 
        Console.Write(number_5);
        int number_6=kardan.Next(0,9); 
        Console.Write(number_6);
        int number_7=kardan.Next(0,9); 
        Console.Write(number_7);
        int number_8=kardan.Next(0,9); 
        Console.Write(number_8);
        int number_9=kardan.Next(0,9); 
        Console.Write(number_9);
         int number_10=kardan.Next(0,9); 
        Console.Write(number_10);
         int number_11=kardan.Next(0,9); 
        Console.Write(number_11);
         int number_12=kardan.Next(0,9); 
        Console.WriteLine(number_12);
        int q=(number_2+number_4+number_6+number_8+number_10+number_12)*3;
        int w=10-((number_1+number_3+number_5+number_7+number_9+number_10+number_11+q)%10);
        Console.WriteLine($"Контрольной цифрой штрихкода явлется:{w}");
        Console.Write("Введите 12 случайных цифр:");
        int e=Convert.ToInt16(Console.ReadLine());
        int  e1=Convert.ToInt16(Console.ReadLine());
        int  e2=Convert.ToInt16(Console.ReadLine());
        int  e3=Convert.ToInt16(Console.ReadLine());
        int  e4=Convert.ToInt16(Console.ReadLine());
        int  e5=Convert.ToInt16(Console.ReadLine());
        int e6=Convert.ToInt16(Console.ReadLine());
        int e7=Convert.ToInt16(Console.ReadLine());
        int e8=Convert.ToInt16(Console.ReadLine());
        int e9=Convert.ToInt16(Console.ReadLine());
        int  e10=Convert.ToInt16(Console.ReadLine());
        int  e11=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ваш штрихкод без контрольной цифры:"+e+e1+e2+e3+e4+e5+e6+e7+e8+e9+e10+e11);
        int r=e2+e4+e6+e8+e10;
        int t=10-((e+e3+e5+e7+e9+e11+r)%10);
        Console.WriteLine($"Контрольной цифрой вашего штрихкода явлется:{t}");
        Console.WriteLine("Пятое задание:");
        Console.Write("Введите стоимость бутылки в рублях виски без скидки:");
        int y=Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите скидку на бутылку виски в процентах:");
        int u=Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите стоимость отпуска в рублях:");
        int i=Convert.ToInt32(Console.ReadLine());
        int o=i/((u/100)*y);
        Console.WriteLine($"Вам нужно будет купить {(o)} бутылок виски со скидкой вместо бутылок без скидки,чтобы разница окупила ваш отпуск.");
        



        


        }
    }
}        
