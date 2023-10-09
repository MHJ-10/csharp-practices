namespace PracticeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Food = "cooked meat";
            cat.Size = "medium";
            cat.Introduce();


            Horse horse = new Horse();
            horse.Food = "grass";
            horse.Size = "Big";
            horse.Movement("very fast");
            horse.Introduce();


        }

    }

}

