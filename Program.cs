using System;

namespace humansAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("waseem", 10, 8, 7, 100);
            Console.WriteLine($"Name: {human.Name} -- Strength: {human.Strength} -- Intelligence: {human.Intelligence} -- Dexterity: {human.Dexterity} -- Health: {human.Health}");
        }
    }
}
