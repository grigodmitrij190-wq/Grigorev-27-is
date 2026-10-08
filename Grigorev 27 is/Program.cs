using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grigorev_27_is
{
    internal class Program
    {
          public static void Main()
    {
        Computer comp = new Computer();
        comp.Number = 123345;   // задаем значение для свойства Number
        comp.Freq = 1.5;        // задаем значение для свойства Freq
        comp.Memory = 400;      // задаем значение для свойства Memory

        comp.Show();
        double s = comp.Cost(100);
        Console.WriteLine($"Стоимость внешней памяти = {s}.");
        Console.ReadKey();
    }
}

class Computer
{
    // поля
    private int number;
    private double freq;
    private double memory;

    // свойства – доступ к полям класса
    public int Number
    {
        get { return number; }
        set { if (value > 0) number = value; }
    }

    public double Freq
    {
        get { return freq; }
        set { if (value > 0) freq = value; }
    }

    public double Memory
    {
        get { return memory; }
        set { if (value > 0) memory = value; }
    }

    // конструкторы
    public Computer() // конструктор без параметров
    {
        Number = 0;
        Freq = 0;
        Memory = 0;
    }

    public Computer(int n, double f, double m)
    {
        Number = n;
        Freq = f;
        Memory = m;
    }

    // вычислительные методы
    public double Cost(double price) // расчет стоимости внешней памяти
    {
        double st = memory * price;
        return st;
    }

    public void Show() // показать данные о компьютере
    {
        Console.WriteLine($"Компьютер: номер = {Number}, частота = {Freq} ГГц, память = {Memory} ГБ");
        return;
    }
}
}
