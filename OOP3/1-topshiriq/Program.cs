 
namespace Student.Classes
{
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Console.Write("Baho kiriting (A, B, C, D)=> ");  
            string baho = Console.ReadLine();  

            List<Oquvchi> oquvchilar = new List<Oquvchi>  
            {  
                new Oquvchi("Go'zal", "Melikova", 10, Baholar.A),  
                new Oquvchi("Damer", "Ochilov", 9, Baholar.B),  
                new Oquvchi("Bobur", "Ruziev", 8, Baholar.C),  
                new Oquvchi("Samira", "Iminova", 11, Baholar.A),
                new Oquvchi("Dilbar", "Nazarova", 7, Baholar.D),  
                new Oquvchi("Gulasal", "Shodiyeva", 10, Baholar.B),  
                new Oquvchi("Yahyo", "Muminov", 11, Baholar.C),  
                new Oquvchi("Madina", "Tuychiyeva", 9, Baholar.D),
                new Oquvchi("Gulirano", "Davlatova", 10, Baholar.A),  
                new Oquvchi("Yulchiboy", "Yulchiyev", 11, Baholar.B),  
                new Oquvchi("Bozor", "Bozorboyev", 8, Baholar.C),  
                new Oquvchi("Dildora", "Ixtiyorova", 7, Baholar.B)  
            };  

            if (Enum.TryParse(baho, true, out Baholar kiritilganBaho))  
            {                  
                Oquvchi.Ruyxat(oquvchilar, kiritilganBaho);  
            }  
            else  
            {  
                Console.WriteLine("Noto'g'ri baho kiritildi.");  
            }  
        }  
    }  
}
