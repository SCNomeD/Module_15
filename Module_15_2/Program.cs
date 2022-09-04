using System.Text;

namespace Module_15_2
{
    internal class Program
    {
        #region Агрегация - Aggregate()
        //static void Main(string[] args)
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5 };
        //    int result = numbers.Aggregate((x, y) => x - y);

        //    // вычислит 1-2-3-4-5 = -13
        //    Console.WriteLine(result);

        //    // Другие арифметические действия также возможны: 
        //    int sum = numbers.Aggregate((x, y) => x + y);
        //    Console.WriteLine(sum);
        //}
        #endregion
        #region 15.2.1
        //static long Factorial(int number)
        //{
        //    // Коллекция для хранения чисел
        //    var numbers = new List<int>();

        //    // Добавляем все числа от 1 до n в коллекцию
        //    for (int i = 1; i <= number; i++)
        //        numbers.Add(i);

        //    // Выполняем агрегацию
        //    return numbers.Aggregate((x, y) => x * y);
        //}
        #endregion
        #region Count() 
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;

        //    // Список студентов
        //    var students = new List<Student>
        //    {
        //        new Student {Name="Алёна", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Яков", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
        //        new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
        //        new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
        //        new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        //    };

        //    // получим тех кто младше 25
        //    var youngStudentsAmount =
        //        (from student in students
        //         where student.Age < 25
        //         select student).Count();

        //    // выведет 1
        //    Console.WriteLine(youngStudentsAmount);

        //    Console.WriteLine();
        //    Console.WriteLine("Теперь через методы-расширения:");
        //    Console.WriteLine();

        //    // Есть другой способ — использовать перегрузку метода Count(),
        //    // принимающую на вход лямбда-выражение:
        //    // получим тех, кто младше 25
        //    var youngStudentsAmount2 = students.Count(s => s.Age < 25);

        //    // тоже выведет 1
        //    Console.WriteLine(youngStudentsAmount2);
        //}
        #endregion
        #region 15.2.2
        //static void Main(string[] args)
        //{
        //    var contacts = new List<Contact>()
        //    {
        //        new Contact() { Name = "Андрей", Phone = 79994500508 },
        //        new Contact() { Name = "Сергей", Phone = 799990455 },
        //        new Contact() { Name = "Иван", Phone = 79999675334 },
        //        new Contact() { Name = "Игорь", Phone = 8884994 },
        //        new Contact() { Name = "Анна", Phone = 665565656 },
        //        new Contact() { Name = "Василий", Phone = 3434 }
        //    };

        //    var invalidContacts =
        //        (from contact in contacts // пробегаемся по контактам
        //         let phoneString = contact.Phone.ToString()  // сохраняем в промежуточную переменную строку номера телефона
        //         where !phoneString.StartsWith('7') || phoneString.Length != 11 // выполняем выборку по условиям
        //         select contact) // добавляем объект в выборку
        //         .Count(); // считаем количество объектов в выборке

        //    // Вывод результата в консоль
        //    Console.WriteLine(invalidContacts);
        //}
        #endregion
        #region Sum() 
        //static void Main(string[] args)
        //{
        //    var simpleNumbers = new[] { 3, 5, 7 };

        //    // Вернет 15
        //    Console.WriteLine(simpleNumbers.Sum());

        //    // Список студентов
        //    var students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23 },
        //        new Student {Name="Сергей", Age=27 },
        //        new Student {Name="Дмитрий", Age=29 }
        //    };

        //    // сумма возрастов всех студентов
        //    var totalAge = students.Sum(s => s.Age);

        //    // Вернет 79
        //    Console.WriteLine(totalAge);
        //}
        #endregion
        #region 15.2.3
        //static double Average(int[] numbers)
        //{
        //    // если делить два целых числа, которые не делятся без остатка, при делении
        //    // остаток будет отброшен чтобы этого не случилось, нужно привести одно из
        //    // чисел к типу double
        //    return numbers.Sum() / (double)numbers.Length;
        //}
        #endregion
        #region Мax(), Min(), Average()
        //static void Main(string[] args)
        //{
        //    var nums = new[] { 1, 7, 45, 23 };

        //    int greatest = nums.Max();  // наибольшее - 45
        //    int smallest = nums.Min();  // наименьшее - 1
        //    double average = nums.Average();  // среднее - 19

        //    // Теперь посложнее: 
        //    var students = new List<Student>
        //    {
        //        new Student {Name="Андрей", Age=23 },
        //        new Student {Name="Сергей", Age=27 },
        //        new Student {Name="Дмитрий", Age=29 }
        //    };

        //    // найдем возраст самого старого студента ( 29 )
        //    var oldest = students.Max(s => s.Age);

        //    // самого молодого ( 23 )
        //    var youngest = students.Min(s => s.Age);

        //    //  и средний возраст ( 26,3 )
        //    var average2 = students.Average(s => s.Age);
        //}
        #endregion
        #region 15.2.8
        //   статическая переменная для хранения данных в памяти
        public static List<int> Numbers = new List<int>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число:");
                // Читаем введенный с консоли  текст
                var input = Console.ReadLine();

                // проверяем, число ли это
                var isInteger = Int32.TryParse(input, out int inputNum);

                // если не число - показываем ошибку
                if (!isInteger)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы ввели не число");
                }
                // если соответствует, запускаем обработчик
                else
                {
                    // добавляем в список
                    Numbers.Add(inputNum);

                    // выводим все критерии
                    Console.WriteLine("Число " + input + " добавлено в список.");
                    Console.WriteLine($"Всего в списке  {Numbers.Count} чисел");
                    Console.WriteLine($"Сумма:  {Numbers.Sum()}");
                    Console.WriteLine($"Наибольшее:  {Numbers.Max()}");
                    Console.WriteLine($"Наименьшее:  {Numbers.Min()}");
                    Console.WriteLine($"Среднее:  {Numbers.Average()}");

                    Console.WriteLine();
                }
            }
        }
        #endregion
    }
}