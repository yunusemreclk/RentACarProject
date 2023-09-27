using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RentACarProject.Core.Entities.Concrete;
using RentACarProject.Core.Extensions;
using RentACarProject.Core.Utilities.Security.Encryption;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Core.Utilities.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; } // appjson dosyasını okumak için gerekli sınıfımız
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

        }
        //CreateToken metodunu implamente ettik ve jwt için erekli tüm bilgileri topluyoruz
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration); //Configuration sınıfını kullanarak WebAPI/appjson sınıfımız kalasörümüzdeki değerleri tek tek okuyarak, AccessTokenExpression değerimizi aldık.
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);//appjson SecurityKey değerimiziçektik
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);//hangi anahtarı,hangi algoritmayı kullanacağımızı söylüyoruz(Encryption)
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);//jwt üretirken neleri kullanacağımızı söyledik
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };

        }
        // yukarıdaki elde ettiğimiz değerleri kullanarak jwt tokenı oluşturuyoruz
        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims),
                signingCredentials: signingCredentials
            );
            return jwt;
        }
        //claim listesi de oluşturuyoruz
        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;
        }
    }
}
