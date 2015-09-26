using System;

namespace StringNormalization
{
    public class Program
    {
        public void Main(string[] args)
        {
            var penguin = "pingüino";

            Console.WriteLine(penguin.IsNormalized());
            Console.WriteLine(penguin.Normalize());
        }
    }
}
