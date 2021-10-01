using System.Text.Json.Serialization;

namespace Dotnet_RPG.Models
{
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum RpgClass
  {
    Knight,
    Mage,
    Cleric
  }
}