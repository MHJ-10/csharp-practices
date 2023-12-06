namespace AnimalHusbandary
{
    public class HealthParameter<T>
    {
        public string Name;
        public T Current, Standard;


        public override string ToString()
        {
            return $"{Name} - {Current} - {Standard}";

        }

        public float StressFactor()
        {
            return (Convert.ToSingle(Current) / Convert.ToSingle(Standard)) * 100;
        }

    }
}
