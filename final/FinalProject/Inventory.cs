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

    public void RemoveItem()
    {

    }

    public Item UpdateItme()
    {
        return new Food();
    }
}