using System;

namespace Domain
{
    public class Cat
    {
        public enum CatColor
        {
            Зелёный,
            Жёлтый,
            Красный
        }

        private int _age;

        private CatColor _color;

        private int _health = 8;
        private string _name;

        public string Name
        {
            get => _name;

            set
            {
                if (string.IsNullOrWhiteSpace(_name))
                    _name = value;
                else
                    Console.WriteLine("Вы уже дали имя питомцу :(");
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                try
                {
                    while (value < 1 || value > 20)
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректный возвраст, попробуйте ещё раз...\n");
                        value = int.Parse(Console.ReadLine());
                    }
                    _age = value;
                }
                catch
                {
                    throw new ArgumentException();
                }
            }
        }

        public CatColor Color
        {
            get
            {
                if (_health > 1 && _health <= 3)
                    _color = CatColor.Красный;
                if (_health > 3 && _health < 7)
                    _color = CatColor.Жёлтый;
                if (_health >= 7 && _health <= 10)
                    _color = CatColor.Зелёный;
                return _color;
            }
        }

        public void Feed()
        {
            if (_health <= 10)
            {
                _health += 1;
                Console.WriteLine("Котейка поел и доволен\n" +
                                  "Здоровье увеличено на 1");
            }
            else
            {
                Console.WriteLine("Котейка сыт и здоров, незачем его кормить");
            }
        }

        public void Punish()
        {
            if (_health > 1)
            {
                Console.WriteLine("Аккуратнее, котейка шипит и кусается\n" +
                                  "Здоровье уменьшено на 1");
                _health -= 1;
            }
            else
            {
                Console.WriteLine("Незачем его убивать :(");
            }
        }
    }
}