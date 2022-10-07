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
            Unit rogue = MongoExamples.Find("Rogue");
            MongoExamples.ResetValues(rogue.Name);
        }
    }
}


