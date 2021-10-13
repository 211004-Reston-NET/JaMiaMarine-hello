using System;
using System.Collection.Generic;
using System.IO;
using System.Text.Json;
using HouseFunction;


namespace Serialize
{
    public Serialization
    {
        public string _filepath = "./House.json";

        public void SerialMain()
        {
            //Create a house obj
            House obj1 = new House()
            {
                Micename = "Mickey Mouse",
                Owner = "Minnie Mouse",
                Ghost = "Hairly Headless Nick"
            };

            House obj2 = new House()
            {
                Micename = "Mighty Mouse",
                Owner = "Pluto",
                Ghost = "Ghost Busters",
            };

            List<House> listOfHouses = new List<House>();
            listOfHouses.Add(obj1);
            listOfHouses.Add(obj2);

            //Serialize method will convert the obj into a string datatype
            //It will format the string in a way that JSON file understands
            //JSONSerializerOptions is a class that is designed to configure our JsonSerializer to do other Operations
            string _jsonString = JsonSerializer.Serialize(listOfHouses,new JsonSerializerOptions{WriteIndented = true});
            Console.WriteLine(_jsonString);

            File.WriteAllText(_filepath,_jsonString);


            //ReadAllText method will read from a file and store its contents into a string
            _jsonString = File.ReadAllText(_filepath);


            //Deserialize is a way to convert from JSON to Object
            //The <Class> is what the JSONSerializer will convert the JSON into the object
            List<House> listOfHouses2 = JsonSerializer.Deserialize<List<House>>(_jsonString);

            foreach (House item in listOfHouses2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
    
    
