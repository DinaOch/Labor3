using Ллаба_3;

class Program
{
    static void Main(string[] args)
    {
        Master master = new Master("Иванов Иван Иванович");
        Car car = new Car("А123БВ");

        Repair<Master, Car> repair = new Repair<Master, Car>(master, car);
        repair.DoRepair();
    }
}