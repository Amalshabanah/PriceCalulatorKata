namespace Price_Calculator_Kata;

public class Product
{ 
    public string ProductName { get; set; }
    public int Upc { get; set; }
    public double Price { get; set; }

    public double Tax { get; set; }
    public Product(string name, int upc, double price)
    {
        ProductName = name;
        Upc = upc;
        Price = price;
    }
    public double PriceAfterTax(double price, double tax) => price + price * (tax/100);
  

}