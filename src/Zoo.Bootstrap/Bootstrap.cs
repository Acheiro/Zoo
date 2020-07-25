namespace Zoo.Bootstrap
{
    using System;
    using SDK.Databases;
    using SDK.Enumerations;

    internal static class Bootstrap
    {
        private static void Main()
        {
            foreach (var animal in AnimalsDatabase.FindAnimals(AnimalCategory.Mammal, AnimalRarity.Uncommon))
                Console.WriteLine($"{animal}");
        }
    }
}
