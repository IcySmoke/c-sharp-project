using c_sharp_project_for_school.Entity;
using System;
using System.Collections.Generic;
using System.IO;

public class CarRepository
{
    private string dataFilePath = "cars.txt";

    public List<Car> Load()
    {
        List<Car> cars = new List<Car>();

        if (File.Exists(dataFilePath))
        {
            string[] lines = File.ReadAllLines(dataFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                int id = int.Parse(parts[0]);
                string plate = parts[1];
                string brand = parts[2];
                string type = parts[3];
                int mileage = int.Parse(parts[4]);

                cars.Add(new Car(id, plate, brand, type, mileage));
            }
        }

        return cars;
    }

    public void Save(Car car)
    {
        using (StreamWriter writer = new StreamWriter(dataFilePath))
        {
            writer.WriteLine(car.Serialize());
        }
    }
}