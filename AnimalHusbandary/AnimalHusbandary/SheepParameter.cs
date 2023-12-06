namespace AnimalHusbandary
{
    public class SheepParameter
    {

        public HealthParameter<int> TimeToStand;
        public HealthParameter<int> TimeToDeal;
        public HealthParameter<int> TimeToRelax;
        public HealthParameter<int> NumberOfMeal;
        public HealthParameter<int> NumberOfMilkProduction;

        public override string ToString() => "sheepParameter";

    }
}
