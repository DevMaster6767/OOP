namespace Kitob.Classes
{
    class Book
    {
        private string title;  
        private string author;  
        private decimal price;  
        private int publicationYear;  

        // Properties  
        public string Title  
        {  
            get { return title; } 
            set { title = value; } 
        }  

        public string Author  
        {  
            get { return author; }  
            set { author = value; }  
        }  

        public decimal Price  
        {  
            get { return price; }  
            set { price = value; }  
        }  

        public int PublicationYear  
        {  
            get { return publicationYear; }  
            set { publicationYear = value; }  
        }  

        public void DisplayInfo(string Title, string Author, decimal Price, int PublicationYear)  
        {  
            Console.WriteLine($"Kitob nomi: {Title}");  
            Console.WriteLine($"Kitob muallifi: {Author}");  
            Console.WriteLine($"Kitob narxi: {Price} Sum");  
            Console.WriteLine($"Nashr qilingan yil: {PublicationYear}");  
        }  

        public void ApplyDiscount(decimal discountPercentage, decimal Price)  
        {  
            if (discountPercentage < 0 || discountPercentage > 100)  
            {  
                Console.WriteLine("Noto'g'ri chegirma foizi.");  
                return;  
            }  
            Price -= Price * (discountPercentage / 100);  
            Console.WriteLine($"Chegirmada {discountPercentage}% dan keyin narx: {Price} Sum");  
        }  
    }
}