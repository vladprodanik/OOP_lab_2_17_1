using System;

namespace OOP_lab_2_17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTheRoute = int.Parse(Console.ReadLine());
            
            switch(numberOfTheRoute)
            {
                case 1:
                    Console.WriteLine("Трамвай №{0}: Залiзничний Вокзал — вул. Пасiчна", numberOfTheRoute);
                    break;

                case 2:
                    Console.WriteLine("Трамвай №{0}: (вул. Пасiчна — пл. Коновальця", numberOfTheRoute);
                    break;

                case 3:
                    Console.WriteLine("Трамвай №{0}: пл. Соборна — Аквапарк", numberOfTheRoute);
                    break;

                case 4:
                    Console.WriteLine("Трамвай №{0}: Залiзничний вокзал — вул. Вернадського", numberOfTheRoute);
                    break;

                case 5:
                    Console.WriteLine("Трамвай №{0}: Тимчасово не працює", numberOfTheRoute);
                    break;

                case 6:
                    Console.WriteLine("Трамвай №{0}: вул. Миколайчука — ТЦ «Скриня»", numberOfTheRoute);
                    break;

                case 7:
                    Console.WriteLine("Трамвай №{0}: Погулянка — вул. Татарбунарська", numberOfTheRoute);
                    break;

                case 8:
                    Console.WriteLine("Трамвай №{0}: Соборна — вул. Вернадського", numberOfTheRoute);
                    break;

                case 9:
                    Console.WriteLine("Трамвай №{0}: Залiзничний вокзал — вул. Миколайчука", numberOfTheRoute);
                    break;
            }
        }
    }
}
