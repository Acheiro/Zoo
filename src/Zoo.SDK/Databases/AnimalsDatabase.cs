namespace Zoo.SDK.Databases
{
    using System.Collections.Generic;
    using Enumerations;
    using Models;

    public static class AnimalsDatabase
    {
        private static readonly List<Animal> AvailableAnimals = new List<Animal>
        {
            new Animal("Amur Leopard", true, AnimalCategory.Bird, AnimalRarity.Rare, TerrainType.Steppes),
            new Animal("Asian Elephant", true, AnimalCategory.Reptile, AnimalRarity.Uncommon, TerrainType.Desert),
            new Animal("Sloth", true, AnimalCategory.Mammal, AnimalRarity.Common, TerrainType.Aquarium),
            new Animal("Fin Whale", true, AnimalCategory.Amphibians, AnimalRarity.Uncommon, TerrainType.Aquarium),
            new Animal("Irrawaddy Dolphin", true, AnimalCategory.Bird, AnimalRarity.Common, TerrainType.Aquarium),
            new Animal("Red Panda", true, AnimalCategory.Reptile, AnimalRarity.Uncommon, TerrainType.Forest),
            new Animal("Tiger", true, AnimalCategory.Mammal, AnimalRarity.Common, TerrainType.Steppes),
            new Animal("Sea Turtle", true, AnimalCategory.Reptile, AnimalRarity.Rare, TerrainType.Aquarium),
            new Animal("Whale Shark", true, AnimalCategory.Fish, AnimalRarity.Common, TerrainType.Aquarium),
            new Animal("Skipjack Tuna", true, AnimalCategory.Fish, AnimalRarity.Rare, TerrainType.Forest),
            new Animal("Bald Eagle", true, AnimalCategory.Reptile, AnimalRarity.Uncommon, TerrainType.Forest),
            new Animal("Gray Wolf", true, AnimalCategory.Mammal, AnimalRarity.Common, TerrainType.Steppes),
            new Animal("Red Fox", true, AnimalCategory.Mammal, AnimalRarity.Uncommon, TerrainType.Forest),
            new Animal("Giraffe", true, AnimalCategory.Mammal, AnimalRarity.Common, TerrainType.Steppes),
            new Animal("Arctic Fox", true, AnimalCategory.Mammal, AnimalRarity.Uncommon, TerrainType.Forest)
        };

        public static Animal[] FindAnimals(AnimalRarity rarity) 
            => AvailableAnimals.FindAll(x => x.Rarity == rarity).ToArray();

        public static Animal[] FindAnimals(AnimalCategory category)
            => AvailableAnimals.FindAll(x => x.Category == category).ToArray();

        public static Animal[] FindAnimals(bool isProtected) 
            => AvailableAnimals.FindAll(x => x.IsProtected == isProtected).ToArray();

        public static Animal[] FindAnimals(TerrainType terrainType) 
            => AvailableAnimals.FindAll(x => x.TerrainType == terrainType).ToArray();

        public static Animal[] FindAnimals(AnimalCategory category, AnimalRarity rarity) 
            => AvailableAnimals.FindAll(x => x.Category == category && x.Rarity == rarity).ToArray();

        public static Animal[] FindAnimals(AnimalRarity rarity, TerrainType terrainType)
            => AvailableAnimals.FindAll(x => x.Rarity == rarity && x.TerrainType == terrainType).ToArray();

        public static Animal[] FindAnimals(AnimalRarity rarity, bool isProtected)
            => AvailableAnimals.FindAll(x => x.Rarity == rarity && x.IsProtected == isProtected).ToArray();

        public static Animal[] FindAnimals(AnimalCategory category, TerrainType terrainType)
            => AvailableAnimals.FindAll(x => x.Category == category && x.TerrainType == terrainType).ToArray();

        public static Animal[] FindAnimals(AnimalCategory category, bool isProtected)
            => AvailableAnimals.FindAll(x => x.Category == category && x.IsProtected == isProtected).ToArray();

        public static Animal[] FindAnimals(TerrainType terrainType, bool isProtected)
            => AvailableAnimals.FindAll(x => x.TerrainType == terrainType && x.IsProtected == isProtected).ToArray();

        public static Animal[] FindAnimals(AnimalCategory category, AnimalRarity rarity, TerrainType terrainType)
            => AvailableAnimals.FindAll(x => x.Category == category && x.Rarity == rarity && x.TerrainType == terrainType).ToArray();

        public static Animal[] FindAnimals(AnimalCategory category, AnimalRarity rarity, TerrainType terrainType, bool isProtected)
            => AvailableAnimals.FindAll(x => x.Category == category && x.Rarity == rarity && x.TerrainType == terrainType && x.IsProtected == isProtected).ToArray();
    }
}
