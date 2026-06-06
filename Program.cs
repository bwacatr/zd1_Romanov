using System;
using System.Collections.Generic;
namespace zd1_Romanov
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Cat> cats = new List<Cat>();
                
                int amount = 0;
                do
                {
                    Console.WriteLine("Введите кол-во котов:");
                    amount = int.Parse(Console.ReadLine());
                } 
                while (amount <= 0);



                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine("Введите имя кота");
                    string CatName = Console.ReadLine();
                    
                    double weight = 0;
                    do
                    {
                        Console.WriteLine($"Введите вес кота {CatName}");
                        weight = double.Parse(Console.ReadLine());
                    }
                    while (amount <= 0);

                    Cat cat = new Cat(CatName,weight);
                    cats.Add(cat);
                }

                foreach (var item in cats)
                {
                    Console.WriteLine(item.Info());
                    Console.WriteLine();
                }
                Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                Console.ReadKey();
                
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный тип данных");
                Console.ReadKey();

            }
            
        }
    }
}
