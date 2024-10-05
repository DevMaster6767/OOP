using Kitob.Classes;
class Program  
{  
    static void Main(string[] args)  
    {  
        Book myBook = new Book();  
        Console.Write("Kitobning nomini keriting=>");
        string Kitob_nomi=Console.ReadLine();
        Console.Write("Kitobning muallifini keriting=>");
        string Kitob_muallifi=Console.ReadLine();
        Console.Write("Kitobning narxini keriting=>");
        decimal Kitob_narxi=Convert.ToDecimal(Console.ReadLine());
        Console.Write("Kitobning nashr qilingan sanasini keriting=>");
        int Kitob_yili=Convert.ToInt32(Console.ReadLine());
        Console.Write("Kitob chigirma foizini keriting=>");
        int Chigirma=Convert.ToInt32(Console.ReadLine());

        myBook.DisplayInfo(Kitob_nomi,Kitob_muallifi, Kitob_narxi, Kitob_yili);  

        myBook.ApplyDiscount(Chigirma, Kitob_narxi);  
    }  
}