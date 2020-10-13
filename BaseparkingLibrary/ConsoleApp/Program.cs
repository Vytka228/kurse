using System;
using BaseparkingLibrary;
using BaseparkingLibrary.Data;
using Newtonsoft.Json.Bson;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseparkingContext db = new BaseparkingContext();

            GetLinqMessage("task01", LinqTasks.SelectOne(db));
            GetLinqMessage("task02", LinqTasks.SelectOneByWhere(db));
            GetLinqMessage("task03", LinqTasks.SelectManyByGroup(db));
            GetLinqMessage("task04", LinqTasks.SelectOneMany(db));
            GetLinqMessage("task05", LinqTasks.SelectOneManyByWhere(db));

            string[] data = GetData("Введите ФИО:", "Введите nameFone:");
            GetLinqMessage("task06", LinqTasks.InsertOne(data[0], data[1], db));

            data = GetData("Введите Carbands:", "Введите numberoffthecar:", "Введите Fio:");
            GetLinqMessage("task07", LinqTasks.InsertMany(data[0], data[1], data[2], db));

            data = GetData("Введите Fio:");
            GetLinqMessage("task08", LinqTasks.DeleteOne(data[0], db));

            data = GetData("Введите Carbrands:");
            GetLinqMessage("task09", LinqTasks.DeleteMany(data[0], db));

            data = GetData("Введите oldName:", "Введите fio", "Введите nameFone");
            GetLinqMessage("task10", LinqTasks.UpdateOne(data[0], data[1], data[2], db));
        }

        static void GetLinqMessage(string task, string linqMessage)
        {
            Console.WriteLine("\n" + task);
            Console.WriteLine("\n" + linqMessage);
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить.");
            Console.ReadKey();
            Console.Clear();
        }

        static string[] GetData(params string[] vs)
        {
            string[] data = new string[vs.Length];
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine("\n" + vs[i]);
                data[i] = Console.ReadLine();
            }

            return data;
        }

    }
}
