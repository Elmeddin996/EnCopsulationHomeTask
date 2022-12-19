
class Product
{
    private string _name;
    private  int _count ;
    private double _price;
    private double _totalIncome;



    public string Name
    {
        get => _name;

        set
        {
            if ( value.Length <=1)
            {
                Console.WriteLine("Duzgun ad daxil edin");
            }
            else
            {
                _name = value;
            }
        }
    }

    public int Count
    {
        get => _count;
        
        set
        {
            if (value>=1)
            {
                _count = value;
            }
            else
            {
                Console.WriteLine("Stokda yeteri qeder mehsul qalmayib!");
            }
        }

    }

    public  double Price
    {
        get => _price;

        set
        {
            if (value<1)
            {
                Console.WriteLine("Duzgun qiymet daxil edin!");
            }
            else
            {
                _price=value;
            }

        }
    }

    public double TotalIncome
    {
        get => _totalIncome;

    }

    public void Sell()
    {
        if (Name.Length>1)
        {
         if (_count != 0)
         { 
           _count--;
            _totalIncome += _price;
         }   
         else
         {
                Console.WriteLine("Stokda yeteri qeder mehsul qalmayib!");       
         }
        }
        else
        {
            Console.WriteLine("Duzgun ad daxil edin!");
        }   
    }
}







