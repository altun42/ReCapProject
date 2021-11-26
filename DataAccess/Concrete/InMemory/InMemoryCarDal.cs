using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id = 1, BrandId = "Ford", ColorId = "Beyaz", DailyPrice = 250, Description = "Otomatik Fitesli", ModelYear = 2019  },
                new Car{Id = 2, BrandId = "Ford", ColorId = "Kırmızı", DailyPrice = 220, Description = "Manuel Fitesli", ModelYear = 2010  },
                new Car{Id = 3, BrandId = "Mercedes", ColorId = "Siyah", DailyPrice = 360, Description = "Otomatik Fitesli", ModelYear = 2016  },
                new Car{Id = 4, BrandId = "BMW", ColorId = "Mavi", DailyPrice = 400, Description = "Otomatik Fitesli", ModelYear = 2018  },
                new Car{Id = 5, BrandId = "Renault", ColorId = "Beyaz", DailyPrice = 150, Description = "Manuel Fitesli", ModelYear = 2005  },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=> c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Id = car.Id;    
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
