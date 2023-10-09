namespace PracticeTwo
{
    public abstract class Animal
    {
        public string? Food { get; set; }
        public string? Size { get; set; }

        public abstract void Movement(string move);

        public void Introduce()
        {
            Console.WriteLine($"this animal is {Size} and eats {Food}.");
        }

    }

}


