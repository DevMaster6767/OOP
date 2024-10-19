using System;
namespace Mashina.Classes
{
    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public decimal Speed { get; set; }
        public int Year2 { get; set; }
        
        public void GetCarInfo(string Model, int Year, decimal Price, decimal Speed)
        {
            Console.WriteLine($"\nMashinaning modeli {Model}, \nmashinaning ishlab chiqarilgan yili {Year}, \nmashinaning narxi {Price}, \nmashinaning tezligi {Speed}");
        }
        
        public void CalculateDepreciation(int Year2, decimal Price)
        {
            decimal depreciationRate = 10;  
            for (int i = 0; i < Year2; i++)  
            {  
                Price -= Price * (depreciationRate/100);  
            }  
            
            Console.WriteLine($"\nYillik 10%lik kamayish qiymati {Price}");  
        }
    }
}