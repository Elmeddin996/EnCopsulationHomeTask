
Product Mehsul = new Product();
Milk Sud=new Milk();    
Console.WriteLine("Mehsulun adini daxil edin");
Sud.Name = Console.ReadLine();
Console.WriteLine("Mehsulun qiymetini daxil edin");
Sud.Price = double.Parse(Console.ReadLine());
Console.WriteLine("Mehsulun hecmini daxil edin");
Sud.Volume = double.Parse(Console.ReadLine());
Console.WriteLine("Sudun yagliliq faizini daxil edin");
Sud.FatRat =  double.Parse(Console.ReadLine());
Sud.Count = 10;
Sud.Sell();
Sud.Sell();
Sud.Sell();
Sud.GetProductInfo();