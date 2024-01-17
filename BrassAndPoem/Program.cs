
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new()
{
    new Product
    {
        Name = "Trumpet",
        Price = 150.99m,
        ProductTypeId = 1
    },

    new Product
    {
        Name = "Trombone",
        Price = 246.99m,
        ProductTypeId = 1
    },

    new Product
    {
        Name = "Tuba",
        Price = 1250.99m,
        ProductTypeId = 1
    },

    new Product
    {
        Name = "Ozymandias",
        Price = 12350.99m,
        ProductTypeId = 2
    },

    new Product
    {
        Name = "Leaves of Grass",
        Price = 15650.99m,
        ProductTypeId = 2
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new()
{
    new ProductType
    {
        Id = 1,
        Title = "Brass"
    },
    new ProductType
    {
        Id = 2,
        Title = "Poem"
    }

};

//put your greeting here
string greeting = "\n\n\n\n\t\t\t\t\t ~~ Welcome to Brass & Poem! ~~\n";

//implement your loop here

string menuChoice = null;

while (menuChoice != "0")
{
    DisplayMenu();
    menuChoice = Console.ReadLine();

    switch (menuChoice)
    {
        case "1":
            DisplayAllProducts(products, productTypes);
            break;

        case "2":
            DeleteProduct(products, productTypes);
            break;

        case "3":
            AddProduct(products, productTypes);
            break;

        case "4":
            UpdateProduct(products, productTypes);
            break;

        case "5":
            Environment.Exit(0);
            break;

        default:
            Console.Write("\n\tYour selection is invalid, please try again. Press Enter to continue...");
            Console.ReadLine();
            break;
    }
}


string GetProductTypeName(int productTypeId, List<ProductType> productTypes)
{
    ProductType productType = productTypes.Find(pt => pt.Id == productTypeId);
    return productType != null ? productType.Title : "Unknown";
}

void DisplayMenu()
{
    Console.Clear();
    Console.WriteLine(greeting);
    Console.WriteLine("\n\t\t\t1. Display All Products");
    Console.WriteLine("\n\t\t\t2. Delete A Product");
    Console.WriteLine("\n\t\t\t3. Add A Product");
    Console.WriteLine("\n\t\t\t4. Update A Product");
    Console.WriteLine("\n\t\t\t5. Exit");
    Console.Write("\n\n\t\t\tMake your selection: ");
}


void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.Clear();
    int index = 1;
    Console.WriteLine("\n\n\n\n");
    foreach (Product product in products)
    {
        Console.WriteLine($"\n\t\t\t{index++}. {product.Name}   Price: ${product.Price}   Product Type: {GetProductTypeName(product.ProductTypeId, productTypes)}");
    }
    Console.Write("\n\n\t\t\t\tPress Enter to continue...");
    Console.ReadLine();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.Clear();
    int index = 1;
    Console.WriteLine("\n\n\n\n");
    foreach (Product product in products)
    {
        Console.WriteLine($"\n\t\t\t{index++}. {product.Name}   Price: ${product.Price}   Product Type: {GetProductTypeName(product.ProductTypeId, productTypes)}");
    }

    Console.Write("\n\n\t\t\tSelect the number of the product you wish to delete:  ");
    int deleteChoice = Convert.ToInt32(Console.ReadLine());

    products.RemoveAt(deleteChoice - 1);
    Console.Clear();
    Console.Write("\n\n\t\t\t\tProduct deleted! Press Enter to continue...");
    Console.ReadLine();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    int index = 1;
    Console.Clear();
    Console.Write("\n\n\t\t\tEnter the name of the product you're adding:  ");
    string name = Console.ReadLine();

    Console.Clear();
    Console.Write("\n\n\t\t\tEnter the price of the product you're adding (ex - 150.00) :  ");
    decimal price = Convert.ToDecimal(Console.ReadLine());
    Console.Clear();

    foreach (ProductType productType in productTypes)
    {
        Console.WriteLine($"\n\t\t\t{index++}. {productType.Title}");
    }
    Console.Write("\n\n\t\t\tSelect the product type # of the new product:  ");
    int productTypeId = Convert.ToInt32(Console.ReadLine());

    Product newProduct = new()
    {
        Name = name,
        Price = price,
        ProductTypeId = productTypeId
    };

    products.Add(newProduct);
    Console.Clear();
    Console.Write("\n\n\t\t\tNew product successfully added! Press Enter to continue...");
    Console.ReadLine();
};

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}


// don't move or change this!
public partial class Program { }