namespace AnimalHusbandary
{
    public abstract class Animal
    {
        public float Weight;
        public bool gender;
        public float Name;
        public static readonly int MaxLife;
        public Environment list;
        public DateTime BirthDate { get; init; }

       


        public float StressFactor()
        {
            return (list.TDS.StressFactor() + list.Temp.StressFactor() + list.Density.StressFactor() +
                list.db.StressFactor() + list.AQI.StressFactor() + list.OX.StressFactor()) / 6;
        }
        public int Life()
        {
            int timeToDie = TimeToDie();

            return ((int)Weight + timeToDie) / 2;

        }
        public int TimeToDie()
        {
            DateTime now = DateTime.Now;
            var age = (now.Subtract(BirthDate).Days) / 365;

            return MaxLife - age;
        }
        public int KillPriority()
        {
            int a = (int)Weight + MaxLife;
            int killPriority;

            if (gender)
            {
                killPriority = a * 1;
            }
            else
            {
                killPriority = a * 2;
            }

            return killPriority;

        }
        public int CostPerDay() => (int)Weight * 15000;
        public int ValuePerDay()
        {
            var timeToDie = TimeToDie();

            return (int)Weight / timeToDie;
        }


    }
}
