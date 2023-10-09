namespace PracticeTwo
{
    public class Cow : Animal
    {
        public override void Movement(string movementSpeed)
        {
            Console.WriteLine($"Cow is {movementSpeed} animal.");
        }
    }

}


