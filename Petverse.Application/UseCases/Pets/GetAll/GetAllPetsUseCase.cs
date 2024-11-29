using Petverse.Communication.Responses;

namespace Petverse.Application.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Nino",
                    Type = Communication.Enums.PetType.Cat
                }
            }
        };
    }
}
