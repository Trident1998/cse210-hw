using System.Reflection.Metadata;

abstract class Item 
{
    private String _name;
    private String _description;
    private int _quantity;
    private int _minAmount;
    private int _curentPtice;
    private List<int> _priceHistory;
    private Supplier _supplier;

    public string Description { get => _description; set => _description = value; }
    public int Quantity { get => _quantity; set => _quantity = value; }
    public string Name { get => _name; set => _name = value; }
    public int MinAmount { get => _minAmount; set => _minAmount = value; }
    public int CurentPtice { get => _curentPtice; set => _curentPtice = value; }
    public Supplier Supplier { get => _supplier; set => _supplier = value; }
    public List<int> PriceHistory { get => _priceHistory; set => _priceHistory = value; }

    public Item(String name,  String description, int quantity, int minAmount, int curentPtice, Supplier supplier)
    {
        Name = name;
        Description = description;
        Quantity = quantity;
        MinAmount = minAmount;
        CurentPtice = curentPtice;
        PriceHistory = new List<int> {curentPtice};
        Supplier = supplier;
    }

    public Item(String name,  String description, int quantity, int minAmount, int curentPtice, List<int> historyPrice, Supplier supplier)
    {
        Name = name;
        Description = description;
        Quantity = quantity;
        MinAmount = minAmount;
        CurentPtice = curentPtice;
        PriceHistory = historyPrice;
        Supplier = supplier;
    }

    public Item(){}

    public String DisplayShortInformation()
    {
        return $"{this.GetType()} Item name: {Name}, decription: {Description}, Quantity in the Stock: {Quantity}, Curent price: {CurentPtice}";
    }

    public void UpdateQuantity(int quantity, bool additionOperation) {
        _quantity = additionOperation ? _quantity += quantity : _quantity -= quantity;
    }

    public void DisplayPriceHistory() {
        int i = 1;
        PriceHistory.ForEach(it =>{
            Console.WriteLine($"{i}. {it}");
            i++;
        });
    }

    public void ChangePrice(int newPrice) {
        CurentPtice = newPrice;
        PriceHistory.Add(newPrice);
    }

    public abstract Item GetInstance();
    public abstract String DisplayFullInformation();
    public abstract String GetStringRepresentation();

    protected string toStringHistoryPrice(List<int> priceHistory)
    {
        return String.Join("_", priceHistory.ToArray());
    }
}