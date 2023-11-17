using RentACarProject.Core.Entities.Concrete;
using RentACarProject.Core.Utilities.Results;
using RentACarProject.Core.Utilities.Security.Jwt;
using RentACarProject.Entities.DTOs;

namespace RentACarProject.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
