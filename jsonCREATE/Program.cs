using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace jsonCREATE
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            string JSONresult = JsonConvert.SerializeObject(emp);

            string path = @"C: \Users\remyg\Programming\API\JSONcreate\jsonCREATE\employee.json";

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
