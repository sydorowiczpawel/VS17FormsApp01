using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------------------------
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//--------------------------------------------------------

namespace VS17FormsApp01

{
    [Serializable()]

    public class Soldier : ISerializable
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathers_name { get; set; }
        public string Born { get; set; }
        public string Rank { get; set; }
        public string Position { get; set; }
        public string Platoon { get; set; }
        public string Serve_since { get; set; }

        public Soldier() { }

        public Soldier( string name = "No Name",
            string surname = "No surname",
            string fathers_name = "No Fathers Name",
            string born = "born date",
            string rank = "rank",
            string position = "position",
            string platoon = "platoon",
            string service_since = "service")
        {

            Name = name;
            Surname = surname;
            Fathers_name = fathers_name;
            Born = born;
            Rank = rank;
            Position = position;
            Platoon = platoon;
            Serve_since = service_since;
        }
         
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Rank", Rank);
            info.AddValue("Name", Name);
            info.AddValue("Surname", Surname);
            info.AddValue("Fathers Name", Fathers_name);
            info.AddValue("Born", Born);
            info.AddValue("Service since", Serve_since);
            info.AddValue("Platoon", Platoon);
            info.AddValue("Position", Position);
        }

        public Soldier(SerializationInfo info, StreamingContext ctxt)
        {
           
            Rank =          (string)info.GetValue("rank", typeof(string));
            Name =          (string)info.GetValue("name", typeof(string));
            Surname =       (string)info.GetValue("surname", typeof(string));
            Fathers_name =  (string)info.GetValue("fathers_name", typeof(string));
            Born =          (string)info.GetValue("born", typeof(string));
            Serve_since =   (string)info.GetValue("service_since", typeof(string));
            Platoon =       (string)info.GetValue("platoon", typeof(string));
            Position =      (string)info.GetValue("position", typeof(string));
        }
    }
}

/*
 
     Animal bowser = new Animal("Bowser", 45, 25);
 
            // Serialize the object data to a file
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
 
            // Send the object data to the file
            bf.Serialize(stream, bowser);
            stream.Close();
 
            // Delete the bowser data
            bowser = null;

    ----------------------------------------------------------------
 
            // Read object data from the file
            stream = File.Open("AnimalData.dat", FileMode.Open);
            bf = new BinaryFormatter();
 
            bowser = (Animal)bf.Deserialize(stream);
            stream.Close();
 
            Console.WriteLine(bowser.ToString());
 
            // Change bowser to show changes were made
            bowser.Weight = 50;
 
            // XmlSerializer writes object data as XML
            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(@"C:\Users\derekbanas\C#Data\bowser.xml"))
            {
                serializer.Serialize(tw, bowser);
            }
 
            // Delete bowser data
            bowser = null;
 
            // Deserialize from XML to the object
            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"C:\Users\derekbanas\C#Data\bowser.xml");
            object obj = deserializer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close();
 
            Console.WriteLine(bowser.ToString());*/
