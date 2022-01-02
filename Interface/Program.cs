using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стартово значения");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг прогрессии");
            int step = Convert.ToInt32(Console.ReadLine());
            AProgress aprog = new AProgress();
            GProgress gprog = new GProgress();
            aprog.setStart(start);
            aprog.setStep(step);
            Console.WriteLine("Результаты арифметической прогрессии");
            Console.WriteLine(aprog.getNext());
            Console.WriteLine(aprog.getNext());
            Console.WriteLine(aprog.getNext());
            Console.WriteLine(aprog.getNext());
            aprog.reset();
            Console.WriteLine(aprog.getNext());
            Console.WriteLine(aprog.getNext());
            Console.WriteLine(aprog.getNext());
            gprog.setStart(start);
            gprog.setStep(step);
            Console.WriteLine("Результаты геометрической прогрессии");
            Console.WriteLine(gprog.getNext());
            Console.WriteLine(gprog.getNext());
            Console.WriteLine(gprog.getNext());
            Console.WriteLine(gprog.getNext());
            gprog.reset();
            Console.WriteLine(gprog.getNext());
            Console.WriteLine(gprog.getNext());
            Console.WriteLine(gprog.getNext());
            Console.ReadKey();
        }
    }
}
