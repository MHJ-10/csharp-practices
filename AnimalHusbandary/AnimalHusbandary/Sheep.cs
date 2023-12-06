using System.Collections;

namespace AnimalHusbandary
{
    public class Sheep : Animal, IEnumerable, IComparable
    {

        public static readonly int MaxLife;
        public static int Number;
        public Environment _list;
        public List<SheepParameter> List;

        public DateTime BirthDate { get; }
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
