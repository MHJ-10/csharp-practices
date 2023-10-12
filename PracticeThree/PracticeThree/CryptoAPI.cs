using System.Text.Json;

namespace PracticeThree
{
    public class CryptoAPI
    {

        string API_KEY = "118d6e64ce0cd27d872d86ecd033b9a6da11c2f479002168bf7faec12d20b8ce";

        public async Task<List<Crypto>> GetCrypto(int limitNumber)
        {
            HttpClient client = new HttpClient();
            string endpoint = $"https://min-api.cryptocompare.com/data/top/totalvolfull?limit={limitNumber}&tsym=USD&api_key={API_KEY}";

            HttpResponseMessage response = await client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                ApiResponseWrapper data = JsonSerializer.Deserialize<ApiResponseWrapper>(apiResponse);

                return data.Data;

            }
            else
            {
                throw new Exception("failed to get data from api.");
            }

        }

    }




}
