using System;
using System.Threading;
using Domain;

namespace ZooShop
{
    public class ZooMenu
    {
        public Cat.CatColor PCatColor;
        public string PurchasedCatName;
        public string PurchsedCatAge;

        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine(
                "1.Показать информацию о питомце.\n" +
                "2.Дать котейке имя.\n" +
                "|------------------------|\n" +
                "3.Покормить котейку.\n" +
                "4.Наказать котейку.\n" +
                "5.Узнать состояние котейки.\n" +
                "|------------------------|\n" +
                "0.Выйти.\n\n\n" +
                "Информация о вашем питомце\n" +
                "Имя: " + PurchasedCatName +
                "\nВозраст: " + PurchsedCatAge +
                "\nЦвет питомца: " + PCatColor);
        }

        public string StartPage()
        {
            Console.WriteLine("Спасибо за приобретение котейки програмиста\n" +
                              "\n" +
                              "\n" +
                              "Укажите возраст вашего питомца: ");
            PurchsedCatAge = Console.ReadLine();
            return PurchsedCatAge;
        }

        public void InfoShow()
        {
            Console.Clear();
            Console.WriteLine(
                "Информация о вашем питомце\n" +
                "Имя: " + PurchasedCatName +
                "\nВозраст: " + PurchsedCatAge +
                "\nЦвет питомца: " + PCatColor +
                "\n\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var ZMenu = new ZooMenu();
            var PurchasedCat = new Cat();

            PurchasedCat.Age = int.Parse(ZMenu.StartPage());

            string a;
            do
            {
                ZMenu.DisplayMenu();
                Console.WriteLine("\nДля выбора пункта меню нажмите соответствующую клавишу...");
                a = Console.ReadLine();

                switch (a)
                {
                    case "1":
                        ZMenu.InfoShow();
                        break;
                    case "2":
                        Console.WriteLine(
                            "Вы хотите дать своему питомцу имя!\n\t Помните, его нельзя будет изменить: ");
                        PurchasedCat.Name = Console.ReadLine();
                        ZMenu.PurchasedCatName = PurchasedCat.Name;
                        Thread.Sleep(2800);
                        break;
                    case "3":
                        PurchasedCat.Feed();
                        ZMenu.PCatColor = PurchasedCat.Color;
                        Thread.Sleep(1200);
                        break;
                    case "4":
                        PurchasedCat.Punish();
                        ZMenu.PCatColor = PurchasedCat.Color;
                        Thread.Sleep(1200);
                        break;
                    case "5":
                        Console.WriteLine("Котейка выглядит {0}", ZMenu.PCatColor);
                        Thread.Sleep(1200);
                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        ZMenu.DisplayMenu();
                        break;
                }
            } while (a != "0");
        }
    }
}