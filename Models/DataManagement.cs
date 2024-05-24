using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StayOS.Models.Data
{
    public class DataManagement
    {
        public static void SendData(string json, string Location)
        {
            File.WriteAllText(Location, json);
        }

        public static string GetData(string Location)
        {
            return File.ReadAllText(Location);
        }
    }
}