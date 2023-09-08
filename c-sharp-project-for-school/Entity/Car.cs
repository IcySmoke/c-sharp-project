using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_project_for_school.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Mileage { get; set; }

        public Car(int id, string plate, string brand, string type, int mileage)
        {
            Id = id;
            Plate = plate;
            Brand = brand;
            Type = type;
            Mileage = mileage;
        }

        public string Serialize()
        {
            return $"{Id},{Plate},{Brand},{Type},{Mileage}";
        }
    }
}
