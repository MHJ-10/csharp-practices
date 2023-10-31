namespace telegram_bot
{
    public class FoodsList
    {
        public List<Food>? Results { get; set; }
    }
    public class Food
    {
        public int? Id { get; set; }
        public string? Title { get; set; }

    }
}
