using OOPDeneme;

internal class Program
{
    //insan isimli bir sınıf içinde boy kilo ve yaş alanlarını tanımlayıp,
    //bir kurucu metot içinde bu alanlar için varsayılan değer atamaları yapacağız 
    //Son olarak "Tanis" isimli metot ile girilen bilgileri kullanıcıya belirli 
    //Açıklayıcı bir şekilde görüntüleyen bir program yazınız.
    private static void Main(string[] args)
    {
        int kkilo=0;
        int kyas = 0;
        int kboy = 0;
        string kad="";
        string ksoyad = "";
        Console.WriteLine("Adınızı girinz:");
        kad = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Soyadınızı girinz:");
        ksoyad = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Kilonuzu girinz:" );
        kkilo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Yaşınızı girinz:");
        kyas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Boyunuzu girinz:");
        kboy = Convert.ToInt32(Console.ReadLine());

        

        new clsOzellik(kkilo,kyas,kboy,kad,ksoyad);


    }
}