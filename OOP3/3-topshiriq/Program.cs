namespace Boxer.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Boxers>boxers=new List<Boxers>
            {
                new Boxers("Nusratov", "Jahongir",23, 48),
                new Boxers("Ochilov", "Vohid",20, 45),
                new Boxers("Narziyev", "Miromon",28, 55),
                new Boxers("To'xtasinov", "Alisher",18, 77),
                new Boxers("Keldiyorov", "Dilshodbek",21, 95),
                new Boxers("Muxsinov", "Quysin",30, 100),
                new Boxers("Allayorov", "Jasur",27, 67),
                new Boxers("Bozorov", "Bozor",23, 98),
                new Boxers("Chorshanbiyev", "Jaloliddin",32, 58),
                new Boxers("Rustamov", "Ilyos",29, 45)
            };

            Boxers box=new Boxers(" ", " ",0,0);
            box.Saralash(boxers);
        }
    }
}

