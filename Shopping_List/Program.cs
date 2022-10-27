using System.Linq;


using System.Linq;

Dictionary<string, decimal> store = new Dictionary<string, decimal>()
{
    
    //Key     Values
    {"Bread", 2.99m},
    {"Beer", 12.99m},
    {"Oreos", 3.99m },
    {"Frozen Pizza", 5.99m},
    {"Cereal", 4.99m },
    {"Apples", 1.99m},
    {"Broccoli", 5.99m },
    {"Hot Dogs", 5.99m}
};

foreach(KeyValuePair<string, decimal> item in store)
{
    Console.WriteLine(item);
}

List<string> shoppingList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add item to cart: ");
        string addToCart = Console.ReadLine();
        shoppingList.Add(addToCart.ToLower());

        foreach (var addedItem in shoppingList)
        {
            if (!store.ContainsKey(addedItem))
            {

                Console.WriteLine($"You added: {addedItem}");
            }
            else if (store.ContainsKey(addedItem))
            {
                Console.WriteLine("We don't carry that.");
            }

        }
        

        Console.WriteLine("Do you want to add another item to your cart?");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "yes")
        {
            continue;
        }
        else if (answer.ToLower() == "no")
        {
            break;
        }

    }



    /*
     No idea how to take items in my addItem and grab the Value of them from the Dictionary. 
     I am going to assume Linq by searching addItem in items. But everything I tired just kept throwing an error.
     
    I know finalList.Sum() is how I get the totatl but not sure how to make sure it adding up my just items in the cart

    */
