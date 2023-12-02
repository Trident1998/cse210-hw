using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        SupplierHendler supplierHendler = new SupplierHendler();
        Inventory inventory = new Inventory();
        Report report = new Report();
        List<Item> items = new List<Item>();
        String choice = "";

        do
        {
            int i = 1;

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Item");
            Console.WriteLine("  2. List Items");
            Console.WriteLine("  3. Update Item");
            Console.WriteLine("  4. Delete Item");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            switch(choice) 
            {
                case "1":
                    Item item = Inventory.CreateItem();
                    items.Add(item);
                break;

                case "2":

                    Console.WriteLine("What type of informatin would you like to see? ");
                    Console.WriteLine("  1. Short information");
                    Console.WriteLine("  2. Full information");
                    Console.Write("Select a choice from the menu: ");

                    choice = Console.ReadLine();
                    Console.WriteLine("The items are:");

                    switch(choice) 
                    {
                        case "1":
                            items.ForEach(item => {
                                Console.WriteLine($"{i}. {item.DisplayShortInformation()}");
                                i++;
                            });
                            Console.WriteLine();
                        break;

                        case "2":
                            items.ForEach(item => {
                                Console.WriteLine($"{i}. {item.DisplayFullInformation()}");
                                i++;
                            });
                            Console.WriteLine(); 
                        break;
                    }   
                break;
            }
        } while(choice != "6");   
    }
}