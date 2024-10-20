namespace Mashina.Classes
{
    class Program
    {
        static void Main(string[] args)  
        {
            Console.Write("Mashinaning minimum narxini kiriting=> ");
            decimal narx1= Convert.ToDecimal(Console.ReadLine());
            Console.Write("MashinaNing maximum narxini kiriting=> ");
            decimal narx2= Convert.ToDecimal(Console.ReadLine());
            List<Car>cars= new List<Car>
            {
                new Car("Model S", "Tesla", 79999),
                new Car("Civic", "Honda", 22000),
                new Car("Corolla", "Toyota", 20000),
                new Car("Mustang", "Ford", 27000),
                new Car("A4", "Audi", 35000)
            };

            Car car = new Car("", "", 0);
            car.Malumot(cars, narx1,narx2);
        }
    }
}

