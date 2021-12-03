using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19._1
{
    internal class Program
    {
        public static void Main()
        {
            List<Computer> listComp = new List<Computer>()
            {
                new Computer() { Id=1, Name="Lenovo", CPU="AMD", Frequency=3400, RAM=8, HardDisk=1000, VideoMemory=2, Price=650.5, Count=24},
                new Computer() { Id=2, Name="ASUS", CPU="INTEL", Frequency=3600, RAM=16, HardDisk=240, VideoMemory=4, Price=880.9, Count=15},
                new Computer() { Id=3, Name="HP", CPU="AMD", Frequency=3800, RAM=12, HardDisk=480, VideoMemory=2, Price=740.3, Count=49},
                new Computer() { Id=4, Name="Dell", CPU="AMD", Frequency=3200, RAM=8, HardDisk=1000, VideoMemory=4, Price=470.5, Count=106},
                new Computer() { Id=5, Name="Apple", CPU="INTEL", Frequency=2800, RAM=8, HardDisk=960, VideoMemory=4, Price=950.7, Count=85},
                new Computer() { Id=6, Name="Acer", CPU="AMD", Frequency=3300, RAM=4, HardDisk=240, VideoMemory=2, Price=620.5, Count=67},
                new Computer() { Id=7, Name="MSI", CPU="INTEL", Frequency=3500, RAM=16, HardDisk=960, VideoMemory=6, Price=1200.3, Count=93},
                new Computer() { Id=8, Name="Gigabyte", CPU="AMD", Frequency=3100, RAM=12, HardDisk=500, VideoMemory=6, Price=550.2, Count=12},
                new Computer() { Id=9, Name="Prestigio", CPU="INTEL", Frequency=3450, RAM=4, HardDisk=1000, VideoMemory=2, Price=480.5, Count=27},
                new Computer() { Id=10, Name="Huawei", CPU="AMD", Frequency=3350, RAM=8, HardDisk=500, VideoMemory=4, Price=560.5, Count=102}
            };
            Console.WriteLine("Выберете необходимое действие");
            Console.WriteLine();
            Console.WriteLine("     1. Определить все компьютеры с указанным процессором (AMD или INTEL)");
            Console.WriteLine("     2. Определить все компьютеры с объемом ОЗУ (от 4 до 16 ГБ)");
            Console.WriteLine("     3. Вывести весь список в порядке увеличения стоимости");
            Console.WriteLine("     4. Вывести весь список сгруппированный по типу процессора");
            Console.WriteLine("     5. Определить самый дорогой и самый бюджетный компьютер");
            Console.WriteLine("     6. Вывести список компьютеров не менее 30 штук в наличии");
            Console.WriteLine();
        Start:
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                Start1:
                    Console.WriteLine();
                    Console.Write("Введите интересующий тип процессора: ");
                    string cpu = (Console.ReadLine()).ToUpper();
                    Console.WriteLine();
                    if (cpu == "AMD")
                    {
                        List<Computer> list1 = (from a in listComp
                                                where a.CPU == "AMD"
                                                select a).ToList();
                        foreach (Computer a in list1)
                            Console.WriteLine($" #: {a.Id}, Производитель: {a.Name}, Тип: {a.CPU}, " +
                                $" Частота: {a.Frequency} МГц, Объем ОЗУ: {a.RAM} ГБ, Объем жесткого диска: {a.HardDisk} ГБ, " +
                                $"Видеопамять: {a.VideoMemory} ГБ, Стоимость: {a.Price} $, Количество: {a.Count} шт");
                    }
                    if (cpu == "INTEL")
                    {
                        List<Computer> list1 = listComp.Where(a => a.CPU == "INTEL").ToList();

                        foreach (Computer a in list1)
                            Console.WriteLine($" #: {a.Id}, Производитель: {a.Name}, Тип: {a.CPU}, " +
                                $" Частота: {a.Frequency} МГц, Объем ОЗУ: {a.RAM} ГБ, Объем жесткого диска: {a.HardDisk} ГБ, " +
                                $"Видеопамять: {a.VideoMemory} ГБ, Стоимость: {a.Price} $, Количество: {a.Count} шт");
                    }
                    else if (cpu != "AMD" & cpu != "INTEL")
                    {
                        Console.WriteLine("Такого параметра не существует!");
                        Console.WriteLine();
                        goto Start1;
                    }
                    //Console.ReadKey();
                    Menu.ReturnMenu();
                    break;

                case "2":
                Start2:
                    try
                    {
                        Console.WriteLine();
                        Console.Write("Введите интересующий минимальный объем ОЗУ (от 4 до 16 ГБ): ");
                        int ram = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();


                        if (ram >= 4 & ram <= 16)
                        {
                            List<Computer> list2 = listComp.Where(a => a.RAM >= ram).ToList();

                            foreach (Computer a in list2)
                                Console.WriteLine($" #: {a.Id}, Производитель: {a.Name}, Тип: {a.CPU}, " +
                                    $" Частота: {a.Frequency} МГц, Объем ОЗУ: {a.RAM} ГБ, Объем жесткого диска: {a.HardDisk} ГБ, " +
                                    $"Видеопамять: {a.VideoMemory} ГБ, Стоимость: {a.Price} $, Количество: {a.Count} шт");
                        }
                        else
                        {
                            Console.WriteLine("Такого параметра не существует!");
                            Console.WriteLine();
                            goto Start2;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Такого параметра не существует!");
                        Console.WriteLine();
                        goto Start2;
                    }
                    //Console.ReadKey();
                    Menu.ReturnMenu();
                    break;

                case "3":
                    Console.WriteLine();
                    foreach (Computer a in listComp.OrderBy(a => a.Price))
                        Console.WriteLine($" #: {a.Id}, Производитель: {a.Name}, Тип: {a.CPU}, " +
                            $" Частота: {a.Frequency} МГц, Объем ОЗУ: {a.RAM} ГБ, Объем жесткого диска: {a.HardDisk} ГБ, " +
                            $"Видеопамять: {a.VideoMemory} ГБ, Стоимость: {a.Price} $, Количество: {a.Count} шт");

                    //Console.ReadKey();
                    Menu.ReturnMenu();
                    break;

                case "4":

                    var groups = listComp.GroupBy(a => a.CPU);
                    foreach (var group in groups)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Процессоры " + group.Key);

                        foreach (var a in group)
                        {
                            Console.WriteLine($" #: {a.Id}, Производитель: {a.Name}, Тип: {a.CPU}, " +
                            $" Частота: {a.Frequency} МГц, Объем ОЗУ: {a.RAM} ГБ, Объем жесткого диска: {a.HardDisk} ГБ, " +
                            $"Видеопамять: {a.VideoMemory} ГБ, Стоимость: {a.Price} $, Количество: {a.Count} шт");
                        }
                    }
                    //Console.ReadKey();
                    Menu.ReturnMenu();
                    break;

                case "5":

                    double MinValue = listComp.Min(a => a.Price);
                    double MaxValue = listComp.Max(a => a.Price);
                    Console.WriteLine();
                    Console.WriteLine("Стоимость самого бюджетного компьютера: {0} $", MinValue);
                    foreach (Computer a in listComp.Where(a => a.Price == MinValue))
                        Console.WriteLine($" #: {a.Id}, Производитель: {a.Name}, Тип: {a.CPU}, " +
                            $" Частота: {a.Frequency} МГц, Объем ОЗУ: {a.RAM} ГБ, Объем жесткого диска: {a.HardDisk} ГБ, " +
                            $"Видеопамять: {a.VideoMemory} ГБ, Стоимость: {a.Price} $, Количество: {a.Count} шт");
                    Console.WriteLine();
                    Console.WriteLine("Стоимость самого дорогого компьютера: {0} $", MaxValue);
                    foreach (Computer a in listComp.Where(a => a.Price == MaxValue))
                        Console.WriteLine($" #: {a.Id}, Производитель: {a.Name}, Тип: {a.CPU}, " +
                            $" Частота: {a.Frequency} МГц, Объем ОЗУ: {a.RAM} ГБ, Объем жесткого диска: {a.HardDisk} ГБ, " +
                            $"Видеопамять: {a.VideoMemory} ГБ, Стоимость: {a.Price} $, Количество: {a.Count} шт");

                    //Console.ReadKey();
                    Menu.ReturnMenu();
                    break;

                case "6":
                    Console.WriteLine();
                    foreach (Computer a in listComp.Where(a => a.Count >= 30))
                        Console.WriteLine($" #: {a.Id}, Производитель: {a.Name}, Тип: {a.CPU}, " +
                            $" Частота: {a.Frequency} МГц, Объем ОЗУ: {a.RAM} ГБ, Объем жесткого диска: {a.HardDisk} ГБ, " +
                            $"Видеопамять: {a.VideoMemory} ГБ, Стоимость: {a.Price} $, Количество: {a.Count} шт");

                    //Console.ReadKey();
                    Menu.ReturnMenu();
                    break;

                default:

                    Console.WriteLine("Такого параметра не существует!");
                    Console.WriteLine();
                    goto Start;
            }
        }
    }

    class Computer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPU { get; set; }
        public int Frequency { get; set; }
        public int RAM { get; set; }
        public int HardDisk { get; set; }
        public int VideoMemory { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

    }
    class Menu
    {
        public static void ReturnMenu()
        {
            Console.WriteLine();
            Console.WriteLine("     1. Для возврата к главному меню");
            Console.WriteLine("     2. Для выхода из программы");
            Console.WriteLine();
        Start3:
            Console.Write("Ваш выбор: ");
            string choice1 = Console.ReadLine();
            switch (choice1)
            {
                case "1":
                    Console.WriteLine();
                    Program.Main();
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Для завершения нажмите любую клавишу");
                    break;
                default:
                    Console.WriteLine("Такого параметра не существует!");
                    Console.WriteLine();
                    goto Start3;
            }
        }
    }
}
