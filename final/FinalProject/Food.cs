class Food : Item
{
    private String _bestBefore;
    
    public Food(string name, string description, int quantity, int minAmount, int curentPtice, Supplier supplier, String bestBefore) 
    : base(name, description, quantity, minAmount, curentPtice, supplier)
    {
        _bestBefore = bestBefore;
    }

    public Food(): base() {}

    public override Item GetInstance()
    {
        SupplierHendler _hendler = new SupplierHendler();
        int i = 1;
        String name = "";
        String description = "";
        int quantity = 0;
        int minAmount = 0;
        int curentPtice = 0;
        String bestBefore = "";
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

        Console.Write("What is the best before date? ");
        bestBefore = Console.ReadLine();

        return new Food(name, description, quantity, minAmount, curentPtice, supplier, bestBefore);
    }

    public override String DisplayFullInformation()
    {
        return $"Food Item name: {Name}, decriptin: {Description}, Quantity in the Stock: {Quantity}, Min Amount in thee stock {MinAmount}," + 
        $"Price {CurentPtice}, Supplier info {Supplier.DisplayInformation()}, Exp date {_bestBefore}";
    }
}