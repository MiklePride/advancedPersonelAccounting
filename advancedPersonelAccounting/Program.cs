class program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> dossiers = new Dictionary<string, string>();
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
                    DeliteDossier(dossiers);
                    break;
                case "4":
                    isExit = true;
                    break;
                default:
                    Console.WriteLine("Такой команды нет.");
                    break;
            }
        }
    }

    static void DeliteDossier(Dictionary<string, string> dossiers)
    {
        Console.WriteLine("Введите ФИО для удаления досье:");
        string fullName = Console.ReadLine();

        if (dossiers.ContainsKey(fullName))
        {
            dossiers.Remove(fullName);
            Console.WriteLine("Досье удалено! Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Такого досье не существует!!!");
            DeliteDossier(dossiers);
        }
    }

    static void DisplayDossierOnScreen(Dictionary<string, string> dossiers)
    {
        int numberDossier = 0;

        foreach (var dossier in dossiers)
        {
            numberDossier++;
            Console.Write($"№{numberDossier}. {dossier.Key} - {dossier.Value},");
        }
        Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
        Console.ReadKey();
        Console.Clear();
    }

    static void AddDossier(Dictionary<string,string> dossiers)
    {
        Console.WriteLine("Введите ФИО:");
        string fullName = Console.ReadLine();

        Console.WriteLine("Введите должность:");
        string job = Console.ReadLine();

        dossiers.Add(fullName, job);

        Console.WriteLine("Досье добавлено в базу! Нажмите любую кнопку для продолжения...");
        Console.ReadKey();
        Console.Clear();
    }
}