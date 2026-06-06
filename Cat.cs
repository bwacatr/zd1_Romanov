using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1_Romanov
{
    class Cat
    {
        private string name;
        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine("Вес должен быть положительным");
                }
            }
        }

        public string Info()
        {
            return $"Имя кота: {name}\n" +
                $"Вес кота: {weight}";   
        }

        

        public Cat(string name, double weight) // конструктор с установкой имени
        {
            this.SetCatName(name);
            Weight = weight;
        }

        public string Name // свойство имени
        {
            get { return name; }
            set { SetCatName(value); }
        }

        public void Meow() // голос кота
        {
            Console.WriteLine($"{name}:Маяууу!!!!") ;
        }

        private void SetCatName(string Name) // установка имени кота
        {
            bool onlyLetters = true;

            foreach (var item in Name)
            {
                if (!char.IsLetter(item))
                {
                    onlyLetters = false;
                }


            }

            if (onlyLetters)
            {
                name = Name;
            }
            else
            {
                Console.WriteLine($"{Name} - неправильное имя");
            }
        }
    }
}
