using System;
using System.Collections.Generic;
using System.Text;
using BaseparkingLibrary.Data;
using BaseparkingLibrary.Models;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace BaseparkingLibrary
{
    public static class LinqTasks
    {
        /// <summary>
        /// Task01.
        /// </summary>
        public static string SelectOne(BaseparkingContext db)
        {
            StringBuilder builder = new StringBuilder();

            var query = from o in db.Owners
                        select new
                        {
                            o.Fio,
                            o.NameFone
                        };

            foreach (var entity in query.Take(5))
                builder.Append(entity + "\n");

            return builder.ToString();
        }

        /// <summary>
        /// Task02.
        /// </summary>
        public static string SelectOneByWhere(BaseparkingContext db)
        {
            StringBuilder builder = new StringBuilder();

            var query = from o in db.Owners
                         where o.Fio.Length > 40
                         select new
                         {
                             o.Fio,
                             o.NameFone
                         };

            foreach (var entity in query.Take(5))
                builder.Append(entity + "\n");

            return builder.ToString();
        }

        /// <summary>
        /// Task03.
        /// </summary>
        public static string SelectManyByGroup(BaseparkingContext db)
        {
            StringBuilder builder = new StringBuilder();

            var query = from c in db.Cars
                        group c by c.Carbrands into n
                        select new
                        {
                            Carbrand = n.Key,
                            CarbrandCount = n.Count()
                        };

            foreach (var entity in query.Take(5))
                builder.Append(entity + "\n");

            return builder.ToString();
        }

        /// <summary>
        /// Task04.
        /// </summary>
        public static string SelectOneMany(BaseparkingContext db)
        {
            StringBuilder builder = new StringBuilder();

            var query = from c in db.Cars
                        join o in db.Owners
                        on c.OwnersId equals o.Id
                        select new
                        {
                            c.Carbrands,
                            c.Numberofthecar,
                            Owner = o.Fio
                        };

            foreach (var entity in query.Take(5))
                builder.Append(entity + "\n");

            return builder.ToString();
        }

        /// <summary>
        /// Task05.
        /// </summary>
        public static string SelectOneManyByWhere(BaseparkingContext db)
        {
            StringBuilder builder = new StringBuilder();

            var query = from c in db.Cars
                        join o in db.Owners
                        on c.OwnersId equals o.Id
                        where c.Carbrands.Length < 40
                        select new
                        {
                            c.Carbrands,
                            c.Numberofthecar,
                            Owner = o.Fio
                        };

            foreach (var entity in query.Take(5))
                builder.Append(entity + "\n");

            return builder.ToString();
        }

        /// <summary>
        /// Task06.
        /// </summary>
        public static string InsertOne(string fio, string nameFone, BaseparkingContext db)
        {
            Owner owner = new Owner();
            
            owner.Fio = fio;
            owner.NameFone = nameFone;

            db.Owners.Add(owner);
            db.SaveChanges();

            return $"Fio: {fio}, NameFone = {nameFone}\n";
        }

        /// <summary>
        /// Task07.
        /// </summary>
        public static string InsertMany(string carbrands, string numberofthecar, string fio, BaseparkingContext db)
        {
            Car car = new Car();

            car.Carbrands = carbrands;
            car.Numberofthecar = numberofthecar;
            car.OwnersId = db.Owners.Where(o => o.Fio == fio).FirstOrDefault().Id;

            db.Cars.Add(car);
            db.SaveChanges();

            return $"Carbrands: {carbrands}, Numberofthecar = {numberofthecar}\n";
        }

        /// <summary>
        /// Task08.
        /// </summary>
        public static string DeleteOne(string fio, BaseparkingContext db)
        {
            Owner owner = db.Owners.Find(db.Owners.Where(o => o.Fio == fio).FirstOrDefault().Id);
            db.Owners.Remove(owner);
            db.SaveChanges();

            return $"Fio: {owner.Fio}, NameFone = {owner.NameFone}\n";
        }

        /// <summary>
        /// Task09.
        /// </summary>
        public static string DeleteMany(string carbrands, BaseparkingContext db)
        {
            Car car = db.Cars.Find(db.Cars.Where(c => c.Carbrands == carbrands).FirstOrDefault().Id);
            db.Cars.Remove(car);
            db.SaveChanges();

            return $"Carbrands: {car.Carbrands}, Numberofthecar = {car.Numberofthecar}\n";
        }

        /// <summary>
        /// Task10.
        /// </summary>
        public static string UpdateOne(string oldFio, string fio, string nameFone, BaseparkingContext db)
        {
            Owner owner = db.Owners.Find(db.Owners.Where(o => o.Fio == oldFio).FirstOrDefault().Id);

            owner.Fio = fio;
            owner.NameFone = nameFone;

            db.SaveChanges();

            return $"Fio: {fio}, NameFone = {nameFone}\n";
        }
    }
}
