using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _cars;

        public CarManager(ICarDal cars)
        {
            _cars = cars;
        }

        public void Add(Car car)
        {
            //if (car.DailyPrice>0)
            //{
            //    _cars.Add(car);
            //    Console.WriteLine("Araç Eklendi");
            //}
            //else
            //{
            //    Console.WriteLine("Hata");
            //}
        }

        public List<Car> GetAll()
        {
            return _cars.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _cars.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _cars.GetAll(p => p.ColorId == id);
        }
    }
}
