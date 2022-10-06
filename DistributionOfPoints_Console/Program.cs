using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DistributionOfPoints_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Rogue rogue = new Rogue();
            Wizard wizard = new Wizard();

            MongoExamples.ReplaceByName("Wizard", wizard);
        }
    }
}


