using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DistributionOfPoints_Console
{
    internal class Program
    {
        public static void Main()
        {
            MongoExamples.SaveValues("WizardDefaultValue", MongoExamples.Find("Wizard"));
        }
    }
}


