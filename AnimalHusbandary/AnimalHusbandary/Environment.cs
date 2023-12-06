namespace AnimalHusbandary
{
    public class Environment
    {
        public HealthParameter<int> TDS;
        public HealthParameter<int> Temp;
        public HealthParameter<int> Density;
        public HealthParameter<int> db;
        public HealthParameter<int> AQI;
        public HealthParameter<int> OX;
        public DateTime date;



        public override string ToString()
        {
            return "Environment";

        }


    }
}
