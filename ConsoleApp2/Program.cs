using RevisoSharp.RevisoItems;
using System.Text.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        private static string _appSecretToken = "";
        private static string _agreementGrantToken = "";
        private static string _jsonDocumentStringList = "";
        private static int _pageSize = 0;
        private static int _skipPages = 0;

        static void Main(string[] args)
        {
            int row = 0;

            ConsoleKeyInfo pressedKey;
            bool exit = false;


            GetParameters();
            void GetParameters()
            {
                Console.WriteLine("Enter the AgreementGrantToken string and press <Enter>:");
                _agreementGrantToken = Console.ReadLine();
                Console.WriteLine("Enter the AppSecretToken string and press <Enter>:");
                _appSecretToken = Console.ReadLine();
                Console.WriteLine("Enter the number of elements returned from the api at every call, and press <Enter>:");
                if (!int.TryParse(Console.ReadLine(), out _pageSize))
                {
                    Console.WriteLine("Error: the value entered is not a number. It will be used the default value (10).");
                    return;
                }
                Console.WriteLine("Enter the skipPages param <Enter>:");
                if (!int.TryParse(Console.ReadLine(), out _skipPages))
                {
                    Console.WriteLine("Error: the value entered is not a number. It will be used the default value (0).");
                    return;
                }
            }

            if (_pageSize == 0) _pageSize = 10;

            TestApiAsync().Wait();

            async Task TestApiAsync()
            {
                string input = "";
                JsonSerializerOptions jsonOptions = new JsonSerializerOptions() { WriteIndented = true };
                do
                {
                    // Show instructions
                    Console.WriteLine("--------------" +
                                        "\r\nInstruction:" +
                                        "\r\n\t- Enter '0' and press <Enter> to get all customers" +
                                        "\r\n\t- Enter '1' and press <Enter> to get specific customers" +
                                        "\r\n\t- Enter '2' and press <Enter> to create a new customer" +
                                        "\r\n\t- Enter '10' and press <Enter> to get all orders" +
                                        "\r\n\t- Enter '11' and press <Enter> to get specific order" +
                                        "\r\n\t- Enter '12' and press <Enter> to create a new specific" +
                                        "\r\n\t- Press <Enter> to go back");
                    input = Console.ReadLine() ?? string.Empty;
                    Console.Clear();

                    try
                    {
                        RevisoClient client = new RevisoClient(_agreementGrantToken, _appSecretToken);
                        switch (input)
                        {
                            case "0":
                                {
                                    Console.Write("|");
                                    //var response = await client.GetVatZone("1");
                                    //var response = ApiCall(client);
                                    var response = client.GetCustomerAsync(_pageSize, _skipPages);
                                    int cnt = 0;
                                    while (!response.IsCompleted)
                                    {
                                        await WaitForResponseAsync(++cnt);
                                    }
                                    Console.Clear();
                                    Console.WriteLine("API result:\n\n");
                                    Console.WriteLine(JsonSerializer.Serialize(response?.Result, jsonOptions));
                                    break;
                                }
                            case "1":
                                {
                                    Console.WriteLine("\r\nEnter the specific customerNumber and press <Enter> to get it");
                                    string id = Console.ReadLine() ?? string.Empty;
                                    Console.Write("|");
                                    var response = client.GetCustomerAsync(id);
                                    int cnt = 0;
                                    while (!response.IsCompleted)
                                    {
                                        await WaitForResponseAsync(++cnt);
                                    }
                                    Console.Clear();
                                    Console.WriteLine("API result:\n\n");
                                    Console.WriteLine(JsonSerializer.Serialize(response?.Result, jsonOptions));
                                    break;
                                }
                            //case "2":
                            //    {
                            //        Console.WriteLine("\r\nEnter the specific customerNumber and press <Enter> to get it");
                            //        string id = Console.ReadLine() ?? string.Empty;
                            //        Console.Write("|");
                            //        var response = client.GetCustomer(id);
                            //        int cnt = 0;
                            //        while (!response.IsCompleted)
                            //        {
                            //            await WaitForResponseAsync(cnt);
                            //        }
                            //        Console.Clear();
                            //        Console.WriteLine("API result:\n\n");
                            //        Console.WriteLine(JsonSerializer.Serialize(response?.Result, jsonOptions));
                            //        break;
                            //    }
                            case "10":
                                {
                                    Console.Write("|");
                                    var response = client.GetOrderAsync(_pageSize, _skipPages);
                                    int cnt = 0;
                                    while (!response.IsCompleted)
                                    {
                                        await WaitForResponseAsync(++cnt);
                                    }
                                    Console.Clear();
                                    Console.WriteLine("API result:\n\n");
                                    Console.WriteLine(JsonSerializer.Serialize(response, jsonOptions));
                                    break;
                                }
                            case "11":
                                {
                                    Console.WriteLine("\r\nEnter the specific order and press <Enter> to get it");
                                    string id = Console.ReadLine() ?? string.Empty;
                                    Console.Write("|");
                                    var response = client.GetOrderAsync(id);
                                    int cnt = 0;
                                    while (!response.IsCompleted)
                                    {
                                        await WaitForResponseAsync(++cnt);
                                    }
                                    Console.Clear();
                                    Console.WriteLine("API result:\n\n");
                                    Console.WriteLine(JsonSerializer.Serialize(response?.Result, jsonOptions));
                                    break;
                                }
                            case "12":
                                {
                                    Order order = FormCreationOrder();
                                    Console.Write("|");
                                    var response = client.CreateOrderAsync(order);
                                    int cnt = 0;
                                    while (!response.IsCompleted)
                                    {
                                        await WaitForResponseAsync(++cnt);
                                    }
                                    Console.Clear();
                                    Console.WriteLine("API result:\n\n");
                                    Console.WriteLine(JsonSerializer.Serialize(response, jsonOptions));
                                    break;
                                }
                            case "":
                                {
                                    Console.Clear();
                                    exit = true;
                                    break;
                                }
                            default:
                                {
                                    Console.Clear();
                                    break;
                                }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    Console.WriteLine("\n");
                }
                while (!exit);



                // Declare a ResetConsole local method
                void ResetConsole()
                {
                    if (row > 0)
                    {
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    Console.Clear();
                    Console.WriteLine("\nPress <Enter> only to exit; otherwise, enter  and press <Enter>:\n");
                    row = 3;
                }
            }


        }

        private static async Task WaitForResponseAsync(int cnt)
        {
            if (cnt % 10 == 0)
            {
                Console.Clear();
                Console.Write("|");
            }
            Console.Write("*");
            await Task.Delay(100); // arbitrary delay
        }



        private static Order FormCreationOrder()
        {
            string? input;
            Order order = new Order();
            order.Notes = new Notes() { Heading = $"{DateTime.Now:yyyy-MM-ddThh:mm:ss} - PROVA!!!" };
            Console.WriteLine("CustomerNumber? :");
            order.Customer = new Customer() { CustomerNumber = int.TryParse(Console.ReadLine(), out int customerNumer) ? customerNumer : 0 };
            Console.WriteLine("Date? : (leave empty to get default value)");
            if (!string.IsNullOrEmpty(input = Console.ReadLine()))
                order.Date = DateTime.TryParse(input, out DateTime date) ? date : DateTime.Now;
            int cnt = 1;
            order.Lines = new List<OrderLine>();
            while (true)
            {
                Console.WriteLine($"Insert line nr. {cnt}? <Y>/<N>:");
                input = Console.ReadLine() ?? "";
                if (input.ToUpper() == "Y")
                {
                    OrderLine line = new OrderLine();
                    Console.WriteLine("Product? : (leave empty to get default value)");
                    if (!string.IsNullOrEmpty(input = Console.ReadLine()))
                        line.Product = new Product() { ProductNumber = input };
                    Console.WriteLine("Quantity? : (leave empty to get default value)");
                    if (!string.IsNullOrEmpty(input = Console.ReadLine()))
                        line.Quantity = double.TryParse(input, out double quantity) ? quantity : 0;
                    Console.WriteLine("Price? : (leave empty to get default value)");
                    if (!string.IsNullOrEmpty(input = Console.ReadLine()))
                        line.UnitNetPrice = decimal.TryParse(input, out decimal unitNetPrice) ? unitNetPrice : 0;
                    order.Lines.Add(line);
                    cnt++;
                }
                else if (input.ToUpper() == "N")
                {
                    break;
                }
            }
            Console.WriteLine("Currency EUR/USD? : (leave empty to get default value)");
            if (!string.IsNullOrEmpty(input = Console.ReadLine()))
                order.Currency = input ?? "EUR";
            Console.WriteLine("Payment Term?: (leave empty to get default value)");
            if (!string.IsNullOrEmpty(input = Console.ReadLine()))
                order.PaymentTerms.PaymentTermsNumber = int.TryParse(input, out int paymentTermsNumber) ? paymentTermsNumber : 6 ;
            //Console.WriteLine("Recipient?:");
            //order.Recipient = new Recipient() { };
            return order;
        }


        public class ErrorResponse
        {
            public ErrorResponse() { }
            public string Error { get; set; }
        }

    }
}