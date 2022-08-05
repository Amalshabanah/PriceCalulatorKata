using PriceCalKata.Services;
namespace PriceCalKata.Models
{
    public class program
    {
        public static void Main(string[] args)
        {
            Product product = new Product("The Little Prince", 12345, 20.25 );
            double []values = ReadFromConsole(); // values array contains [tax , discount]
            product.Tax = values[0]; 
            product.Discount = values[1]; 
            double priceAfter = product.CalculateFinalPrice(product.Price , product.Tax , product.Discount); 
            product.PrintInfo(product.ProductName , product.Upc , product.Price); 
            product.PrintFinalPrice(product.Price , product.Tax , product.Discount);
        }
        public static double [] ReadFromConsole()
        {
            Console.WriteLine("Please Specify The Tax");
            double tax = Convert.ToDouble(Console.ReadLine());
            double discount =0;
            Console.WriteLine("Is There a discount? \n 1.Enter 1 if Yes!\n 2.Enter 2 if No!");
            int discountStatus= Convert.ToInt32(Console.ReadLine());
            if (discountStatus == 1)
            {
                Console.WriteLine("Please Specify The Discount.");
                 discount = Convert.ToInt32(Console.ReadLine());
            }
            else if (discountStatus == 2)
            {
                discount = 0;
            }
            else
            {
                Console.WriteLine("Please Enter either 1 or 2.");
            }

            return new[] {tax , discount};
        }
    }

}