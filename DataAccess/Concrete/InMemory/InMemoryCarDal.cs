using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=123000, Description="Hyundai i10" },
                new Car{Id=2, BrandId=1, ColorId=3, ModelYear=2021, DailyPrice=128000, Description="Hyundai i30" },
                new Car{Id=3, BrandId=2, ColorId=2, ModelYear=2019, DailyPrice=183000, Description="Fiat Linea" },
                new Car{Id=4, BrandId=2, ColorId=2, ModelYear=2018, DailyPrice=155000, Description="Renault Clio" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetListById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }
        public Car GetSingleById(int id)
        {
            return _cars.SingleOrDefault(p => p.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            car.BrandId = carToUpdate.BrandId;
            car.ColorId = carToUpdate.ColorId;
            car.DailyPrice = carToUpdate.DailyPrice;
            car.Description = carToUpdate.Description;
            car.ModelYear = carToUpdate.ModelYear;
        }
    }
}
