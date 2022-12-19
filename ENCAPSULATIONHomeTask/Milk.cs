
   class Milk:Product
   {
    public double Volume;
    public double FatRat;
   
    public void GetProductInfo()
    {
        Console.WriteLine("Umumi Melumat");
        Console.WriteLine("Adı: "+Name);
        Console.WriteLine("Qiymeti: "+Price+"AZN");
        Console.WriteLine("Hecmi: "+Volume+"Litr");
        Console.WriteLine("Yaglılıq: "+FatRat+"%");
        Console.WriteLine(Count+"  Eded mehsul qalib");
        Console.WriteLine("Gunluk gelir: "+TotalIncome+"AZN");
    }
   }

