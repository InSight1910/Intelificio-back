using System.Security.Claims;

namespace Intelificio_Back.Features.Authentication.Common
{
    public interface IJwtService
    {
        string CreateToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);
    }
}