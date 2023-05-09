namespace InventoryManagement 
{
    class program 
    {
        public static void Main(String[] args) 
        {
            string path = "C:\\Users\\USER LENOVO\\Documents\\LineComparisonDay8\\InventoryManagement\\InventoryManagement\\jsconfig1.json";
            ReadTheData readTheData = new ReadTheData();
            InventoryDetails data =readTheData.Read(path);

            Console.WriteLine(data.typeOfRice.name);
            Console.WriteLine(data.typeOfRice.weight);
            Console.WriteLine(data.typeOfRice.price);

        }
    }
}