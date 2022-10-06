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
            Unit warrior = new Unit(MongoExamples.Find("Warrior"));
            warrior.ResetValues();
        }
    }
}


