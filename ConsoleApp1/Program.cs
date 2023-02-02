using RestSharp;
using RevisoSharp.RevisoItems;
using System;
using System.Threading;
using System.Threading.Tasks;
using UtilityLibraries;

class Program
{
    private static string _appSecretToken = "";
    private static string _agreementGrantToken = "";
    private static string _jsonDocumentStringList = "";

    static void Main(string[] args)
    {
        int row = 0;

        ConsoleKeyInfo pressedKey;
        string input = "";
        bool exit = false;


        GetParameters();
        void GetParameters() {
            Console.WriteLine("Enter the AgreementGrantToken string and press <Enter>:");
            _agreementGrantToken = Console.ReadLine();
            Console.WriteLine("Enter the AppSecretToken string and press <Enter>:");
            _appSecretToken = Console.ReadLine();
        }

        TestApiAsync().Wait();

        async Task TestApiAsync()
        {
            try
            {
                RevisoClient client = new RevisoClient(_agreementGrantToken, _appSecretToken);
                //var request = new RestRequest();
                var response = await client.GetVatZone("1");
                //var response = await ApiCall(client, request);

                Console.WriteLine("|");
                Console.ReadLine();
                int cnt = 0;
                while (response == null)
                {
                    if (cnt == 10)
                    {
                        cnt = 0;
                        Console.WriteLine("|");
                    }
                    Console.Write("*");
                    await Task.Delay(1000); // arbitrary delay
                    cnt++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }

            do
            {

                // Show instructions
                Console.WriteLine("Instruction:" +
                                    "\r\n\t- Enter '1' and press <Enter> to get all customers" +
                                    "\r\n\t- Press <Enter> to go back");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine($"\n");
                        break;
                    case "":
                        exit = true;
                        break;
                    default:
                        break;
                }

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

    private static async Task<object> ApiCall(RevisoClient client)
    {
        //var response = await client.GetVatZone("1");
        //return response;
        return null;
    }

    public class ErrorResponse
    {
        public ErrorResponse() { }
        public string Error { get; set; }
    }



    //static void Main(string[] args)
    //{
    //    int row = 0;

    //    do
    //    {
    //        if (row == 0 || row >= 25)
    //            ResetConsole();
    //        string input = Console.ReadLine();

    //        if (string.IsNullOrEmpty(input)) break;
    //        Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: " +
    //                          $"{(input.StartsWithUpper() ? "Yes" : "No")}\n");
    //        row += 3;
    //    } while (true);
    //    return;

    //    // Declare a ResetConsole local method
    //    void ResetConsole()
    //    {
    //        if (row > 0)
    //        {
    //            Console.WriteLine("Press any key to continue...");
    //            Console.ReadKey();
    //        }
    //        Console.Clear();
    //        Console.WriteLine("\nPress <Enter> only to exit; otherwise, enter a string and press <Enter>:\n");
    //        row = 3;
    //    }
    //}
}