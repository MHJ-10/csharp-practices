using Newtonsoft.Json;

namespace telegram_bot
{
    public class FoodsListApi
    {
        public string Food { get; set; }
        string API_KEY = "9f9d2d880dd34413bfb2855fbbaec75c";

        public FoodsListApi(string food)
        {
            this.Food = food;
        }

        public async Task<List<Food>> GetFoodsList()
        {

            HttpClient client = new HttpClient();
            string endpint = $"https://api.spoonacular.com/recipes/complexSearch?apiKey={API_KEY}&query={Food}";
            HttpResponseMessage response = await client.GetAsync(endpint);

            if (response.IsSuccessStatusCode)
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                FoodsList data = JsonConvert.DeserializeObject<FoodsList>(apiResponse);

                return data.Results;
            }
            else
            {
                throw new Exception("Failed to get list of foods.");
            }

        }

    }
}
