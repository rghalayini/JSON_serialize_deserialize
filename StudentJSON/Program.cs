using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Nancy.Json;
using System.Reflection;

namespace StudentJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();

            string JSONresult = JsonConvert.SerializeObject(stud);

            string path = @"C: \Users\remyg\Programming\API\JSONcreate\studentJSON\student.json";

            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }


            //to read the file in the program:
            string pathJSONtoRead = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"C: \Users\remyg\Programming\API\JSONcreate\studentJSON\studentList.json");
            string[] file = File.ReadAllLines(pathJSONtoRead);
            //var file = @"{ ""Name"":""Julie Andrews"",""Class"":5,""Subject"":[""Math"",""Biology"",""French""],""RollNumber"":123456}";


            var DeserializedJSON = new JavaScriptSerializer().Deserialize<Student>(file[0]);

            Console.WriteLine(DeserializedJSON.Name);
            Console.WriteLine(DeserializedJSON.Class);
        }
    }
}
