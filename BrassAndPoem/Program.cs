
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new()
{
    new Product
    {
        Name = "God of War: Ragnarok",
        Price = 49.99m,
        ProductTypeId = 1
    },

    new Product
    {
        Name = "Playstation 5",
        Price = 450.00m,
        ProductTypeId = 2
    },

    new Product
    {
        Name = "Baldur's Gate 3",
        Price = 59.99m,
        ProductTypeId = 1
    },

    new Product
    {
        Name = "Gaming PC",
        Price = 1700.00m,
        ProductTypeId = 2
    },

    new Product
    {
        Name = "Yakuza 0",
        Price = 39.99m,
        ProductTypeId = 1
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new()
{
    new ProductType
    {
        Id = 1,
        Title = "Games"
    },
    new ProductType
    {
        Id = 2,
        Title = "Consoles"
    }

};

//put your greeting here
string greeting = "\n\t\t\t ~~ Welcome to Brass & Poem! ~~\n";

//implement your loop here
DisplayMenu();
string menuChoice = Console.ReadLine();

switch (menuChoice)
{
    case "1":
        DisplayAllProducts(products, productTypes);
        break;

    case "2":
        throw new NotImplementedException("Delete a product");
        break;

    case "3":
        throw new NotImplementedException("Add a product");
        break;

    case "4":
        throw new NotImplementedException("Update a product");
        break;

    case "5":
        Console.Write("Goodbye!");
        Environment.Exit(0);
        break;
}


void DisplayMenu()
{
    Console.WriteLine(greeting);
    Console.WriteLine("\n\t\t1. Display All Products");
    Console.WriteLine("\n\t\t2. Delete A Product");
    Console.WriteLine("\n\t\t3. Add A Product");
    Console.WriteLine("\n\t\t4. Update A Product");
    Console.WriteLine("\n\t\t5. Exit");
    Console.Write("\n\n\t\tMake your selection: ");
}

string GetProductTypeName(int productTypeId, List<ProductType> productTypes)
{
    ProductType productType = productTypes.Find(pt => pt.Id == productTypeId);
    return productType != null ? productType.Title : "Unknown";
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    int index = 1;
    foreach (Product product in products)
    {
        Console.WriteLine($"\n\t{index++}. {product.Name}   Price: ${product.Price}   Product Type:{GetProductTypeName(product.ProductTypeId, productTypes)}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}


// don't move or change this!
public partial class Program { }