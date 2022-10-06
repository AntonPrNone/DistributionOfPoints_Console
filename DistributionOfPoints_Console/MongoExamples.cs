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
            if (name == "Warrior")
            {
                var WarriorDefaultValue = MongoExamples.Find("WarriorDefaultValue");
                WarriorDefaultValue.Name = "Warrior";
                MongoExamples.ReplaceByName("Warrior", WarriorDefaultValue);
            }

            else if (name == "Rogue")
            {
                var RogueDefaultValue = MongoExamples.Find("RogueDefaultValue");
                RogueDefaultValue.Name = "Rogue";
                MongoExamples.ReplaceByName("Rogue", RogueDefaultValue);
            }

            else if (name == "Wizard")
            {
                var WizardDefaultValue = MongoExamples.Find("WizardDefaultValue");
                WizardDefaultValue.Name = "Wizard";
                MongoExamples.ReplaceByName("Wizard", MongoExamples.Find("WizardDefaultValue"));
            }
        }
    }
}
