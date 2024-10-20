using System;  
using System.Collections.Generic;  

namespace Student.Classes  
{  
    public enum Baholar  
    {  
        A = 5,  
        B = 4,  
        C = 3,  
        D = 2  
    }  

    public class Oquvchi  
    {  
        public Guid Id { get; set; }
        public string Ism { get; set; }  
        public string Familyasi { get; set; }  
        public int Sinfi { get; set; }  
        public Baholar Bahosi { get; set; }  

        public Oquvchi(string ism, string familyasi, int sinf, Baholar bahosi)  
        {  
            Id = Guid.NewGuid();
            Ism = ism;  
            Familyasi = familyasi;  
            Sinfi = sinf;  
            Bahosi = bahosi;  
        }  

        public static void Ruyxat(List<Oquvchi> oquvchilar, Baholar baho)  
        {  
            foreach (var oquvchi in oquvchilar)  
            {  
                if (baho == oquvchi.Bahosi)  
                {  
                    Console.WriteLine($"Ism: {oquvchi.Ism}, Familya: {oquvchi.Familyasi}, Sinfi: {oquvchi.Sinfi}, Bahosi: {oquvchi.Bahosi}");  
                }  
            }  
        }  
    } 
}