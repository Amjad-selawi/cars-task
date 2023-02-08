using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    /// <summary>
    /// This is An Implementation for Filter Design Pattern in C#,
    /// this is the abstract class that are base class for all other filters
    /// </summary>
    internal abstract class CarFilter
    {
        public abstract List<Car> doFilter(List<Car> cars);
    }
    /// <summary>
    /// subclass of CarFilter class, this Class filters cars list by equaling make name strings
    /// </summary>
    class CarMakeFilter : CarFilter
    {
        public CarMakeFilter(string make_name)
        {
            this.make_name = make_name;
        }

        public string make_name { get; set; }

        public override List<Car> doFilter(List<Car> cars)
        {
            return cars.Where(car => car.Make.Equals(this.make_name)).ToList();
        }
    }
    /// <summary>
    /// subclass of CarFilter class, this Class filters cars list by range of Horse power values
    /// </summary>
    class CarHorsePowerFilter : CarFilter
    {
        public int min_value { get; set; }
        public int max_value { get; set; } = int.MaxValue;
        public CarHorsePowerFilter(int min_value)
        {
            this.min_value = min_value;
        }

        public CarHorsePowerFilter(int min_value, int max_value)
        {
            this.min_value = min_value;
            this.max_value = max_value;
        }

        public override List<Car> doFilter(List<Car> cars)
        {
            return cars.Where(car => car.HorsePower>= min_value && car.HorsePower<=max_value).ToList();
        }

    }
    /// <summary>
    /// subclass of CarFilter class, this Class filters cars list by range of price values
    /// </summary>
    class CarPriceFilter : CarFilter
    {
        public double min_value { get; set; }
        public double max_value { get; set; } = double.MaxValue;

        public CarPriceFilter(double min_value)
        {
            this.min_value = min_value;
        }
        public CarPriceFilter(double min_value, double max_value)
        {
            this.min_value = min_value;
            this.max_value = max_value;
        }

        public override List<Car> doFilter(List<Car> cars)
        {
            return cars.Where(car => car.price >= min_value && car.price <= max_value).ToList();
        }
    }
    /// <summary>
    /// subclass of CarFilter class, this Class filters cars list by equaling the NumberofClyinders value
    /// </summary>
    class CarNumberOfClyindersFilter : CarFilter
    {
        public string NumberOfClyinders { get; set; }
        public CarNumberOfClyindersFilter(string numberOfClyinders)
        {
            this.NumberOfClyinders = numberOfClyinders;
        }
        public override List<Car> doFilter(List<Car> cars)
        {
            return cars.Where(car => car.NumberOfCylinders.Equals(this.NumberOfClyinders)).ToList();
        }
    }
    /// <summary>
    /// subclass of CarFilter class, this Class filters cars list by equaling the NumberofDoors value
    /// </summary>
    class CarNumberOfDoorsFilter : CarFilter
    {
        public string NumDoors { get; set; }
        public CarNumberOfDoorsFilter(string NumDoors)
        {
            this.NumDoors = NumDoors;
        }
        public override List<Car> doFilter(List<Car> cars)
        {
            return cars.Where(car => car.NumberOfDoors.Equals(this.NumDoors)).ToList();
        }
    }
    
}
