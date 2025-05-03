using BlApi;
using BO;
namespace BlTest;

internal class Program
{


    static readonly BlApi.IBl s_bl = BlApi.Factory.Get;


    public static void createOrder()
    {
        int new_order = 1;
        while (new_order == 1)
        {

            Console.WriteLine("Enter the customer type!");
            Console.WriteLine("To manager press 1\r\nTo the worker press 2\r\nFor the customer press 3");
            int n;
            int.TryParse(Console.ReadLine(), out n);
             CustomerPreference Preference = (CustomerPreference)n;
            
            Console.WriteLine("insert id");
            int id;
            int.TryParse(Console.ReadLine(), out id);

            Order order = new Order(Preference);



            Console.WriteLine("insert product for exist insert 0");
            int code;
            int.TryParse(Console.ReadLine(), out code);
            while (code != 0)
            {
                Console.WriteLine("insert count from this product");
                int count;
                int.TryParse(Console.ReadLine(), out count);
                Console.WriteLine(s_bl.Order.AddProductToOrder(order, code, count));
                Console.WriteLine(order.TotalPrice);
                Console.WriteLine("insert product for exist insert 0");
                int.TryParse(Console.ReadLine(), out code);

            }
        }
        Console.WriteLine("to add new orser insert 1 to exsist pres 0");
        int.TryParse(Console.ReadLine(), out new_order);
    }


    static void Main(String[] args)
    {
    createOrder();
    }
}
