class BuildingMaterial: Item 
{
    private String _category;

    public BuildingMaterial(string name, string description, int quantity, int minAmount, int curentPtice, Supplier supplier, String category) 
    : base(name, description, quantity, minAmount, curentPtice, supplier)
    {
        _category = category;
    }

        public BuildingMaterial(string name, string description, int quantity, int minAmount, int curentPtice, List<int> historyPrice, Supplier supplier, String category) 
    : base(name, description, quantity, minAmount, curentPtice, historyPrice, supplier)
    {
        _category = category;
    }

    public BuildingMaterial(): base() {}


    public override Item GetInstance()
    {
        String name = "";
        String description = "";
        int quantity = 0;
        int minAmount = 0;
        int curentPtice = 0;
        String category = "";

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

        Console.Write("What is the category? ");
        category = Console.ReadLine();

        return new BuildingMaterial(name, description, quantity, minAmount, curentPtice, supplier, category);
    }

    public override String DisplayFullInformation()
    {
        return $"BuildingMaterial Item name: {Name}, decription: {Description}, Quantity in the Stock: {Quantity}, Min Amount in thee stock {MinAmount}," + 
        $"Price {CurentPtice}, Category {_category}, Supplier info:\n{Supplier.DisplayInformation()}";
    }

    public override string GetStringRepresentation()
    {
        return $"BuildingMaterialItem:{Name},{Description},{Quantity},{MinAmount},{CurentPtice},{toStringHistoryPrice(PriceHistory)},{_category}|{Supplier.GetStringRepresentation()}";
    }
}
