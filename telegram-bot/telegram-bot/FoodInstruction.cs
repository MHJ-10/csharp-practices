namespace telegram_bot
{
    public class FoodInstruction
    {
        public List<Step>? AnalyzedInstructions { get; set; }
    }
    public class Step
    {
        public List<StepItem>? Steps { get; set; }
    }
    public class StepItem
    {
        public int? Number { get; set; }
        public string? Step { get; set; }
    }
}
