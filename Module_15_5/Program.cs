namespace Module_15_5
{
    internal class Program
    {
        #region Отложенное выполнение
        //// При отложенном выполнении выражение не будет выполнено,
        //// пока мы не обратимся к его результату в цикле или итерации.
        //static void Main(string[] args)
        //{
        //    var students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23 },
        //        new Student {Name="Сергей", Age=27 },
        //        new Student {Name="Дмитрий", Age=29 }
        //    };

        //    var youngStudents = from s in students where s.Age < 25 select s;

        //    // Запрос, написанный выше, будет выполнен, лишь когда мы обратимся
        //    // к результатам нашей выборки, например в цикле:
        //    foreach (var stud in youngStudents)
        //        Console.WriteLine(stud.Name);

        //    // Стадии выполнения LINQ-запроса можно условно разделить так:
        //    // 1. Получение источника данных(инициализация коллекции, в нашем случае списка студентов).
        //    // 2. Создание запроса(определение переменной youngStudents).
        //    // 3. Выполнение и получение результата(при обращении к переменной в цикле).
        //}
        #endregion
        #region Продолжение
        //static void Main(string[] args)
        //{
        //    var students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23 },
        //        new Student {Name="Сергей", Age=27 },
        //        new Student {Name="Дмитрий", Age=29 }
        //    };

        //    var youngStudents = from s in students where s.Age < 25 select s;

        //    // Добавим нового студента уже после инициализанции LINQ-запроса
        //    students.Add(new Student { Name = "Анна", Age = 21 });

        //    foreach (var stud in youngStudents)
        //        Console.WriteLine(stud.Name);

        //    // Если бы запрос тут выполнился сразу после инициализации, новый
        //    // студент бы в выборку не попал.

        //    // Важно зафиксировать, что сама переменная запроса — youngStudents —
        //    // не выполняет никаких действий. Она просто хранит сам запрос.
        //}
        #endregion
        #region Немедленное выполнение
        //static void Main(string[] args)
        //{
        //    // Некоторые методы всё же позволяют нам запустить выполнение запроса мгновенно.
        //    // Count();
        //    // Average();
        //    // First() / FirstOrDefault();
        //    // Min();
        //    // Max().

        //    var students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23 },
        //        new Student {Name="Сергей", Age=27 },
        //        new Student {Name="Дмитрий", Age=29 }
        //    };

        //    // здесь запрос будет выполнен немедленно, и в переменную будет сохранено количество элементов выборки
        //    var youngStudents = (from s in students where s.Age < 25 select s).Count();

        //    // Ещё один способ запустить мгновенное выполнение LINQ-выражения — сохранить
        //    // результат выборки в новую коллекцию с помощью таких методов, как:
        //    // ToArray();
        //    // ToList();
        //    // ToHashSet() и т.д.

        //    var youngStudents2 = students
        //        .Where(s => s.Age < 25) // на этом этапе происходит генерация LINQ-выражения
        //        .ToList(); // А вот тут уже будет выполнение
        //}
        #endregion
        #region 15.5.4
        // Напишите свой пример, который позволит узнать, приводит ли метод ToArray()
        // к мгновенному выполнению LINQ-запроса?
        static void Main(string[] args)
        {
            Console.WriteLine("Тест #1:\n");
            //  Подготовим тестовые данные
            var names = new List<string>() { "Вася", "Вова", "Петя", "Андрей" };

            // Подготовим тестовую выборку (без ToArray())
            var experiment = names.Where(name => name.StartsWith("В"));

            // уберем несколько элементов уже после выборки (если она выполняется отложено, то они в неё не попадут)
            names.Remove("Вася");
            names.Remove("Вова");

            // обратимся к выборке в цикле foreach
            foreach (var word in experiment)
                Console.WriteLine(word);

            // Теперь эксперимент с ToArray():
            Console.WriteLine("Тест #2:\n");
            //  Снова возьмем те же тестовые данные
            var names2 = new List<string>() { "Вася", "Вова", "Петя", "Андрей" };

            // Теперь добавим ToArray() в конце того же самого LINQ-запроса
            var experiment2 = names2.Where(name => name.StartsWith("В")).ToArray();

            // Также уберем несколько элементов
            names2.Remove("Вася");
            names2.Remove("Вова");

            // обратимся к выборку в цикле foreach
            foreach (var word in experiment2)
                Console.WriteLine(word);
        }
        #endregion
    }
}