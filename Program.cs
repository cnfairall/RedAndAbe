List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Skele-Gro",
        Price = 10.00M,
        Available = true,
        ProductTypeId = 0
    },

    new Product()
    {
        Name = "Truth Serum",
        Price = 8.00M,
        Available = true,
        ProductTypeId = 0
    },

    new Product()
    {
        Name = "Unicorn Hair Wand",
        Price = 15.00M,
        Available = true,
        ProductTypeId = 3
    },

    new Product()
    {
        Name = "Pheonix Feather Wand",
        Price = 20.00M,
        Available = true,
        ProductTypeId = 3
    },

    new Product()
    {
        Name = "Elder Tree Wand",
        Price = 50.00M,
        Available = false,
        ProductTypeId = 3
    },

    new Product()
    {
        Name = "Plain Dress Robes",
        Price = 8.00M,
        Available = true,
        ProductTypeId = 1
    },

    new Product()
    {
        Name = "Fancy Dress Robes",
        Price = 10.00M,
        Available = true,
        ProductTypeId = 1
    },

    new Product()
    {
        Name = "Quidditch World Cup scarf",
        Price = 8.00M,
        Available = true,
        ProductTypeId = 1
    },

    new Product()
    {
        Name = "Sorcerer's Stone",
        Price = 500.00M,
        Available = false,
        ProductTypeId = 2
    },

    new Product()
    {
        Name = "Time Turner",
        Price = 50.00M,
        Available = true,
        ProductTypeId = 2
    },

    new Product()
    {
        Name = "Pensieve",
        Price = 100.00M,
        Available = true,
        ProductTypeId = 2
    }
};

List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Name = "Potions",
        Id = 0
    },

    new ProductType()
    {
       Name = "Apparel",
       Id = 1
    },

     new ProductType()
    {
       Name = "Enchanted Objects",
       Id = 2
    },

      new ProductType()
    {
       Name = "Wands",
       Id = 3
    }
};

string greeting = @"Welcome to Reductio & Absurdem!
Your one-stop shop for all magical needs";

Console.WriteLine(greeting);


string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Choose an option:
        0. Exit
        1. View All Products
        2. Add a Product
        3. Delete a Product
        4. Update Product Details
        5. View Products by Product Type");

    choice = Console.ReadLine();
    if (choice == "0")
    {
        Console.WriteLine("Goodbye!");
    }
    else if (choice == "1")
    {
        ListProducts();
    }
    else if (choice == "2")
    {
        AddProduct();
    }
    else if (choice == "3")
    {
        DeleteProduct();
    }
    else if (choice == "4")
    {
        UpdateProduct();
    }
    else if (choice == "5")
    {
        FilterByType();
    }
}

void ListProducts()
{
    Console.WriteLine("Products:");

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }

    Product chosenProduct = null;

    while (chosenProduct == null)
    {
        Console.WriteLine("Please enter a product number: ");
        try
        {
            int response = int.Parse(Console.ReadLine().Trim());

            chosenProduct = products[response - 1];
        }
        catch (FormatException)
        {
            Console.WriteLine("Please type only integers!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Please choose an existing item only!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Do better!");
        }
    }

    Console.WriteLine(@$"You chose:
    {chosenProduct.Name}, which costs {chosenProduct.Price} galleons, and {(chosenProduct.Available ? "is available" : "is not available")}");

}

void AddProduct()
{

    Console.WriteLine("To add a product, please enter product name");

    string responseName = Console.ReadLine();

    Console.WriteLine("Please enter the product price");

    decimal responsePrice = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine(@"Please select a product type ID:
    0. Potions
    1. Apparel
    3. Enchanted Objects
    4. Wands");

    int responseID = int.Parse(Console.ReadLine());

    Product newProduct = new Product
    {
        Name = responseName,
        Price = responsePrice,
        Available = true,
        ProductTypeId = responseID

    };

    products.Add(newProduct);

    Console.WriteLine($"You added: {newProduct.Name}, which costs {newProduct.Price} galleons");
}

void DeleteProduct()
{
    Console.WriteLine("Please select product to delete:");
    Console.WriteLine("Products:");

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }

    Product chosenProduct = null;

    while (chosenProduct == null)
    {
        Console.WriteLine("Please enter a product number: ");
        try
        {
            int response = int.Parse(Console.ReadLine().Trim());

            chosenProduct = products[response - 1];
        }
        catch (FormatException)
        {
            Console.WriteLine("Please type only integers!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Please choose an existing item only!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Do better!");
        }
    }

    Console.WriteLine(@$"You chose:
    {chosenProduct.Name}, which costs {chosenProduct.Price} galleons, and {(chosenProduct.Available ? "is available" : "is not available")}");

    string choice = null;
    
    Console.WriteLine(@"Choose an option:
    0. Cancel
    1. Confirm delete");

    choice = Console.ReadLine();
      if (choice == "0")
      {
        Console.WriteLine("Delete cancelled");
      }
      else if (choice == "1")
      {
        products.Remove(chosenProduct);

      }
}

void UpdateProduct()
{
    Console.WriteLine("Please select product to update:");
    Console.WriteLine("Products:");

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }

    Product chosenProduct = null;

    while (chosenProduct == null)
    {
        Console.WriteLine("Please enter a product number: ");
        try
        {
            int response = int.Parse(Console.ReadLine().Trim());

            chosenProduct = products[response - 1];
        }
        catch (FormatException)
        {
            Console.WriteLine("Please type only integers!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Please choose an existing item only!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Do better!");
        }
    }

    Console.WriteLine(@$"You chose:
    {chosenProduct.Name}, which costs {chosenProduct.Price} galleons, and {(chosenProduct.Available ? "is available" : "is not available")}");

    Console.WriteLine(@"Please choose a field to edit:
        0. Name
        1. Price
        2. Available
        3. Product Type ID");

    int index = products.IndexOf(chosenProduct);

    int choice = int.Parse(Console.ReadLine());
    if (choice == 0)
    {
        Console.WriteLine("Please enter new name");
        string newName = Console.ReadLine();
        products[index].Name = newName;
    }
    else if (choice == 1)
    {
        Console.WriteLine("Please enter new price");
        decimal newPrice = Convert.ToDecimal(Console.ReadLine());
        products[index].Price = newPrice;

    } else if (choice == 2)
    {
        Console.WriteLine(@"Please select an option:
        0. Sold
        1. Available");

        int newChoice = int.Parse(Console.ReadLine());

        if (newChoice == 0)
        {
            products[index].Available = false;
        } else if (newChoice == 1)
        {
            products[index].Available = true;
        }

    } else if (choice == 3)
    {
        Console.WriteLine(@"Please enter new Product Type ID:
           0. Potions
           1. Apparel
           2. Enchanted Objects
           3. Wands");

        int newID = int.Parse(Console.ReadLine());
        products[index].ProductTypeId = newID;
    }

}

void FilterByType()
{
    Console.WriteLine(@"Please select a product type ID:
    0. Potions
    1. Apparel
    2. Enchanted Objects
    3. Wands");

    int response = int.Parse(Console.ReadLine());

    List<Product> filteredProducts = products.FindAll(x => x.ProductTypeId == response);

    foreach (Product product in filteredProducts)
    {
        Console.WriteLine($"{product.Name}");
    }
    filteredProducts.Clear();
}