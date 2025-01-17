using Dotnet_RPG.Models;

namespace Dotnet_RPG.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Frodo";

        public int HitPoint { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Knight;

    }
}