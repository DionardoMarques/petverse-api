using Petverse.Communication.Enums;

namespace Petverse.Communication.Responses;

public class ResponseShortPetJson
{
    public int Id {  get; set; }
    public string Name { get; set; } = string.Empty;
    public PetType Type { get; set; }
}
