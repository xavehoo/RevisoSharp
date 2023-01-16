using RevisoSharp;
using System.Text.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        private static string _appSecretToken = "";
        private static string _agreementGrantToken = "";
        private static string _jsonDocumentStringList = "";
        private static int _pageSize = 0;
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
                                        "\r\n\t- Enter '1' and press <Enter> to get all customers" +
                                        "\r\n\t- Enter '2' and press <Enter> to get specific customers" +
                                        "\r\n\t- Press <Enter> to go back");
                    input = Console.ReadLine() ?? string.Empty;
                    Console.Clear();

                    try
                    {
                        RevisoClient client = new RevisoClient(_agreementGrantToken, _appSecretToken);
                        switch (input)
                        {
                            case "1":
                                {
                                    Console.Write("|");
                                    //var response = await client.GetVatZone("1");
                                    //var response = ApiCall(client);
                                    var response = client.GetCustomer(_pageSize);
                                    int cnt = 0;
                                    while (!response.IsCompleted)
                                    {
                                        await WaitForResponseAsync(cnt);
                                    }
                                    Console.Clear();
                                    Console.WriteLine("API result:\n\n");
                                    Console.WriteLine(JsonSerializer.Serialize(response?.Result, jsonOptions));
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("\r\nEnter the specific customerNumber and press <Enter> to get it");
                                    string id = Console.ReadLine() ?? string.Empty;
                                    Console.Write("|");
                                    var response = client.GetCustomer(id);
                                    int cnt = 0;
                                    while (!response.IsCompleted)
                                    {
                                        await WaitForResponseAsync(cnt);
                                    }
                                    Console.Clear();
                                    Console.WriteLine("API result:\n\n");
                                    Console.WriteLine(JsonSerializer.Serialize(response?.Result, jsonOptions));
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
            if (cnt == 10)
            {
                cnt = 0;
                Console.WriteLine("|");
            }
            Console.Write("*");
            await Task.Delay(100); // arbitrary delay
            cnt++;
        }


        public class ErrorResponse
        {
            public ErrorResponse() { }
            public string Error { get; set; }
        }

    }
}