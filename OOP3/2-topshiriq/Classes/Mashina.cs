namespace Mashina.Classes
{
    public class Car
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public Car(string name, string brand, decimal price)
        {
            Name=name;
            Brand=brand;
            Price=price;
        }

        public void Malumot(List<Car> cars, decimal narx1, decimal narx2)
        {
            int k=0;
            foreach (var car in cars)  
            {  
                if (narx1 <= car.Price && car.Price<= narx2 )  
                {                     
                    Console.WriteLine($"\nNomi: {car.Name}, Brandi: {car.Brand}, Narxi: {car.Price}");  
                    k=k+1;                   
                }
                              
            } 
            if (k==0)
            {
                Console.WriteLine("Bunday narx oraliqda mashin yuq");
            } 
        }
    }   
}