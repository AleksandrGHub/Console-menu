namespace Console_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ComandShowTime = "1";
            const string ComandShowDayWeek = "2";
            const string ComandShowRandomNumber = "3";
            const string ComandClearConsole = "4";
            const string ComandExit = "5";

            Random random = new Random();
            bool isEnabled = true;
            string userInput;

            ShowMenu();

            while (isEnabled)
            {
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case ComandShowTime:
                        Console.WriteLine("Время 21:05");
                        break;

                    case ComandShowDayWeek:
                        Console.WriteLine("День недели понедельник");
                        break;

                    case ComandShowRandomNumber:

                        Console.WriteLine("Случайное число: " + random.Next());
                        break;

                    case ComandClearConsole:
                        Console.Clear();
                        ShowMenu();
                        break;

                    case ComandExit:
                        isEnabled = false;
                        Console.WriteLine("Программа остановлена!");
                        break;
                }
            }

            void ShowMenu()
            {
                Console.WriteLine("--------Команды меню--------");
                Console.WriteLine($"{ComandShowTime} Показать время");
                Console.WriteLine($"{ComandShowDayWeek} Показать день недели");
                Console.WriteLine($"{ComandShowRandomNumber} Показать произвольное число");
                Console.WriteLine($"{ComandClearConsole} Очистить консоль");
                Console.WriteLine($"{ComandExit} Выход");
            }
        }
    }
}