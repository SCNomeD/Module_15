namespace Module_15
{
    internal class Program
    {
        #region Разность - Except() (Важно! Метод Except() возвращает только уникальные элементы.)
        //static void Main(string[] args)
        //{
        //    // Список напитков в продаже
        //    string[] drinks = { "Вода", "Кока-кола", "Лимонад", "Вино" };
        //    // Алкогольные напитки
        //    string[] alcohol = { "Вино", "Пиво", "Сидр" };

        //    // Убираем алкоголь из ассортимента
        //    var drinksForKids = drinks.Except(alcohol);

        //    foreach (string drink in drinksForKids)
        //        Console.WriteLine(drink);
        //}
        #endregion
        #region Пересечение - Intersect()
        //static void Main(string[] args)
        //{
        //    string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
        //    string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

        //    // поищем машины, которые можно считать микроавтобусами
        //    var microBuses = cars.Intersect(buses);

        //    foreach (string mb in microBuses)
        //        Console.WriteLine(mb);
        //}
        #endregion
        #region Объединение - Union()
        //static void Main(string[] args)
        //{
        //    string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };
        //    string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

        //    var vehicles = cars.Union(buses);

        //    foreach (string v in vehicles)
        //        Console.WriteLine(v);
        //}
        #endregion
        #region Если объединение с дубликатами - Concat()
        //static void Main(string[] args)
        //{
        //    string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };
        //    string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

        //    // объединяет с дубликатами
        //    var vehicles = cars.Concat(buses);

        //    foreach (string v in vehicles)
        //        Console.WriteLine(v);
        //}
        #endregion
        #region Для удаления дубликатов из коллекции - Distinct()
        //static void Main(string[] args)
        //{
        //    string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };

        //    // удалим дубликаты
        //    var uniqueCars = cars.Distinct();

        //    foreach (string v in uniqueCars)
        //        Console.WriteLine(v);
        //}
        #endregion
        #region 15.1.4
        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Введите 1-ое слово:");
        //        var num1 = Console.ReadLine();
        //        Console.WriteLine("Введите 2-ое слово:");
        //        var num2 = Console.ReadLine();
        //        Console.WriteLine("Число общих символов: " + CountCommon(num1, num2));
        //    }
        //}

        //static int CountCommon(string word1, string word2)
        //{
        //    // ищем пересечение
        //    var amount = word1.Intersect(word2)
        //        .Count(); // считаем количество
        //    return amount;
        //}
        #endregion
        #region 15.1.5
        //static void Main(string[] args)
        //{
        //    var softwareManufacturers = new List<string>()
        //    {
        //        "Microsoft", "Apple", "Oracle"
        //    };

        //    var hardwareManufacturers = new List<string>()
        //    {
        //        "Apple", "Samsung", "Intel"
        //    };

        //    var itCompanies = softwareManufacturers.Union(hardwareManufacturers);

        //    foreach (string v in itCompanies)
        //        Console.WriteLine(v);
        //}
        #endregion
        #region 15.1.6
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");

            // читаем ввод
            var text = Console.ReadLine();

            // сохраняем список знаков препинания и символ пробела в коллекцию
            var punctuation = new List<char>() { ' ', ',', '.', ';', ':', '!', '?' };

            // валидация ввода
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Вы ввели пустой текст");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Текст без знаков препинания: ");

            // так как строка - это массив char, мы можем вызвать метод  except  и удалить знаки препинания
            var noPunctuation = text.Except(punctuation).ToArray();

            // вывод
            Console.WriteLine(noPunctuation);
        }
        #endregion
    }
}