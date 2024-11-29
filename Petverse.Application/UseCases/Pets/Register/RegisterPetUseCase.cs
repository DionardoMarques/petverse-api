using Petverse.Communication.Requests;
using Petverse.Communication.Responses;

namespace Petverse.Application.UseCases.Pets.Register;

public class RegisterPetUseCase
{
    public ResponseRegisteredPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisteredPetJson
        {
            Id = 7,
            Name = request.Name,
        };
    }
}
