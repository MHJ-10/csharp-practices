using System.Collections;

namespace AnimalHusbandary
{
    public class Cow : Animal, IEnumerable, IComparable
    {
        public static new readonly int MaxLife;
        public static int Number;
        public Environment _list;
        public List<CowParameter> List;

        public DateTime BirthDate { get; }

        public Cow(Environment list)
        {
            _list.Density = list.Density;
            _list.TDS = list.TDS;
            _list.Temp = list.Temp;
            _list.AQI = list.AQI;
            _list.OX = list.OX;
            _list.db = list.db;
        }

       

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString() => "";
    }
}
