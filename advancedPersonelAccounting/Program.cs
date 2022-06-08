class program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> dossiers = new Dictionary<int, string>();
        bool isExit = false;

        while (isExit == false)
        {
            Console.WriteLine("1. Добавить досье.\n" +
                "2. Вывести все досье на экран.\n" +
                "3. Удалить досье.\n" +
                "4. Выход.");

            switch (Console.ReadLine())
            {
                case "1":
                    AddDossier(dossiers);
                    break;
                case "2":
                    DisplayDossierOnScreen(dossiers);
                    break;
                case "3":
                    DeleteDossier(dossiers);
                    break;
                case "4":
                    isExit = true;
                    break;
                default:
                    Console.WriteLine("Такой команды нет.");
                    break;
            }
            Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void DeleteDossier(Dictionary<int, string> dossiers)
    {
        if (dossiers.Count == 0)
        {
            Console.WriteLine("Архив пуст! Сначала добавьте досье!");
        }
        else
        {
            DisplayDossierOnScreen(dossiers);

            Console.WriteLine("\nВведите номер досье для удаления:");
            int numberDossier = 0;
            string userInputNumber = Console.ReadLine();
            bool isNumber = int.TryParse(userInputNumber, out numberDossier);
            
            if (isNumber)
            {
                if (dossiers.ContainsKey(numberDossier))
                {
                    dossiers.Remove(numberDossier);
                    Console.WriteLine("Досье удалено!");
                }
                else
                {
                    Console.WriteLine("Такого досье не существует!!!");
                }
            }
            else
            {
                Console.WriteLine("Введеные данные не корректны.");
            }
        }
    }

    static void DisplayDossierOnScreen(Dictionary<int, string> dossiers)
    {
        foreach (var dossier in dossiers)
        {
            Console.Write($"{dossier.Key}){dossier.Value}, ");
        }
    }

    static void AddDossier(Dictionary<int, string> dossiers)
    {
        Console.WriteLine("Введите ФИО:");
        string fullName = Console.ReadLine();

        Console.WriteLine("Введите должность:");
        string job = Console.ReadLine();

        dossiers.Add(dossiers.Count + 1, $" {fullName} - {job}");

        Console.WriteLine("Досье добавлено в базу!");
    }
}