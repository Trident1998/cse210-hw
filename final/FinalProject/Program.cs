using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        ItemHendler itemHendler = new ItemHendler();
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
            Console.WriteLine("  5. Save to file");
            Console.WriteLine("  6. Load from file");
            Console.WriteLine("  7. Quit");
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
                    Console.Write("Select an option from the menu: ");

                    choice = Console.ReadLine();
                    Console.WriteLine("The items are:");

                    switch(choice) 
                    {
                        case "1":
                            items.ForEach(item => {
                                Console.WriteLine($"{i}. {item.DisplayShortInformation()}");
                                i++;
                            });
                        break;

                        case "2":
                            items.ForEach(item => {
                                Console.WriteLine($"{i}. {item.DisplayFullInformation()}");
                                i++;
                            });
                        break;
                    }   
                    Console.WriteLine(); 
                break;

                case "3":
                    Console.WriteLine("Choose Item:");
                    items.ForEach(it => {
                        Console.WriteLine($"{i}. {it.DisplayShortInformation()}");
                        i++;
                    });
                    Console.WriteLine("What is your choose?");

                    int indeex = int.Parse(Console.ReadLine()) - 1;
                    item = items[indeex];
                    Inventory.UpdateItme(item);
                    Console.WriteLine("The Item is updated!\n");
                break;

                case "4":
                    items.ForEach(it => {
                        Console.WriteLine($"{i}. {it.DisplayShortInformation()}");
                        i++;
                    });
                    Console.WriteLine("Choose Item from the list above:");

                    indeex = int.Parse(Console.ReadLine()) - 1;
                    items.RemoveAt(indeex);
                    Console.WriteLine("The Item is deleted!\n");
                break;
                case "5":
                Console.Write("What is the file name for the item file? ");
                String fileName = Console.ReadLine();

                itemHendler.SaveFile(items, fileName);
                Console.WriteLine();
                break;

                case "6":
                Console.Write("What is the file name for the item file? ");
                String loadFileName = Console.ReadLine();
                
                List<Item> loadedItems = itemHendler.LoadFile(loadFileName);

                items = loadedItems;
                Console.WriteLine();
                break;
            }
        } while(choice != "7");   
    }
}