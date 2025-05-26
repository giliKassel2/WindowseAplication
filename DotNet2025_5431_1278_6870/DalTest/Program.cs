
using DalApi;
using Dal;
using DO;
using Tools;
using System.Reflection;
namespace DalTest;
internal class Program
    
{
    private static readonly IDal s_dal = DalApi.Factory.Get;
    public static int printMainMenu()
    {
        Console.WriteLine("for products prese 1");
        Console.WriteLine("for customer prese 2");
        Console.WriteLine("for sales prese 3");
        Console.WriteLine("for clean log prese 111");
        Console.WriteLine("for exit prese 0");
        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }

    public static int PrintSubMunu(string item)
    {
        {
            Console.WriteLine($"to add {item} press 1");
            Console.WriteLine($"to read one {item} press 2");
            Console.WriteLine($"to read all {item} press 3");
            Console.WriteLine($"to update {item} press 4");
            Console.WriteLine($"to delete {item} press 5");
            Console.WriteLine($"to go back  press 0");

        }
        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;

    }

    public static void Crud<T>(string item,ICrud<T> crud)
    {
        int select = PrintSubMunu(item);
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    switch (item)
                    {
                        case "Customer":
                            CreateCustomer();
                            break;
                        case "Product":
                            createProduct();
                            break;
                        case "Sale":
                            createSale();
                            break;
                    }
                    break;

                case 2:
                    read(crud);
                    break;
                case 3:
                    ReadAll(crud);
                    break;
                case 4:
                    switch (item)
                    {
                        case "Customer":
                            UpdateCustomer();
                            break;
                        case "Product":
                            updateProduct();
                            break;
                        case "Sale":
                            updateSale();
                            break;
                    }
                    break;
                case 5:
                    Delete(crud);
                    break;
                default:
                    Console.WriteLine("error enter: plese enter agin");
                    break;

            }
            select = PrintSubMunu(item);
        }
    }
   
    public static void printMenu(int select)
    {
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    Console.WriteLine("product");
                    Crud("product", s_dal.Product);
                    break;
                case 2:
                    Console.WriteLine("customer");
                    Crud("customer",s_dal.Customer);
                    break;
                case 3:
                    Console.WriteLine("sale");
                    Crud("sale", s_dal.Sale);
                    break;
                case 111:
                    LogManager.clearLog();
                    break;
                default: Console.WriteLine("error enter: plese enter agin");
                    break;

            }
            select = printMainMenu();
        }
    }

  public static Product createOrUpdateProduct(int code=0)
    {
        Console.WriteLine("insert product details:");
        Console.WriteLine("product name:");
        string name = Console.ReadLine();
        Console.WriteLine("price:");
        int price;
        int.TryParse(Console.ReadLine(),out price);
        Console.WriteLine("quantity");
        int quantity;
        int.TryParse(Console.ReadLine(),out quantity);
        Console.WriteLine("category");
        Categories category;
        Categories.TryParse( Console.ReadLine(),out category);
        return new Product(code,name, price, quantity, category);
    }

    public static Sale createOrUpdateSale(int code =0)
    {
        Console.WriteLine("insert sale details:");
        Console.WriteLine("Product id:");
        int id;
        int.TryParse(Console.ReadLine(),out id);
        Console.WriteLine("Quantity for sale:");
        int quantityForSale;
        int.TryParse(Console.ReadLine(), out quantityForSale);
        Console.WriteLine("Sale price:");
        int salePrice;
        int.TryParse(Console.ReadLine(), out salePrice);
        Console.WriteLine("nead club:");
        bool isClub;
        bool.TryParse(Console.ReadLine(),out isClub);
        Console.WriteLine("start sale:");
        DateTime startSale;
        DateTime.TryParse(Console.ReadLine(), out startSale);
        Console.WriteLine("start sale:");
        DateTime endSale;
        DateTime.TryParse(Console.ReadLine(), out endSale);
        return new Sale(code,id,quantityForSale,salePrice,isClub,startSale,endSale);
    }
    private static Customer CreateOrUpdateCustomer()
    {
        Console.WriteLine("Insert customer details:");
        Console.WriteLine("id:");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        Console.WriteLine("customerName:");
        string name = Console.ReadLine();
        Console.WriteLine("address:");
        string address = Console.ReadLine();
        Console.WriteLine("phone number:");
        string phoneNumber = Console.ReadLine();
        return new Customer(id, name, address, phoneNumber);
    }
    public static void createProduct()
    {
        try
        {
            s_dal.Product.Create(createOrUpdateProduct());
        }
        catch(Exception e) {
            Console.WriteLine(e.Message);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);

        }
    }
    public static void updateProduct()
    {
        Console.WriteLine("insret code");
        int code;
        int.TryParse(Console.ReadLine(),out code);
        try
        {
            s_dal.Product.Update(createOrUpdateProduct(code));
        }
        catch (Exception e)
        {
            LogManager.writeToLog(
            MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);
            Console.WriteLine(e.Message); }
    }

    public static void updateSale()
    {
        Console.WriteLine("insert code sale to update");
        int code;
        int.TryParse(Console.ReadLine(),out code);
        try
        {
            s_dal.Sale.Update (createOrUpdateSale(code));
        }
        catch(Exception e) {
            Console.WriteLine(e.Message);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);

        }
    }

    public static void createSale()
    {
        try { s_dal.Sale.Create(createOrUpdateSale()); }
        catch (Exception e) {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);

            Console.WriteLine(e.Message); }
    }
    private static void CreateCustomer()
    {
        try
        {
            s_dal.Customer.Create(CreateOrUpdateCustomer());
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);

            Console.WriteLine(e.Message);
        }
    }
    private static void UpdateCustomer()
    {
        try
        {
            s_dal.Customer.Update(CreateOrUpdateCustomer());
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);

            Console.WriteLine(e.Message);
        }
    }
   
    public static void read<T>(ICrud<T> crud)
    {
        try
        {
            Console.WriteLine("insert code to read");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine(crud.Read(code));
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);

            Console.WriteLine(e.Message);
        }
    }
    public static void Delete<T>(ICrud<T> crud)
    {
        try
        {
            Console.WriteLine("insert a code:");
            int code = int.Parse(Console.ReadLine());
            crud.Delete(code);
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);

            Console.WriteLine(e.Message);
        }
    }
    public static void ReadAll<T>(ICrud<T> crud)
    {
        try
        {
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);

            Console.WriteLine(e.Message);
        }
    }

   // public static void 
    static void Main(string[] args)
    {
        try
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start Initialization");

            Initialization.initelaize();
          printMenu(printMainMenu());
        }
        catch(Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, e.Message);

            Console.WriteLine(e.Message);
        }
    }
}