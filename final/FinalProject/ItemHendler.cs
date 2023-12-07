class ItemHendler
{
    public void SaveFile(List<Item> items, String fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            items.ForEach(item => {
            outputFile.WriteLine($"{item.GetStringRepresentation()}");
            });
        }
    }

    public List<Item> LoadFile(String fileName)
    {
        List<String> lines = new List<String>(System.IO.File.ReadAllLines(fileName));
        List<Item> items = new List<Item>();
        Supplier supplier = null;


        foreach (string line in lines)
        {
            string[] itemSubClass =  line.Split(':');
            string[] data = itemSubClass[1].Split("|");
            string[] itemInfo = data[0].Split(",");
            string[] supplierInfo = data[1].Split(",");


            switch(itemSubClass[0])
            {
                case "FoodItem":
                supplier = new Supplier(supplierInfo[0], supplierInfo[1], supplierInfo[2], supplierInfo[3]);

                String name = itemInfo[0];
                String description = itemInfo[1];
                int quantity = int.Parse(itemInfo[2]);
                int minAmount = int.Parse(itemInfo[3]);
                int curentPtice = int.Parse(itemInfo[4]);
                List<int> historyPrice = toHistoryPriceList(itemInfo[5]);
                String bestBefore = itemInfo[6];

                Food foodItem = new Food(name, description, quantity, minAmount, curentPtice, historyPrice, supplier, bestBefore);
                items.Add(foodItem);
                break;

                case "ClothesItem":
                supplier = new Supplier(supplierInfo[0], supplierInfo[1], supplierInfo[2], supplierInfo[3]);

                name = itemInfo[0];
                description = itemInfo[1];
                quantity = int.Parse(itemInfo[2]);
                minAmount = int.Parse(itemInfo[3]);
                curentPtice = int.Parse(itemInfo[4]);
                historyPrice = toHistoryPriceList(itemInfo[5]);
                string size = itemInfo[6];
                string gander = itemInfo[7];


                Clothes ClothesItem = new Clothes(name, description, quantity, minAmount, curentPtice, historyPrice, supplier, size, gander);
                items.Add(ClothesItem);
                break;

                case "BuildingMaterialItem":
                supplier = new Supplier(supplierInfo[0], supplierInfo[1], supplierInfo[2], supplierInfo[3]);

                name = itemInfo[0];
                description = itemInfo[1];
                quantity = int.Parse(itemInfo[2]);
                minAmount = int.Parse(itemInfo[3]);
                curentPtice = int.Parse(itemInfo[4]);
                historyPrice = toHistoryPriceList(itemInfo[5]);
                string category = itemInfo[6];


                BuildingMaterial buildingMaterialItem = new BuildingMaterial(name, description, quantity, minAmount, curentPtice, historyPrice, supplier, category);
                items.Add(buildingMaterialItem);
                break;              
            }
        }    

        return items;
    }


    private List<int> toHistoryPriceList(String str)
    {
        List<int> result = new List<int>();
        str.Split("_").ToList().ForEach(it => result.Add(int.Parse(it)));

        return result;
    }
}
