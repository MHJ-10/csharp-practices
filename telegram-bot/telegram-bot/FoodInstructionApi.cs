using Newtonsoft.Json;

namespace telegram_bot
{

    public class FoodInstructionApi
    {

        public string FoodId { get; set; }
        string API_KEY = "9f9d2d880dd34413bfb2855fbbaec75c";

        public FoodInstructionApi(string foodId)
        {
            this.FoodId = foodId;
        }

        public async Task<List<Step>> GetFoodDetail()
        {
            HttpClient client = new HttpClient();
            string endpoint = $"https://api.spoonacular.com/recipes/{FoodId}/information?apiKey={API_KEY}";

            HttpResponseMessage response = await client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                FoodInstruction data = JsonConvert.DeserializeObject<FoodInstruction>(apiResponse);

                return data.AnalyzedInstructions;

            }
            else
            {
                throw new Exception("Cooking instructions not found.");
            }
        }
    }
}