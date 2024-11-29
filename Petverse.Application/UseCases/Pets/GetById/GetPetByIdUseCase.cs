using Petverse.Communication.Responses;

namespace Petverse.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Nino",
            Type = Communication.Enums.PetType.Cat,
            Birthday = new DateTime(year: 2023, month: 01, day: 01)
        };
    }
}
