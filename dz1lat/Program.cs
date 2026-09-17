using dz1lat.dop;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using static dz1lat.dop.RentalContract;
namespace dz1lat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Классная работа 0");
            byte oxygenLevel = 250;
            byte extraOxygen = 10;
            byte result = (byte)(oxygenLevel + extraOxygen);
            Console.WriteLine($"Количество кислорода: {oxygenLevel}\nКоличество резервного кислорода: {extraOxygen}\nВсего кислорода: {result}\nВсего кислорода(int):{extraOxygen + oxygenLevel}");
            Console.ReadKey();

            Console.WriteLine("Классная работа 1");
            austronaut newcandidat = new austronaut();
            Console.WriteLine("Введите имя кандидата:");
            newcandidat.name = Console.ReadLine();
            Console.WriteLine("Введите возраст кандидата:");
            newcandidat.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рост кандидата в м:");
            newcandidat.Height = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес кандидата в кг:");
            newcandidat.Weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите любимый фильм о космосе кандидата:");
            newcandidat.Favmovie = Console.ReadLine();
            Console.WriteLine($"Имя кандидата:{newcandidat.name}\n Возраст кандидата:{newcandidat.Age}\n Рост кандидата:{newcandidat.Height}\n Вес кандидата:{newcandidat.Weight}\n Любимый фильм о космосе кандидата:{newcandidat.Favmovie}");
            Console.ReadKey();

            Console.WriteLine("Классная работа 2");
            TrainTicket ticket = new TrainTicket();
            Console.WriteLine("Введите свое ФИО");
            ticket.PassengerName = Console.ReadLine();
            Console.WriteLine("Введите номер поезда");
            ticket.TrainNumber = Console.ReadLine();
            Console.WriteLine("Введите дату отправки поезда");
            ticket.Date = Console.ReadLine();
            Console.WriteLine("Введите время отправки поезда");
            ticket.Time = Console.ReadLine();
            Console.WriteLine("Введите тип вагона:1- для плацкарта,2- для купе,3- для СВ,4-для Люкса");
            byte input = Convert.ToByte(Console.ReadLine());
            if (0 > input && input > 5)
            {
                if (input == 1) { ticket.Carriage = CarriageType.ReservedSeat; }
                else if (input == 2) { ticket.Carriage = CarriageType.Compartment; }
                else if (input == 3) { ticket.Carriage = CarriageType.SV; }
                else if (input == 4) { ticket.Carriage = CarriageType.Luxury; }
            }
            else { Console.WriteLine("Ошибка!"); }
            Console.WriteLine("Введите цену билета в рублях");
            ticket.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"ФИО Пассажира: {ticket.PassengerName}\nНомер поезда: {ticket.TrainNumber}\nДата отправки поезда: {DateTime.Parse(ticket.Date)}\nВремя отправки: {TimeSpan.Parse(ticket.Time)}\nТип вагона: {ticket.Carriage}\nЦена билета:{ticket.Price}");
            Console.ReadKey();

            Console.WriteLine("Классная работа3");
            RentalContract contract = new RentalContract();
            Console.WriteLine("Введите ФИО клиента: ");
            contract.ClientName = Console.ReadLine();
            Console.WriteLine("Введите марку и модель автомобиля: ");
            contract.CarModel = Console.ReadLine();


            Console.WriteLine("Выберите класс автомобиля 1 — Эконом,2 — Комфорт,3 — Бизнес,4-Премиум");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (0 > input2 && input2 > 5)
            {
                if (input2 == 1) { contract.VehicleClass = CarClass.Economy; }
                else if (input2 == 2) { contract.VehicleClass = CarClass.Comfort; }
                else if (input2 == 3) { contract.VehicleClass = CarClass.Business; }
                else if (input2 == 4) { contract.VehicleClass = CarClass.Premium; }
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }

            Console.WriteLine("\nВведите дату начала аренды (ДД.ММ.ГГГГ): ");
            contract.StartDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату окончания аренды (ДД.ММ.ГГГГ): ");
            contract.EndDate = DateTime.Parse(Console.ReadLine());
            TimeSpan TotalDays = contract.EndDate - contract.StartDate;
            Console.WriteLine("Введите посуточную стоимость аренды");
            contract.PricePerDay = Convert.ToInt32(Console.ReadLine());
            decimal TotalCost = contract.PricePerDay * TotalDays.Days;
            Console.WriteLine($" Арендатор (ФИО):     {contract.ClientName}\nАвтомобиль:          {contract.CarModel}\nПериод аренды:       с {contract.StartDate:dd.MM.yyyy} по {contract.EndDate:dd.MM.yyyy}\nОбщее кол-во суток:  {TotalDays}\nТариф за сутки:      {contract.PricePerDay:F2} руб.\nИТОГО К ОПЛАТЕ:      {TotalCost:F2} руб.");
            Console.ReadKey();

            Console.WriteLine("Классная работа 4");
            StudentCard student = new StudentCard();
            Console.WriteLine("Введите ФИО студента: ");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Введите номер зачетной книжки: ");
            student.GradeBookNumber = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Выберите факультет:\n1 — ИТ\n2 — Экономика\n3 — Юриспруденция\n 4 — Дизайн\nВведите цифру от 1 до 4:");
                string choice = Console.ReadLine();
                if (choice == "1") { student.StudentFaculty = Faculty.IT; break; }
                else if (choice == "2") { student.StudentFaculty = Faculty.Economics; break; }
                else if (choice == "3") { student.StudentFaculty = Faculty.Law; break; }
                else if (choice == "4") { student.StudentFaculty = Faculty.Design; break; }
                else { Console.WriteLine("Ошибка!"); }
            }
            while (true)
            {
                Console.WriteLine("\nВведите курс:");
                if (int.TryParse(Console.ReadLine(), out int course) && course >= 1 && course <= 6)
                {
                    student.Course = course;
                    break;
                }
                Console.WriteLine("Ошибка!");
            }
            while (true)
            {
                Console.WriteLine("Введите средний балл от 0 до 5: ");
                string inputScore = Console.ReadLine().Replace('.', ',');
                if (double.TryParse(inputScore, out double score) && score >= 0.0 && score <= 5.0)
                {
                    student.AverageScore = score;
                    break;
                }
                Console.WriteLine("Ошибка!");
            }
            while (true)
            {
                Console.Write("Введите дату зачисления (ДД.ММ.ГГГГ): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime enrollmentDate))
                {
                    student.EnrollmentDate = enrollmentDate.Date;
                    break;
                }
                Console.WriteLine("Ошибка! Неверный формат даты.");
            }
            Console.WriteLine($" ФИО студента: {student.FullName}\n№ зачетной книжки: {student.GradeBookNumber}\nФакультет: {student.StudentFaculty}\nКурс обучения: {student.Course}\nСредний балл: {student.AverageScore:F2}\nДата зачисления: {student.EnrollmentDate:dd.MM.yyyy}");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 1");
            Console.WriteLine($"sbyte   – {sbyte.MaxValue}   – {sbyte.MinValue}");
            Console.WriteLine($"byte    – {byte.MaxValue}   – {byte.MinValue}");
            Console.WriteLine($"short   – {short.MaxValue}   – {short.MinValue}");
            Console.WriteLine($"ushort  – {ushort.MaxValue}   – {ushort.MinValue}");
            Console.WriteLine($"int     – {int.MaxValue}   – {int.MinValue}");
            Console.WriteLine($"uint    – {uint.MaxValue}   – {uint.MinValue}");
            Console.WriteLine($"long    – {long.MaxValue}   – {long.MinValue}");
            Console.WriteLine($"ulong   – {ulong.MaxValue}   – {ulong.MinValue}");
            Console.WriteLine($"float   – {float.MaxValue:E}   – {float.MinValue:E}");
            Console.WriteLine($"double  – {double.MaxValue:E}   – {double.MinValue:E}");
            Console.WriteLine($"decimal – {decimal.MaxValue}   – {decimal.MinValue}");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 2");
            User user = new User();
            Console.Write("Введите имя: ");
            user.Name = Console.ReadLine();
            Console.Write("Введите город: ");
            user.City = Console.ReadLine();
            Console.Write("Введите возраст: ");
            user.Age = int.Parse(Console.ReadLine());
            Console.Write("Введите PIN-код: ");
            user.PinCode = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Имя: {user.Name}\nГород: {user.City}\nВозраст: {user.Age}\nPIN-код: {user.PinCode}");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 3");
            Console.WriteLine("Введите строку:");
            string i = Console.ReadLine();
            string result2 = string.Concat(i.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)));
            Console.WriteLine($"Если поменять регистр ваша строка будет выглядеть как:{result2}");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 3");
            Console.Write("Введите строку: ");
            string source = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string substring = Console.ReadLine();
            int count = source.Split(new[] { substring }, StringSplitOptions.None).Length - 1;
            Console.WriteLine($"Количество вхождений: {count}");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 4");
            Console.Write("Обычная цена: ");
            int basicPrice = int.Parse(Console.ReadLine());
            Console.Write("Скидка в %: ");
            int discount = int.Parse(Console.ReadLine());
            Console.Write("Стоимость отпуска: ");
            int holidayPrice = int.Parse(Console.ReadLine());
            double savingsPerBottle = basicPrice * (discount / 100.0);
            int bottlesNeeded = (int)Math.Floor(holidayPrice / savingsPerBottle);
            Console.WriteLine($"Необходимо купить бутылок: {bottlesNeeded}");
            Console.ReadKey();


            Drink beer = new Drink("Пиво", 5.0);
            Drink wine = new Drink("Вино", 12.0);
            Drink vodka = new Drink("Водка", 40.0);
            Drink juice = new Drink("Сок/Вода", 0.0);

            Student[] students = new Student[]
            {
                new Student { LastName = "Иванов", FirstName = "Иван", Id = 1, BirthDate = new DateTime(2005, 5, 12), AlcoholCategory = 'a', FavoriteDrink = vodka, Volume = 1.5 },
                new Student { LastName = "Петров", FirstName = "Петр", Id = 2, BirthDate = new DateTime(2006, 3, 22), AlcoholCategory = 'b', FavoriteDrink = beer, Volume = 5.0 },
                new Student { LastName = "Сидоров", FirstName = "Олег", Id = 3, BirthDate = new DateTime(2004, 11, 2), AlcoholCategory = 'c', FavoriteDrink = wine, Volume = 2.0 },
                new Student { LastName = "Козлов", FirstName = "Антон", Id = 4, BirthDate = new DateTime(2005, 8, 19), AlcoholCategory = 'a', FavoriteDrink = beer, Volume = 10.0 },
                new Student { LastName = "Тихонов", FirstName = "Игорь", Id = 5, BirthDate = new DateTime(2006, 1, 30), AlcoholCategory = 'd', FavoriteDrink = juice, Volume = 3.0 }
            };
            double totalVolume = 0;
            double totalPureAlcohol = 0;

            foreach (var student2 in students)
            {
                totalVolume += student2.Volume;
                totalPureAlcohol += student2.PureAlcoholVolume;
            }
            Console.WriteLine($"Общий объем выпитой жидкости: {totalVolume:F2} л.\nОбщий объем чистого алкоголя: {totalPureAlcohol:F2} л.");
            Console.WriteLine("ДЕТАЛИЗАЦИЯ ПО СТУДЕНТАМ:");
            foreach (var student2 in students)
            { 
                double percentOfTotalVolume = totalVolume > 0 ? (student2.Volume / totalVolume) * 100 : 0;
                double percentOfTotalAlcohol = totalPureAlcohol > 0 ? (student2.PureAlcoholVolume / totalPureAlcohol) * 100 : 0;

                Console.WriteLine($"Студент: {student2.LastName} {student2.FirstName}(Кат. '{student2.AlcoholCategory}'\nНапиток: {student2.FavoriteDrink.Name}, Выпито: {student2.Volume} л.\n% от ВСЕЙ выпитой жидкости в группе: {percentOfTotalVolume:F1}%\n% от ВСЕГО выпитого алкоголя в группе: {percentOfTotalAlcohol:F1}%");
            }
            Console.ReadKey();
        }

    }
    }

