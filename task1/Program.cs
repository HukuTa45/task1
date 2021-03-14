using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вводим исходные данные
            Console.WriteLine(" Введите Имя");
            string name = Console.ReadLine();
            Console.WriteLine(" Введите возраст");
            string age = Console.ReadLine();

            //Проверяем значение возраста (число да/нет)
            while (double.TryParse(age, out double numericAge) == false)
            {
                Console.WriteLine(" Введите число!");
                age = Console.ReadLine();
            }

            Console.WriteLine(" Введите число от 3 до 9");
            string number = Console.ReadLine();

            //Проверяем на корректность введенное значение           
            while (double.TryParse(number, out double numberInt) == false)
            {

                Console.WriteLine(" Некорректные данные! Введите число от 3 до 9!");
                number = Console.ReadLine();
            }
            while (double.Parse(number) < 3 || double.Parse(number) > 9)
            {

                Console.WriteLine(" Введите число от 3 до 9!");
                number = Console.ReadLine();
            }

            //Проверяем возраст на чётность
            string ageParity = parity(double.Parse(age));


            //Проверяем деление квадрата на введеное число
            string divisibility = divisibilityOfaNumber(double.Parse(age), double.Parse(number));

            Console.WriteLine(" " + name + ", я проанализировала введённые тобой данные и могу заявить:\n     1) Твой возраст — это " + ageParity +
                "\n     2) Квадратный корень, полученный из твоего возраста " + divisibility + " на " + number);



            // функция для проверки чётности
             string parity(double number)
            {
                if (number % 2 == 0)
                {
                    return "чётное число";
                }
                else
                {
                    return "нечётное число";
                }
            }

            //функция проверки деления квадрата возраста на число
            string divisibilityOfaNumber(double age, double number)
            {
                double sqrAge = Math.Pow(age, 2);
                if (sqrAge % number == 0)
                {
                    return "делится";
                }
                else
                {
                    return "не делится";
                }
            }


        }
        
    }
}
