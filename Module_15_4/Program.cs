namespace Module_15_4
{
    internal class Program
    {
        #region Join()
        //// Как правило, эту операцию можно применять к двум наборам коллекций,
        //// имеющим общий критерий.
        //static void Main(string[] args)
        //{
        //    // Список моделей
        //    var cars = new List<Car>()
        //    {
        //        new Car() { Model  = "SX4", Manufacturer = "Suzuki"},
        //        new Car() { Model  = "Grand Vitara", Manufacturer = "Suzuki"},
        //        new Car() { Model  = "Jimny", Manufacturer = "Suzuki"},
        //        new Car() { Model  = "Land Cruiser Prado", Manufacturer = "Toyota"},
        //        new Car() { Model  = "Camry", Manufacturer = "Toyota"},
        //        new Car() { Model  = "Polo", Manufacturer = "Volkswagen"},
        //        new Car() { Model  = "Passat", Manufacturer = "Volkswagen"},
        //    };

        //    // Список автопроизводителей
        //    var manufacturers = new List<Manufacturer>()
        //    {
        //        new Manufacturer() { Country = "Japan", Name = "Suzuki" },
        //        new Manufacturer() { Country = "Japan", Name = "Toyota" },
        //        new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
        //    };

        //    // Соединим и сопоставим коллекции:
        //    var result = from car in cars // выберем машины
        //                 join m in manufacturers on car.Manufacturer equals m.Name // соединим по общему ключу (имя производителя) с производителями
        //                 select new //   спроецируем выборку в новую анонимную сущность
        //                 {
        //                     Name = car.Model,
        //                     Manufacturer = m.Name,
        //                     Country = m.Country
        //                 };

        //    // выведем результаты
        //    foreach (var item in result)
        //        Console.WriteLine($"{item.Name} - {item.Manufacturer} ({item.Country})");

        //    // Метод расширения Join(), как обычно, предоставляет ещё один вариант сделать то же самое:
        //    var result2 = cars.Join(manufacturers, // передаем в качестве параметра вторую коллекцию
        //        car => car.Manufacturer, // указываем общее свойство для первой коллекции
        //        m => m.Name, // указываем общее свойство для второй коллекции
        //        (car, m) =>
        //        new // проекция в новый тип
        //        {
        //            Name = car.Model,
        //            Manufacturer = m.Name,
        //            Country = m.Country
        //        });
        //}
        #endregion
        #region 15.4.1
        //static void Main(string[] args)
        //{
        //    var departments = new List<Department>()
        //    {
        //        new Department() {Id = 1, Name = "Программирование"},
        //        new Department() {Id = 2, Name = "Продажи"}
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
        //        new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
        //        new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
        //        new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
        //    };

        //    var employeeAndDep = from employee in employees
        //                         join dep in departments on employee.DepartmentId equals dep.Id //  соединяем коллекции по общему ключу
        //                         select new // выборка в новую сущность
        //                         {
        //                             EmployeeName = employee.Name,
        //                             DepartmentName = dep.Name
        //                         };

        //    foreach (var item in employeeAndDep)
        //        Console.WriteLine(item.EmployeeName + ", отдел: " + item.DepartmentName);
        //}
        #endregion
        #region GroupJoin()
        //// Позволяет одновременно с тем, что мы делали выше (соединение
        //// последовательностей), произвести группировку.
        //static void Main(string[] args)
        //{
        //    // Список моделей
        //    var cars = new List<Car>()
        //        {
        //            new Car() { Model  = "SX4", Manufacturer = "Suzuki"},
        //            new Car() { Model  = "Grand Vitara", Manufacturer = "Suzuki"},
        //            new Car() { Model  = "Jimny", Manufacturer = "Suzuki"},
        //            new Car() { Model  = "Land Cruiser Prado", Manufacturer = "Toyota"},
        //            new Car() { Model  = "Camry", Manufacturer = "Toyota"},
        //            new Car() { Model  = "Polo", Manufacturer = "Volkswagen"},
        //            new Car() { Model  = "Passat", Manufacturer = "Volkswagen"},
        //        };

        //    // Список автопроизводителей
        //    var manufacturers = new List<Manufacturer>()
        //        {
        //            new Manufacturer() { Country = "Japan", Name = "Suzuki" },
        //            new Manufacturer() { Country = "Japan", Name = "Toyota" },
        //            new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
        //        };

        //    // Выборка + группировка
        //    var result = manufacturers.GroupJoin(
        //       cars, // первый набор данных
        //       m => m.Name, // общее свойство второго набора
        //       car => car.Manufacturer, // общее свойство первого набора
        //       (m, crs) => new  // результат выборки
        //       {
        //           Name = m.Name,
        //           Country = m.Country,
        //           Cars = crs.Select(c => c.Model)
        //       });

        //    // Вывод:
        //    foreach (var team in result)
        //    {
        //        Console.WriteLine(team.Name + ":");

        //        foreach (string car in team.Cars)
        //            Console.WriteLine(car);

        //        Console.WriteLine();
        //    }
        //}
        #endregion
        #region 15.4.2
        //static void Main(string[] args)
        //{
        //    var departments = new List<Department>()
        //    {
        //        new Department() {Id = 1, Name = "Программирование"},
        //        new Department() {Id = 2, Name = "Продажи"}
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
        //        new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
        //        new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
        //        new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
        //    };

        //    var depsWithEmployees = departments.GroupJoin(
        //        employees, // первый набор данных
        //        d => d.Id, // общее свойство второго набора
        //        e => e.DepartmentId, // общее свойство первого набора
        //        (dep, emps) => new // результат выборки
        //        {
        //            Name = dep.Name,
        //            Employees = emps.Select(e => e.Name)
        //        });

        //    // Пробегаемся по каждому отделу
        //    foreach (var dep in depsWithEmployees)
        //    {
        //        Console.WriteLine(dep.Name + ":");

        //        // Выводим сотрудников
        //        foreach (string emp in dep.Employees)
        //            Console.WriteLine(emp);

        //        Console.WriteLine();
        //    }
        //}
        #endregion
        #region Zip()
        //// Данный метод позволяет попарно соединять последовательности.
        //// При необходимости можно на ходу выполнить дополнительные операции:
        //static void Main(string[] args)
        //{
        //    //  объявляем две коллекции
        //    var letters = new string[] { "A", "B", "C", "D", "E" };
        //    var numbers = new int[] { 1, 2, 3 };

        //    // проводим "упаковку" элементов, сопоставляя попарно
        //    var q = letters.Zip(numbers, (l, n) => l + n.ToString());

        //    // вывод
        //    foreach (var s in q)
        //        Console.WriteLine(s);
        //}
        #endregion
        #region 15.4.5
        static void Main(string[] args)
        {
            var customers = new Customer[]
            {
                new Customer{ID = 5, Name = "Андрей"},
                new Customer{ID = 6, Name = "Сергей"},
                new Customer{ID = 7, Name = "Юлия"},
                new Customer{ID = 8, Name = "Анна"}
            };

            var orders = new Order[]
            {
                new Order{ID = 6, Product = "Игру"},
                new Order{ID = 7, Product = "Компьютер"},
                new Order{ID = 8, Product = "Рубашку"} ,
                new Order{ID = 5, Product = "Книгу"}
            };

            var query = from c in customers
                        join o in orders on c.ID equals o.ID
                        select new { c.Name, o.Product };
            foreach (var group in query)
                Console.WriteLine($"{group.Name} покупает {group.Product}");
        }
        #endregion
        #region
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //}
        #endregion
    }
}