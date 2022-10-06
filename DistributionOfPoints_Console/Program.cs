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
            Unit warrior = MongoExamples.Find("Warrior");
            MongoExamples.ResetValues(warrior.Name);
        }
    }
}


