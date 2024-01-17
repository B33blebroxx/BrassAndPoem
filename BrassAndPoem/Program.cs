
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

//implement your loop here

void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
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