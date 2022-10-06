using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionOfPoints_Console
{
    internal class MongoExamples
    {

        public static void Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("DB");
            var collection = database.GetCollection<Warrior>("Units");
            var one = collection.Find(x => x.Name == name).FirstOrDefault();

            Console.WriteLine($" {one?.Name} {one?.maxHP} ");

        }

        public static void ReplaceByName(string name, Wizard wizard)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("DB");
            var collection = database.GetCollection<Wizard>("Units");
            collection.ReplaceOne(x => x.Name == name, wizard);
        }
    }
}
