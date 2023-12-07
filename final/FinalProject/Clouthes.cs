class Clothes : Item
{
    private String _size;
    private String _gander;

    public Clothes(string name, string description, int quantity, int minAmount, int curentPtice, Supplier supplier, String size, String gander) 
    : base(name, description, quantity, minAmount, curentPtice, supplier)
    {
        _size = size;
        _gander = gander;
    }

    public Clothes(string name, string description, int quantity, int minAmount, int curentPtice, List<int> historyPrice, Supplier supplier,  String size, String gander) 
    : base(name, description, quantity, minAmount, curentPtice, historyPrice, supplier)
    {
        _size = size;
        _gander = gander;
    }

    public Clothes(): base() {}

    public override Item GetInstance()
    {
        int i = 1;
        String name = "";
        String description = "";
        int quantity = 0;
        int minAmount = 0;
        int curentPtice = 0;
        String size = "";
        String gander = "";

        Console.Write("What is the name of your item? ");
        name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();

        Console.Write("What is the amount of items? ");
        quantity = int.Parse(Console.ReadLine());

        Console.Write("What is the min amount of items in the stock? ");
        minAmount = int.Parse(Console.ReadLine());

        Console.Write("What is the current price(UAH)? ");
        curentPtice = int.Parse(Console.ReadLine());

        Supplier supplier = Supplier.GetInstance();

        Console.Write("What is the size? ");
        size = Console.ReadLine();

        Console.Write("What is the gander? ");
        gander = Console.ReadLine();

        return new Clothes(name, description, quantity, minAmount, curentPtice, supplier, size, gander);
    }

        public override String DisplayFullInformation()
    {
        return $"Clothes Item name: {Name}, decription: {Description}, Quantity in the Stock: {Quantity}, Min Amount in thee stock {MinAmount}," + 
        $"Price {CurentPtice}, Size {_size}, Gander {_gander}, Supplier info:\n{Supplier.DisplayInformation()}";
    }

    public override string GetStringRepresentation()
    {
        return $"ClothesItem:{Name},{Description},{Quantity},{MinAmount},{CurentPtice},{toStringHistoryPrice(PriceHistory)},{_size},{_gander}|{Supplier.GetStringRepresentation()}";
    }
}
