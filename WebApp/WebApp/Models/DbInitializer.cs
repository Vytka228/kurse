using System;
using System.Linq;

namespace WebApp.Models
{
    public static class DbInitializer
    {
        // Метод инициализации базы данных путем заполнения таблиц тестовыми наборами данных
        public static void Initialize(BaseparkingContext db)
        {
            db.Database.EnsureCreated();

            Random random = new Random();

            char[] letters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            char[] lettersWithNumbers = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789".ToCharArray();

            // Проверка на наличие записей в таблице Владельцы
            if (!db.Owners.Any())
            {
                string fio = "";
                string fone = "+";

                for (int i = 1; i <= 40; i++)
                {
                    // Создание Id
                    int id = db.Owners.Count() + 1;

                    // Создание ФИО
                    int randInt = random.Next(18, 100);
                    for (int j = 1; j <= randInt; j++)
                    {
                        fio += letters[random.Next(33)];
                    }

                    // Создание номера
                    randInt = random.Next(5, 9);
                    for (int j = 2; j <= randInt; j++)
                    {
                        fone += numbers[random.Next(10)].ToString();
                    }

                    db.Owners.Add(new Owner { Id = id, Fio = fio, NameFone = fone});
                }
                db.SaveChanges();
            }

            // Проверка на наличие записей в таблице Машины
            if (!db.Cars.Any())
            {
                string brand = "";
                string number = "";

                for (int i = 1; i <= 40; i++)
                {
                    // Создание Id
                    int id = db.Cars.Count() + 1;

                    // Создание марки
                    int randInt = random.Next(15, 100);
                    for (int j = 1; j <= randInt; j++)
                    {
                        brand += letters[random.Next(33)];
                    }

                    // Создание номера
                    randInt = random.Next(6, 50);
                    for (int j = 1; j <= randInt; j++)
                    {
                        number += lettersWithNumbers[random.Next(43)];
                    }

                    // Создание Id владельца
                    int ownerId = random.Next(1, 41);

                    db.Cars.Add(new Car { Id = id, Carbrands = brand, Numberofthecar = number, OwnersId = ownerId });
                }
                db.SaveChanges();
            }

            // Проверка на наличие записей в таблице Парковки
            if (!db.Parkings.Any())
            {
                string typeParking = "";

                for (int i = 1; i <= 40; i++)
                {
                    // Создание Id
                    int id = db.Parkings.Count() + 1;

                    // Создание типа парковки
                    int randInt = random.Next(10, 60);
                    for (int j = 1; j <= randInt; j++)
                    {
                        typeParking += letters[random.Next(33)];
                    }

                    // Создание даты заезда
                    DateTime dateEntry = DateTime.Now.AddDays(-1);

                    // Создание даты выезда
                    DateTime dateDepart = DateTime.Now;

                    // Создание Id машины
                    int carId = random.Next(1, db.Cars.ToList().Select(elem => elem.Id).Max());

                    // Создание стоимости
                    decimal price = (decimal)random.NextDouble() * 10;

                    // Создание Id сотрудника
                    int staffId = 1;

                    db.Parkings.Add(new Parking { Id = id, TypeParking = typeParking, Datedeparture = dateDepart, Dateentry = dateEntry, Price = price, StaffsId = staffId, CarsId = carId });
                }
                db.SaveChanges();
            }
        }
    }
}