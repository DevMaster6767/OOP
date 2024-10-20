namespace Boxer.Classes
{
    public class Boxers
    {
        public int Id { get; set; }
        public string Familiya { get; set; }
        public string Ism { get; set; }
        public int Yoshi { get; set; }
        public decimal Vazn { get; set; }

        public Boxers(string ism, string familya, int yosh, decimal vazn )
        {
            Ism=ism;
            Familiya=familya;
            Yoshi=yosh;
            Vazn=vazn;
        }

        public void Saralash(List<Boxers> boxers)
        {
            Console.WriteLine("\nYengil vaznli boxchilar:");
            foreach (var boxer in boxers)  
            {                
                if(boxer.Vazn<50)
                {            
                    Console.WriteLine($"Ismi: {boxer.Ism}, Familyasi: {boxer.Familiya}, Yoshi: {boxer.Yoshi}, Vazni: {boxer.Vazn}");
                }
            }

            Console.WriteLine("\nO'rtacha vaznli boxchilar:");
            foreach (var boxer in boxers)
            {
                if (boxer.Vazn>=50 && boxer.Vazn<90)
                {                  
                    Console.WriteLine($"Ismi: {boxer.Ism}, Familyasi: {boxer.Familiya}, Yoshi: {boxer.Yoshi}, Vazni: {boxer.Vazn}");
                }
            }

            Console.WriteLine("\nOg'ir vaznli boxchilar:");
            foreach (var boxer in boxers)
            {
                if (boxer.Vazn>90)
                {                 
                    Console.WriteLine($"Ismi: {boxer.Ism}, Familyasi: {boxer.Familiya}, Yoshi: {boxer.Yoshi}, Vazni: {boxer.Vazn}");
                }
            }

        }
    }  
}