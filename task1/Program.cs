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
            while (double.TryParse(age, out double numericAge) == false || double.Parse(age) <=0) {
                Console.WriteLine(" Введите число, которое больше нуля ");
                age = Console.ReadLine();
            }
            Console.WriteLine(" Введите число от 3 до 9");
            string number = Console.ReadLine();

            //Проверяем на корректность введенное значение           
            while (double.TryParse(number, out double numberInt) == false) { 
                Console.WriteLine(" Некорректные данные! Введите число от 3 до 9!");
                number = Console.ReadLine();
            }
            while (double.Parse(number) < 3 || double.Parse(number) > 9) {
                Console.WriteLine(" Введите число от 3 до 9!");
                number = Console.ReadLine();
            }

            //Проверяем возраст на чётность
            string ageParity = Parity(double.Parse(age));

            //Проверяем деление квадрата на введеное число
            string divisibility = divisibilityOfaNumber(double.Parse(age), double.Parse(number));
            Console.WriteLine(" " + name + ", я проанализировала введённые тобой данные и могу заявить:" +
                "\n     1) Твой возраст — это " + ageParity +
                "\n     2) Квадратный корень, полученный из твоего возраста "+ divisibility + " на " + number);

        }

            // функция для проверки чётности
         static string Parity(double number) {            
                if (number % 2 == 0){ 
                    return "чётное число";
                }
                else{
                    return "нечётное число";
                }
        }

            //функция проверки деления квадрата возраста на число
        static string divisibilityOfaNumber(double age, double number) {
            double sqrtAge = Math.Ceiling(Math.Sqrt(age));           
                if (sqrtAge % number == 0) {
                    return "делится";
                }
                else{
                    return "не делится";
                }
            }

    }
        
}

