
using static System.Net.Mime.MediaTypeNames;

namespace Task1
{
    class Program
    {

        static char[] validOperations = { '+', '-', '*', '/' };
        static double ReadDouble(string require)
        {
            while (true)
            {
                Console.Write(require);
                string input = Console.ReadLine();

                if (double.TryParse(input, out double num))
                {
                    return num;
                }

                Console.WriteLine("Некорректный ввод! Пожалуйста, введите число! ");
            }

        }

        static char ReadOpr(string require)
        {
            while (true)
            {
                Console.Write(require);
                string input = Console.ReadLine();


                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ввод не может быть пустым! Попробуйте снова.");
                    continue;
                }

                char op = input[0];
                if (validOperations.Contains(op))
                {
                    return op;
                }

                Console.WriteLine("Недопустимая операция! Используйте +, -, * или /.");
            }
        }

        static bool ShouldContinue()
        {
            while (true)
            {
                Console.WriteLine("Продолжить? (Y/N)");

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Пожалуйста, введите Y или N! ");
                    continue;
                }

                char next = char.ToUpper(input[0]);
                if (next == 'Y')
                {
                    return true;
                }

                else
                {
                    return false;
                }

                Console.WriteLine("Некорректный ввод! Введите Y для продолжения или N для выхода.");
            }
        }

        static void Main()
        {
            char next;

            do
            {
                Console.Clear();
                Console.WriteLine("Калькулятор");

                double num1 = ReadDouble("Введите первое число: ");

                char operation = ReadOpr("Выберите операцию (+, -, *, /): ");

                double num2 = ReadDouble("Введите второе число: ");


                switch (operation)
                {
                    case '+':
                        Console.WriteLine($"Ответ: {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"Ответ: {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"Ответ: {num1 * num2}");
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Ответ: {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль!");
                        }
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция!");
                        break;

                }

            } while (ShouldContinue());

            Console.WriteLine("Выход...");
        }
    }
}



