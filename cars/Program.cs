using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cars
{
    internal class Program
    {
        public static List<Car> _cars = new List<Car>();
        static void Main(string[] args)
        {
            // Load Data For First Time
            LoadCarsData();
            // Try Loading it Again
            LoadCarsData();
            // Filter Data By Price Range
            CarPriceFilter filter = new CarPriceFilter(100, 22625);
            var filtered_cars =Filter(filter);
            printList(filtered_cars);

            Console.ReadKey();
        
        }
        public static void LoadCarsData()
        {
            String filePath = @"C:\Users\amjad\OneDrive\Desktop\autos.csv";
            if (_cars.Count == 0)
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        var data_record = line.Split(',');
                        Car car = new Car
                        {
                            Make = data_record[0],
                            NumberOfDoors = data_record[1],
                            BodyStyle = data_record[2],
                            EngineLocation = data_record[3],
                            NumberOfCylinders = data_record[4],
                            HorsePower = int.TryParse(data_record[5], out int horse_power) ? horse_power : 0,
                            price = double.TryParse(data_record[6], out double price) ? price : 0,
                        };
                        _cars.Add(car);
                    }
                }
            } else
            {
                Console.WriteLine("ALready Loaded");
            }

               
            
          
        }
        /// <summary>
        /// Performs Filtering to loaded cars data and returns the filtering result
        /// </summary
        public static List<Car> Filter(CarFilter filter)
        {
            return filter.doFilter(_cars);
        }
        /// <summary>
        /// Prints Car List items to Console
        /// </summary>
        public static  void printList(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            
        }
    }
}
        
    

