namespace PracticeThree
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            CryptoAPI api = new CryptoAPI();

            List<Crypto> CryptoCurrenices = await api.GetCrypto(10);

            foreach (Crypto crypto in CryptoCurrenices)
            {
                Console.WriteLine($"Name: {crypto.CoinInfo.Name}");
                Console.WriteLine($"Full Name: {crypto.CoinInfo.FullName}");
                Console.WriteLine($"Price: {crypto.DISPLAY?.USD?.PRICE ?? "Unknown"}");
                Console.WriteLine();
            }

        }
    }


}
