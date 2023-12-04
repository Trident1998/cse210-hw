class Inventory
{
    public static Item CreateItem()
    {
        String choice = "";
        Console.WriteLine("The types of Items are:");
        Console.WriteLine("  1. Food");
        Console.WriteLine("  2. Clouthes");
        Console.WriteLine("  3. Building Material");
        Console.Write("Which type of item would you like to create? ");

        choice = Console.ReadLine();

        switch(choice) 
        {
            case "1":
            Item food = new Food().GetInstance();
            return food;

            case "2":
            Item clouthes = new Clouthes().GetInstance();
            return clouthes;

            case "3":
            Item material = new BuildingMaterial().GetInstance();
            return material;
        }

        return null;
    }

    public static void UpdateItme(Item item)
    {
        String choice = "";
        Console.WriteLine("Choose the action:");
        Console.WriteLine("  1. Update quantity");
        Console.WriteLine("  2. Update price");
        Console.WriteLine("  3. Show the price history");
        Console.Write("Which type of action would you like to choose? ");

        choice = Console.ReadLine();

        switch(choice) 
        {
            case "1":
                item.Quantity = int.Parse(Console.ReadLine());
            break;
                
            case "2":
                int newPrice = int.Parse(Console.ReadLine());
                item.ChangePrice(newPrice);
            break;

            case "3":
                item.DisplayPriceHistory();
            break;
        }   
    }
}