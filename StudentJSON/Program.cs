using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

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
        }
    }
}
