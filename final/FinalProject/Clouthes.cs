class Clouthes : Item
{
    private String _size;
    private String _gander;

    public Clouthes(string name, string description, int quantity, int minAmount, int curentPtice, Supplier supplier, String size, String gander) 
    : base(name, description, quantity, minAmount, curentPtice, supplier)
    {
        _size = size;
        _gander = gander;
    }

    public Clouthes(): base() {}

    public override Item GetInstance()
    {
        SupplierHendler _hendler = new SupplierHendler();
        int i = 1;
        String name = "";
        String description = "";
        int quantity = 0;
        int minAmount = 0;
        int curentPtice = 0;
        String size = "";
        String gander = "";
        Supplier supplier = new Supplier();

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

        // Console.Write("What is the supplier number? ");
        // List<Supplier> suppliers = _hendler.Load();
        // suppliers.ForEach(it => {
        //     Console.WriteLine($"{i}. {it.DisplayInformation()}");
        //     i++;
        // });
        // int index = int.Parse(Console.ReadLine());
        // supplier = suppliers[index];

        Console.Write("What is the size? ");
        size = Console.ReadLine();

        Console.Write("What is the gander? ");
        gander = Console.ReadLine();

        return new Clouthes(name, description, quantity, minAmount, curentPtice, supplier, size, gander);
    }

        public override String DisplayFullInformation()
    {
        return $"Food Item name: {Name}, decriptin: {Description}, Quantity in the Stock: {Quantity}, Min Amount in thee stock {MinAmount}," + 
        $"Price {CurentPtice}, Supplier info {Supplier.DisplayInformation()}, Size {_size}, Gander {_gander}";
    }
}