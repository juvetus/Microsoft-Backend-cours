// See https://aka.ms/new-console-template for more information
using EcommerceProjet;

Console.WriteLine("Hello, World!");

List<Clothing> produits = new List<Clothing>
{
    new Clothing("T-shirt", 20, "T-shirt en coton", "Vêtements", Size.M),
    new Clothing("Pantalon", 50, "Pantalon en jean", "Vêtements", Size.L),
    new Clothing("Chaussures", 80, "Chaussures de sport", "Vêtements", Size.XL),
    new Clothing("Casquette", 10, "Casquette de baseball", "Vêtements", Size.S),
    new Clothing("Veste", 100, "Veste en cuir", "Vêtements", Size.L),
    new Clothing("Short", 30, "Short de sport", "Vêtements", Size.M),
    new Clothing("Chaussettes", 5, "Chaussettes en coton", "Vêtements", Size.S),
    new Clothing("Pull", 70, "Pull en laine", "Vêtements", Size.XL),
    new Clothing("Jupe", 40, "Jupe en jean", "Vêtements", Size.M),
    new Clothing("Chemise", 60, "Chemise en coton", "Vêtements", Size.L)
};

foreach (var produit in produits)
{
    
        Console.WriteLine(produit);
        
    
}

Console.WriteLine("Appliquer une réduction de 10% sur tous les produits");

foreach (var produit in produits)
{
    produit.ApplyDiscount(10);
    Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(produit);
        Console.ResetColor();
}

Console.WriteLine("Appliquer une réduction de 20% sur les produits dont le prix est supérieur à 50");

foreach (var produit in produits)
{
    if (produit.Price > 50)
    {
        produit.ApplyDiscount(20);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(produit);
        Console.ResetColor();
    }
}

Console.WriteLine("Appliquer une réduction de 30% sur les produits dont la taille est L");

foreach (var produit in produits)
{
    if (produit.Size == Size.L)
    {
        produit.ApplyDiscount(30);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(produit);
        Console.ResetColor();
    }
}


