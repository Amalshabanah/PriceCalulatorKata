using PriceCalKata.Services;
namespace PriceCalKata.Models
{
    public class program
    {
        public static void Main(string[] args)
        {
            Product product = new Product("The Little Prince" , 12345 , 20.25 );
            product.UpcDiscount= product.CalculateDiscountAfterCheckUpc(product.Upc , product.UpcWithDiscount);
            double []values = ReadFromConsole(); // values array contains [tax , discount]
            product.Tax = values[0]; 
            product.Discount = values[1];
            product.PackagingCost = values[2];
            product.TransportCost = values[3];
            double priceAfter = product.CalculateFinalPrice(product.Price , product.Tax , product.Discount , product.UpcDiscount , product.PackagingCost , product.TransportCost); 
            product.PrintInfo(product.ProductName , product.Upc , product.Price); 
            product.PrintFinalPrice(product.Price , product.Tax , product.Discount , product.UpcDiscount , product.PackagingCost , product.TransportCost);
        }
        public static double [] ReadFromConsole()
        {
            Console.WriteLine("Please Specify The Tax");
            double tax = Convert.ToDouble(Console.ReadLine());
            double discount = 0;
            Console.WriteLine("Is There a discount? \n 1.Enter 1 if Yes!\n 2.Enter 2 if No!");
            int discountStatus= Convert.ToInt32(Console.ReadLine());
            if (discountStatus == 1)
            {
                Console.WriteLine("Please Specify The Discount.");
                 discount = Convert.ToDouble(Console.ReadLine());
            }
            else if (discountStatus == 2)
            {
                discount = 0;
            }
            else
            {
                Console.WriteLine("Please Enter either 1 or 2.");
            }
            Console.WriteLine("Is There any Packaging costs? \n 1.Enter 1 for Yes!.\n 2.Enter 2 for No!");
            double packagingCost = 0;
            int packagingStatus= Convert.ToInt32(Console.ReadLine());
            if (packagingStatus== 1)
            {
                Console.WriteLine("Please Specify The packaging Cost.");
                packagingCost = Convert.ToDouble(Console.ReadLine());
            }
            else if (packagingStatus == 2)
            {
                packagingCost = 0;
            }
            else
            {
                Console.WriteLine("Please Enter either 1 or 2.");
            }
            
            Console.WriteLine("Is There any trnasport costs? \n 1.Enter 1 for Yes!.\n 2.Enter 2 for No!");
            double transportCost = 0;
            int transportStatus= Convert.ToInt32(Console.ReadLine());
            if (transportStatus== 1)
            {
                Console.WriteLine("Please Specify The transport Cost.");
                transportCost = Convert.ToDouble(Console.ReadLine());
            }
            else if (transportStatus == 2)
            {
                transportCost = 0;
            }
            else
            {
                Console.WriteLine("Please Enter either 1 or 2.");
            }
            return new[] {tax , discount , packagingCost ,transportCost};
        }
    }
}