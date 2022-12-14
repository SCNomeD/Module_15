namespace Module_15_3
{
    internal class Program
    {
        #region Группировка - GroupBy()
        //static void Main(string[] args)
        //{
        //    var cars = new List<Car>()
        //    {
        //        new Car("Suzuki", "JP"),
        //        new Car("Toyota", "JP"),
        //        new Car("Opel", "DE"),
        //        new Car("Kamaz", "RUS"),
        //        new Car("Lada", "RUS"),
        //        new Car("Honda", "JP"),
        //    };

        //    // Группировка по стране - производителю
        //    var carsByCountry = from car in cars
        //                        group car by car.CountryCode;

        //    // Пробежимся по группам
        //    foreach (var grouping in carsByCountry)
        //    {
        //        Console.WriteLine(grouping.Key + ":");

        //        // внутри каждой группы пробежимся по элементам
        //        foreach (var car in grouping)
        //            Console.WriteLine(car.Manufacturer);

        //        Console.WriteLine();
        //    }

        //    // Группировка по стране - производителю ( через метод - расширение)
        //    var carsByCountry2 = cars.GroupBy(car => car.CountryCode);

        //    // При группировке мы можем использовать уже известную вам проекцию для
        //    // создания объекта нового типа:
        //    var carsByCountry3 = cars
        //        .GroupBy(car => car.CountryCode) // группируем по стране-производителю
        //        .Select(group => new
        //        { //  создаем новую сущность анонимного типа
        //            Name = group.Key,
        //            Amount = group.Count()
        //        });

        //    // И даже осуществлять вложенные запросы, используя ключевое слово into.
        //    Console.Write("И даже осуществлять вложенные запросы, используя ключевое слово into:\n");
        //    var carsByCountry4 = from car in cars
        //                         group car by car.CountryCode into grouping // выборка в локальную переменную для вложенного запроса
        //                         select new
        //                         {
        //                             Name = grouping.Key,
        //                             Count = grouping.Count(),
        //                             Cars = from p in grouping select p //  выполним подзапрос, чтобы заполнить список машин внутри нашего нового типа
        //                         };

        //    // Выведем результат
        //    foreach (var group in carsByCountry4)
        //    {
        //        // Название группы и количество элементов
        //        Console.WriteLine($"{group.Name} : {group.Count} авто");

        //        foreach (Car car in group.Cars)
        //            Console.WriteLine(car.Manufacturer);

        //        Console.WriteLine();
        //    }

        //    // Аналогичный запрос с помощью метода расширения, как всегда, выглядит менее
        //    // громоздким:
        //    var carsByCountry5 = cars
        //        .GroupBy(car => car.CountryCode)
        //        .Select(g => new
        //        {
        //            Name = g.Key,
        //            Count = g.Count(),
        //            Cars = g.Select(c => c)
        //        });
        //}
        #endregion
        #region 15.3.3
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            //  в качестве критерия группировки передаем домен адреса электронной почты
            var grouped = phoneBook.GroupBy(c => c.Email.Split("@").Last());

            // обрабатываем получившиеся группы
            foreach (var group in grouped)
            {
                // если ключ содержит example, значит, это фейк
                if (group.Key.Contains("example"))
                {
                    Console.WriteLine("Фейковые адреса: ");

                    foreach (var contact in group)
                        Console.WriteLine(contact.Name + " " + contact.Email);

                }
                else
                {
                    Console.WriteLine("Реальные адреса: ");
                    foreach (var contact in group)
                        Console.WriteLine(contact.Name + " " + contact.Email);
                }

                Console.WriteLine();
            }
        }
        #endregion
    }
}