using MongoDB.Driver;
using System.Linq;

namespace DistributionOfPoints_Console
{
    public class MongoExamples
    {

        public static Unit Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("DB");
            var collection = database.GetCollection<Unit>("Units");
            var document = collection.Find(x => x.Name == name).FirstOrDefault();
            return document;
        }

        public static void ReplaceByName(string name, Unit unit)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("DB");
            var collection = database.GetCollection<Unit>("Units");
            collection.ReplaceOne(x => x.Name == name, unit);
        }

        public static void ResetValues(string name)
        {
            Unit DefaultValue = Find(name + "DefaultValue");
            DefaultValue.Name = name;
            ReplaceByName(name, DefaultValue);
        }
    }
}
