using RealEstateAuction.Business.Services.Interface;
using RealEstateAuction.Data.Repositories.Interface;

namespace RealEstateAuction.Business.Services.Implements
{
    public class AuthenticationService: IAuthenticationService
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
