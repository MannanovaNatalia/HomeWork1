using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CatModel;
using CatView;
namespace ZooMagazine
{
    class Program
    {

        static void Main(string[] args)
        {
            string age = String.Empty;
            while (string.IsNullOrEmpty(age))
            {
                Console.WriteLine("Пожалуйста укажите возраст кошки:");
                age = Console.ReadLine();
            }
            
            var CatV = new CatV(age);

            var menuEnter = true;

            while (menuEnter)
            {
                //Console.Clear();
                if (string.IsNullOrEmpty(CatV.Cat.Name))
                {
                    Console.WriteLine(string.Format(@"
Имя кошки: {0} / Текущий цвет: {1} / Возраст: {2} 
Введите номер пункта меню и нажмите Enter:
1 - Задать имя;
2 - Задать цвет;
3 - Ударить;
4 - Покормить;
5 - Выход. 
", (string.IsNullOrEmpty(CatV.Cat.Name)) ? "[Значение не задано]" : CatV.Cat.Name, CatV.Cat.CurrentColor, CatV.Cat.Age));
                }
                else
                {
                    Console.WriteLine(string.Format(@"
Имя кошки: {0} / Текущий цвет: {1} / Возраст: {2} 
Введите номер пункта меню и нажмите Enter:
2 - Задать цвет;
3 - Ударить;
4 - Покормить;
5 - Выход. 
", (string.IsNullOrEmpty(CatV.Cat.Name)) ? "[Значение не задано]" : CatV.Cat.Name, CatV.Cat.CurrentColor, CatV.Cat.Age));
                }
                
                var choosedMenu = Console.ReadLine();
                while (string.IsNullOrEmpty(choosedMenu))
                {
                    Console.WriteLine("Выберите пункт меню!!!!!");
                    choosedMenu = Console.ReadLine();
                }

                switch (choosedMenu)
                {
                    case "1":
                        {
                            if (string.IsNullOrEmpty(CatV.Cat.Name))
                            {
                                Console.WriteLine("Введите имя кошки:");
                                string name = Console.ReadLine();
                                while (string.IsNullOrEmpty(name))
                                {
                                    Console.WriteLine("Введите не пустое имя кошки:");
                                    name = Console.ReadLine();
                                }
                                CatV.Cat.Name = name;
                            }
                            else
                            {
                                Console.WriteLine("Имя уже задано");
                            }
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("Введите цвет здоровой кошки (пусто, если не менять): ");
                            string heathyColor = Console.ReadLine();
                            Console.WriteLine("Введите цвет для больной кошки (пусто, если не менять): ");
                            string sickColor = Console.ReadLine();
                            CatV.ChangeColor(heathyColor,sickColor);
                           
                        }
                        break;

                    case "3":
                        {
                            CatV.Cat.Punish();
                            Console.WriteLine("Животное наказано!=(");
                        }
                        break;

                    case "4":
                        {
                            CatV.Cat.Feed();
                            Console.WriteLine("Животное накормлено");
                        }
                        break;

                    case "5":
                    {
                       return;
                    }
                        break;
                }

            }

            Console.ReadLine();


        }



    }
}
