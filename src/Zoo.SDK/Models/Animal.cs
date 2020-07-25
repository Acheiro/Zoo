namespace Zoo.SDK.Models
{
    using Enumerations;

    public readonly struct Animal
    {
        public string Specie { get; }

        public bool IsProtected { get; }

        public AnimalRarity Rarity { get; }

        public AnimalCategory Category { get; }

        public TerrainType TerrainType { get; }

        private string TerrainDetails => TerrainType switch
        {
            TerrainType.Forest => "Lives in the forests",
            TerrainType.Desert => "Lives in the deserts",
            TerrainType.Steppes => "Lives on the steppes",
            TerrainType.Aquarium => "Lives underwater",
            _ => "Lives in unknown terrain"
        };

        private string ProtectionDetails 
            => IsProtected ? "Is under protection" : "Isn't under protection";

        public Animal(string specie, bool isProtected, AnimalCategory category, AnimalRarity rarity, TerrainType terrainType)
        {
            Specie = specie;
            Rarity = rarity;
            Category = category;
            TerrainType = terrainType;
            IsProtected = isProtected;
        }

        public override string ToString() => $"{Specie}:\n* {Category}\n* {Rarity}\n* {TerrainDetails}\n* {ProtectionDetails}\n";
    }
}