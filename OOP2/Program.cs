using Mashina.Classes;

namespace Car_information
{
    class Program
    {
        static void Main()
        {
            Car myCar = new Car();
            Console.Write("Mashinaning modelini kiriting=> ");
            string model= Console.ReadLine();

            Console.Write("\nMashinaning ishlab chiqarilgan yilini kiriting=> ");
            int year= Convert.ToInt32(Console.ReadLine());

            Console.Write("\nMashinaning narxini kiriting=> ");
            decimal price= Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nMashinaning tezligi kiriting=> ");
            decimal speed= Convert.ToDecimal(Console.ReadLine());

            myCar.GetCarInfo(model,year,price,speed);

            Console.Write("\nMashina yaratilgan keyin necha yil o'tganini kiriting=> ");
            int year2=Convert.ToInt32(Console.ReadLine());
            myCar.CalculateDepreciation( year2, price);
        }
    }
}