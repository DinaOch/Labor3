using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ллаба_3
{
    public class Repair<T, U> where T : Entity where U : Entity
    {
        private T master;
        private U car;

        public Repair(T master, U car)
        {
            this.master = master;
            this.car = car;
        }

        public void DoRepair()
        {
            Console.WriteLine($"Мастер {master.Name} отремонтировал автомобиль номер {car.Name}");
            Console.WriteLine("www.example.com");
        }
    }
}
